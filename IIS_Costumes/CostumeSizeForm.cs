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
                mainGB.Visible = value == State.Add || value == State.Edit;
                searchTB.Enabled = mainDGV.Visible = addButton.Enabled = editButton.Enabled =
                    deleteButton.Enabled = value == State.Table;
                mainGB.Text = value == State.Add ? "Добавление размера костюма" :
                    "Редактирование размера костюма";

                if (value == State.Edit) curCS_id = (int)DB.GetRowCol(mainDGV.SelectedRows[0], "id_costume_size");
            }
        }

        OrderForm orderForm;
        State curState;
        int curCS_id;

        private void SetGB(DataGridViewRow row = null)
        {
            DB.FillCB(costumeCB, Properties.Resources.CostumeQuery, "id_costume", "name");
            DB.FillCB(sizeCB, Properties.Resources.SizeQuery, "id_size", "name_num");
            amountTB.Text = "1";
            if (row == null) return;
            curCS_id = (int)DB.GetRowCol(row, "id_costume_size");
            costumeCB.SelectedValue = DB.GetRowCol(row, "costume_id");
            sizeCB.SelectedValue = DB.GetRowCol(row, "size_id");
            amountTB.Text = DB.GetRowCol(row, "amount").ToString();
        }

        private void SetMainDGV(string search = "")
        {
            string query = string.Format("CALL costume_size_search('{0}')", search);
            DB.FillDGV(mainDGV, query);
        }
        
        private void AddOrderCostume(DataGridViewRow row = null) // доделать
        {
            int costume_size_id = row == null ? curCS_id : (int)DB.GetRowCol(row, "id_costume_size");
            string costume_name = row == null ? costumeCB.Text : DB.GetRowCol(row, "costume_name").ToString();
            string vendor = "";
            string size_name_num = row == null ? sizeCB.Text :
                DB.GetRowCol(row, "size_name_num").ToString();
            int costume_price = row == null ?
                (int)(costumeCB.DataSource as DataTable).Rows[costumeCB.SelectedIndex]["price"] :
                (int)DB.GetRowCol(row, "costume_price");
            int costume_daily_price = row == null ?
                (int)(costumeCB.DataSource as DataTable).Rows[costumeCB.SelectedIndex]["daily_price"] :
                (int)DB.GetRowCol(row, "costume_daily_price");
            DateTime returndate_shedule = DateTime.Now.AddDays(7);
            orderForm.costumeDT.Rows.Add(costume_size_id, costume_name, vendor, size_name_num, costume_price,
                costume_daily_price, null, returndate_shedule, null);
        }

        public CostumeSizeForm(Form callerForm = null)
        {
            InitializeComponent();
            if (callerForm != null && callerForm.GetType() == typeof(OrderForm))
                orderForm = (OrderForm)callerForm;
            addOrderButton.Enabled = orderForm != null;
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
                    DB.GetRowCol(rows[0], "costume_name"));
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
                      select DB.GetRowCol(x, "id_costume_size");
            string query = string.Format("DELETE FROM `costume_size` WHERE `id_costume_size` IN ({0})",
                string.Join(", ", ids));
            DB.SetNoResultQuery(query);
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
            if (CurState == State.Add)
                curCS_id = DB.SetNoResultQuery(query);
            else
                DB.SetNoResultQuery(query);
            SetMainDGV(searchTB.Text);
            if (orderForm != null && orderForm.CurState == OrderForm.State.Add) AddOrderCostume();
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

        private void mainDGV_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (orderForm == null || orderForm.CurState != OrderForm.State.Add)
            {
                CurState = State.Edit;
                return;
            }
            foreach (DataGridViewRow row in mainDGV.SelectedRows)
            {
                AddOrderCostume(row);
            }
        }

        private void addOrderButton_Click(object sender, EventArgs e)
        {
            if (orderForm.CurState != OrderForm.State.Add)
                orderForm.CurState = OrderForm.State.Add;
            foreach (DataGridViewRow row in mainDGV.SelectedRows)
            {
                AddOrderCostume(row);
            }
        }
    }
}
