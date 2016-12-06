using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IIS_Costumes
{
    public partial class CostumeSizeForm : Form
    {
        public enum State
        {
            Table,
            Add,
            Edit
        };

        public State CurState
        {
            get { return curState; }
            set
            {
                curState = value;
                mainGB.Visible = value != State.Table;
                searchTB.Enabled = mainDGV.Visible = addButton.Enabled = editButton.Enabled =
                    deleteButton.Enabled = value == State.Table;
                mainGB.Text = value == State.Add ? "Добавление размера костюма" :
                    "Редактирование размера костюма";
                CancelButton = value == State.Edit || value == State.Add ? cancelButton : null;
            }
        }

        State curState;
        int curCS_id;

        private void SetGB(DataGridViewRow row = null)
        {
            DBConnector.FillCB(costumeCB, Properties.Resources.CostumeQuery, "id_costume", "name");
            DBConnector.FillCB(sizeCB, Properties.Resources.SizeQuery, "id_size", "name_num");
            amountTB.Text = "1";
            if (row == null) return;
            curCS_id = (int)DBConnector.GetRowCol(row, "id_costume_size");
            costumeCB.SelectedValue = DBConnector.GetRowCol(row, "costume_id");
            sizeCB.SelectedValue = DBConnector.GetRowCol(row, "size_id");
            amountTB.Text = DBConnector.GetRowCol(row, "amount").ToString();
        }

        public CostumeSizeForm(Form callerForm = null)
        {
            InitializeComponent();
            this.callerForm = callerForm;
        }

        Form callerForm;

        private void SetMainDGV(string search = "")
        {
            string query = string.Format("CALL costume_size_search('{0}')", search);
            DBConnector.FillDGV(mainDGV, query);
        }

        private void CostumeSizeForm_Load(object sender, EventArgs e)
        {
            mainDGV.AutoGenerateColumns = false;

            SetMainDGV();
            CurState = State.Table;
        }

        private void searchTB_TextChanged(object sender, EventArgs e)
        {
            SetMainDGV(searchTB.Text);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            CurState = State.Add;
            SetGB();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            CurState = State.Edit;
            SetGB(mainDGV.SelectedRows[0]);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection rows = mainDGV.SelectedRows;
            int n = rows.Count;
            string text;
            string caption;
            if (n == 1)
            {
                text = string.Format("Вы уверены, что хотите удалить размер костюма \n{0}?",
                    DBConnector.GetRowCol(rows[0], "costume_name"));
                caption = "Удаление размера костюма";
            }
            else
            {
                Func<string> GetWordForm = () =>
                {
                    if (n % 100 >= 11 && n % 100 <= 19) return "размеров костюмов";
                    if (n % 10 == 1) return "размер костюма";
                    if (n % 10 >= 2 && n % 10 <= 4) return "размера костюма";
                    return "размеров костюмов";
                };

                text = string.Format("Вы уверены, что хотите удалить {0} {1}?",
                    n, GetWordForm());
                caption = "Удаление размеров костюмов";
            }
            DialogResult answer = MessageBox.Show(text, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (answer == DialogResult.No) return;

            var ids = from DataGridViewRow x in rows
                      select DBConnector.GetRowCol(x, "id_costume_size");
            string query = string.Format("DELETE FROM `costume_size` WHERE `id_costume_size` IN ({0})",
                string.Join(", ", ids));
            DBConnector.SetNoResultQuery(query);
            SetMainDGV(searchTB.Text);
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            string query;
            int amount;
            try
            {
                amount = Convert.ToInt32(amountTB.Text);
            }
            catch
            {
                MessageBox.Show("Заполните поля корректно");
                return;
            }
            if (CurState == State.Add)
            {
                query = string.Format("INSERT INTO `costume_size` (`costume_id`, `size_id`, `amount`) " +
                    "VALUES ({0}, {1}, {2})", costumeCB.SelectedValue, sizeCB.SelectedValue, amount);
            }
            else
            {
                query = string.Format("UPDATE `costume_size` SET `costume_id` = {0}, `size_id` = {1}, " +
                    "`amount` = {2} WHERE `id_costume_size` = {3}",
                    costumeCB.SelectedValue, sizeCB.SelectedValue, amount, curCS_id);
            }
            DBConnector.SetNoResultQuery(query);
            SetMainDGV(searchTB.Text);
            CurState = State.Table;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            CurState = State.Table;
        }

        private void selectCostumeButton_Click(object sender, EventArgs e)
        {
            new CostumeForm(this).ShowDialog();
        }
    }
}
