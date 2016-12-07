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
            Edit,
            Select
        };

        public State CurState
        {
            get { return curState; }
            set
            {
                curState = value;
                mainGB.Visible = value == State.Add || value == State.Edit;
                selectionGB.Visible = value == State.Select;
                searchTB.Enabled = mainDGV.Visible = addButton.Enabled = editButton.Enabled =
                    deleteButton.Enabled = value == State.Table;
                mainGB.Text = value == State.Add ? "Добавление размера костюма" :
                    "Редактирование размера костюма";

                if (value == State.Edit) curCS_id = (int)DB.GetRowCol(mainDGV.SelectedRows[0], "id_costume_size");
                if (value == State.Select && orderDR == null) SetSelectGB();
            }
        }

        DataRow orderDR;
        Form callerForm;
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

        private void SetSelectGB()
        {
            vendorTB.Text = "";
            returndateSheduleDTP.Value = DateTime.Now.AddDays(7);
            noteRTB.Text = "";
        }
        
        private void AddOrderCostume(DataGridViewRow row = null) // доделать
        {
            int costume_size_id = row == null ? curCS_id : (int)DB.GetRowCol(row, "id_costume_size");

            string costume_name = row == null ? costumeCB.Text :
                DB.GetRowCol(row, "costume_name").ToString();
            string vendor = vendorTB.Text;
            string size_name = row == null ? sizeCB.Text :
                DB.GetRowCol(row, "size_name_num").ToString();
            int price = row == null ?
                (int)(costumeCB.DataSource as DataTable).Rows[costumeCB.SelectedIndex]["price"] :
                (int)DB.GetRowCol(row, "costume_price");
            int costume_daily_price = row == null ?
                (int)(costumeCB.DataSource as DataTable).Rows[costumeCB.SelectedIndex]["daily_price"] :
                (int)DB.GetRowCol(row, "costume_daily_price");
            DateTime returndate_shedule = returndateSheduleDTP.Value;
            string note = noteRTB.Text;
            (callerForm as OrderForm).costumeDT.Rows.Add(costume_size_id, costume_name, vendor,
                size_name, price, costume_daily_price, returndate_shedule, note, 0);
            (callerForm as OrderForm).Total += price;
        }

        public CostumeSizeForm(Form callerForm = null)
        {
            InitializeComponent();
            this.callerForm = callerForm;
        }

        public CostumeSizeForm(DataRow orderDR) : this()
        {
            this.orderDR = orderDR;

            vendorTB.Text = orderDR["vendor"].ToString();
            returndateSheduleDTP.Value = (DateTime)orderDR["returndate_shedule"];
            noteRTB.Text = orderDR["note"].ToString();
        }

        private void CostumeSizeForm_Load(object sender, EventArgs e)
        {
            mainDGV.AutoGenerateColumns = false;

            SetMainDGV();
            CurState = orderDR == null ? State.Table : State.Select;
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
            CurState = State.Table;
            if (callerForm != null && callerForm.GetType() == typeof(OrderForm))
            {
                CurState = State.Select;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            CurState = State.Table;
        }

        private void selectCostumeButton_Click(object sender, EventArgs e)
        {
            new CostumeForm(this).ShowDialog();
        }

        private void selectionCancelButton_Click(object sender, EventArgs e)
        {
            if (orderDR != null) Close();
            CurState = State.Table;
        }

        private void selectionOKButton_Click(object sender, EventArgs e)
        {
            if (callerForm != null && callerForm.GetType() == typeof(OrderForm))
            {
                if (vendorTB.Text == "")
                {
                    MessageBox.Show("Введите артикул костюма");
                    return;
                }
            }
            if (orderDR == null)
            {
                AddOrderCostume(curCS_id == -1 ? mainDGV.SelectedRows[0] : null);
                CurState = State.Table;
                return;
            }
            else
            {
                orderDR["vendor"] = vendorTB.Text;
                orderDR["returndate_shedule"] = returndateSheduleDTP.Value;
                orderDR["note"] = noteRTB.Text;
                Close();
            }
        }

        private void mainDGV_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (callerForm == null)
                CurState = State.Edit;
            else
            {
                CurState = State.Select;
                curCS_id = -1;
            }
        }
    }
}
