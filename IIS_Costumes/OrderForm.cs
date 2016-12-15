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
    public partial class OrderForm : Form
    {
        public enum State
        {
            Table,
            Add,
            Edit
        }

        State curState;

        public State CurState
        {
            get { return curState; }
            set
            {
                curState = value;
                if (value == State.Add || value == State.Edit)
                {
                    costumeDT = null;
                    TotalDeposit = 0;
                    TotalRent = 0;
                }
                if (value == State.Add) SetGB();
                if (value == State.Edit)
                {
                    var filter = from DataGridViewRow x in mainDGV.SelectedRows
                                 select x;
                    SetGB(filter.ToList());
                }
                orderGB.Visible = value != State.Table;
                searchTB.Enabled = mainDGV.Visible = issueButton.Enabled = takeButton.Enabled =
                    editButton.Enabled = deleteButton.Enabled = value == State.Table;
                costumeAddButton.Enabled = costumeRemoveButton.Enabled = value == State.Add;
                orderGB.Text = value == State.Add ? "Выдача костюмов" : "Редактирование записи о выдаче";
                // CancelButton = value == State.Edit || value == State.Add ? cancelButton : null;
            }
        }

        ClientForm clientForm;
        CostumeForm costumeForm;
        CostumeSizeForm costumeSizeForm;

        public DataTable costumeDT;
        int totalDeposit;
        int totalRent;

        public int TotalDeposit
        {
            get { return totalDeposit; }
            set
            {
                totalDeposit = value;
                totalDepositLabel.Text = string.Format("Итого депозит: {0} руб.", value);
            }
        }

        public int TotalRent
        {
            get { return totalRent; }
            set
            {
                totalRent = value;
                totalRentLabel.Text = string.Format("Итого аренда: {0} руб.", value);
            }
        }

        #region Methods
        private void SetMainDGV(string search = "")
        {
            string query = string.Format("CALL order_search('{0}')", search);
            DB.FillDGV(mainDGV, query);
            SetDGVStyle();
        }

        private void SetDGVStyle()
        {
            for (int i = 0; i < mainDGV.Rows.Count; i++)
            {
                mainDGV.Rows[i].HeaderCell.Value = (i + 1).ToString();
                DateTime dtShedule;
                dtShedule = (DateTime)DB.GetRowCol(mainDGV.Rows[i], "returndate_shedule");
                object objActual = DB.GetRowCol(mainDGV.Rows[i], "returndate_actual");
                if (objActual.GetType() == typeof(DBNull))
                {
                    if (dtShedule < DateTime.Now)
                        mainDGV.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                }
                else
                    mainDGV.Rows[i].DefaultCellStyle.BackColor = Color.LightGray;
            }
        }

        public int GetRentPrice(DateTime issueDate, DateTime returnDate, int dailyPrice)
        {
            return Math.Max(((returnDate - issueDate).Days + 1) * dailyPrice, 0);
        }

        private void SetGB(List<DataGridViewRow> rows = null)
        {
            SetCostumeDT();
            if (rows == null || rows.Count == 0)
            {
                dateDTP.Value = DateTime.Now;
                costumeDGV.DataSource = costumeDT;
                return;
            }
            foreach (DataGridViewRow row in rows)
            {
                int costume_size_id = (int)DB.GetRowCol(row, "costume_size_id");
                string costume_name = DB.GetRowCol(row, "costume_name").ToString();
                string vendor = DB.GetRowCol(row, "vendor").ToString();
                string size_name_num = DB.GetRowCol(row, "size_name_num").ToString();
                DateTime returndate_shedule = (DateTime)DB.GetRowCol(row, "returndate_shedule");
                int costume_price = Convert.ToInt32(DB.GetRowCol(row, "costume_price"));
                int costume_daily_price = (int)DB.GetRowCol(row, "costume_daily_price");
                int rent_price = GetRentPrice(dateDTP.Value, returndate_shedule, costume_daily_price);
                int order_id = (int)DB.GetRowCol(row, "id_order");
                costumeDT.Rows.Add(costume_size_id, costume_name, vendor, size_name_num, costume_price,
                    costume_daily_price, rent_price, returndate_shedule, order_id);
            }
            costumeDGV.DataSource = costumeDT;
            clientCB.SelectedValue = DB.GetRowCol(rows[0], "client_id");
            dateDTP.Value = (DateTime)DB.GetRowCol(rows[0], "date");
        }

        private void SetCostumeDT()
        {
            costumeDT = new DataTable();
            costumeDT.Columns.Add("costume_size_id", typeof(int));
            costumeDT.Columns.Add("costume_name", typeof(string));
            costumeDT.Columns.Add("vendor", typeof(string));
            costumeDT.Columns.Add("size_name_num", typeof(string));
            costumeDT.Columns.Add("costume_price", typeof(int));
            costumeDT.Columns.Add("costume_daily_price", typeof(int));
            costumeDT.Columns.Add("rent_price", typeof(int));
            costumeDT.Columns.Add("returndate_shedule", typeof(DateTime));
            costumeDT.Columns.Add("id_order", typeof(int));
        }

        private void RecalculateTotal()
        {
            TotalDeposit = 0;
            TotalRent = 0;
            foreach (DataRow x in costumeDT.Rows)
            {
                if (x.RowState == DataRowState.Detached) continue;
                TotalDeposit += (int)x["costume_price"];
                int rent_price = GetRentPrice(dateDTP.Value, (DateTime)x["returndate_shedule"],
                    (int)x["costume_daily_price"]);
                x["rent_price"] = rent_price;
                TotalRent += rent_price;
            }
        }
        #endregion
        #region Main
        public OrderForm()
        {
            InitializeComponent();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            mainDGV.AutoGenerateColumns = false;
            SetMainDGV();
            CurState = State.Table;

            costumeDGV.AutoGenerateColumns = false;
            employeeTB.Text = Program.employee_name;
            DB.FillCB(clientCB, Properties.Resources.ClientQuery, "id_client", "name");
        }

        private void searchTB_TextChanged(object sender, EventArgs e)
        {
            SetMainDGV(searchTB.Text);
        }

        private void mainDGV_Sorted(object sender, EventArgs e)
        {
            SetDGVStyle();
        }

        private void mainDgv_SelectionChanged(object sender, EventArgs e)
        {
            if (mainDGV.SelectedRows.Count == 0) return;
            int client_id = (int)DB.GetRowCol(mainDGV.SelectedRows[0], "client_id");
            bool oneClient = true;
            foreach (DataGridViewRow row in mainDGV.SelectedRows)
            {
                if (client_id != (int)DB.GetRowCol(row, "client_id"))
                {
                    oneClient = false;
                    break;
                }
            }
            takeButton.Enabled = editButton.Enabled = oneClient;
        }

        private void mainDGV_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            CurState = State.Edit;
        }
        #endregion
        #region Menu
        private void костюмыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            costumeForm = new CostumeForm();
            costumeForm.Show();
        }

        private void журналЗаказовToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void счетаToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void клиентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clientForm = new ClientForm();
            clientForm.Show();
        }

        private void размерыКостюмовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            costumeSizeForm = new CostumeSizeForm(this);
            costumeSizeForm.Show();
        }

        private void типыКостюмовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CostumeType ct = new CostumeType();
            ct.Show();
        }

        private void размерыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SizeForm sf = new SizeForm();
            sf.Show();
        }
        #endregion
        #region Tools
        private void issueButton_Click(object sender, EventArgs e)
        {
            CurState = State.Add;
        }

        private void takeButton_Click(object sender, EventArgs e)
        {
            new TakeCostumeForm(mainDGV.SelectedRows).ShowDialog();
            SetMainDGV(searchTB.Text);
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            CurState = State.Edit;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection rows = mainDGV.SelectedRows;
            int n = rows.Count;
            string text;
            string caption;
            if (n == 1)
            {
                text = string.Format("Вы уверены, что хотите удалить запись о выдаче костюма\n{0}?",
                    DB.GetRowCol(rows[0], "costume_name"));
                caption = "Удаление записи о выдаче костюма";
            }
            else
            {
                Func<string> GetWordForm = () =>
                {
                    if (n % 100 >= 11 && n % 100 <= 19) return "записей";
                    if (n % 10 == 1) return "запись";
                    if (n % 10 >= 2 && n % 10 <= 4) return "записи";
                    return "записей";
                };

                text = string.Format("Вы уверены, что хотите удалить {0} {1} о выдаче костюмов?",
                    n, GetWordForm());
                caption = "Удаление записей о выдаче костюма";
            }
            DialogResult answer = MessageBox.Show(text, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (answer == DialogResult.No) return;

            var ids = from DataGridViewRow x in rows
                      select DB.GetRowCol(x, "id_order");
            string query = string.Format("DELETE FROM `order` WHERE `id_order` IN ({0})", string.Join(", ", ids));
            DB.SetNoResultQuery(query);
            SetMainDGV(searchTB.Text);
        }
        #endregion
        #region OrderGroupBox
        private void clientButton_Click(object sender, EventArgs e)
        {
            ClientForm client = new ClientForm(this);
            client.Show();
        }

        private void costumeAddButton_Click(object sender, EventArgs e)
        {
            new CostumeSizeForm(this).ShowDialog();
        }

        private void costumeRemoveButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in costumeDGV.SelectedRows)
            {
                costumeDT.Rows.Remove(DB.DGVR2DR(row));
            }
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if (costumeDT.Rows.Count == 0)
            {
                MessageBox.Show("Выберите костюмы для выдачи");
                return;
            }
            string date = DB.DateToMysql(dateDTP.Value, true, false);
            int client_id = (int)clientCB.SelectedValue;
            string query = "";
            if (CurState == State.Add)
            {
                foreach (DataRow x in costumeDT.Rows)
                {
                    query = string.Format("INSERT INTO `order` (`date`, `client_id`, `costume_size_id`, " +
                        "`vendor`, `costume_price`, `costume_daily_price`, `returndate_shedule`) " + 
                        "VALUES ('{0}', {1}, {2}, '{3}', {4}, {5}, '{6}')",
                        date, client_id, x["costume_size_id"], x["vendor"],
                        x["costume_price"], x["costume_daily_price"],
                        DB.DateToMysql((DateTime)x["returndate_shedule"], true, false));
                    int order_id = DB.SetNoResultQuery(query);
                    string bill_query = string.Format("INSERT INTO `bill` (`date`, `bill_type_id`, `order_id`, " +
                        "`employee_id`, `price`, `paid`) VALUES ('{0}', 1, {1}, {2}, {3}, 1)",
                        date, order_id, Program.employee_id, x["costume_price"]);
                    DB.SetNoResultQuery(bill_query);
                }
            }
            else
            {
                foreach (DataRow x in costumeDT.Rows)
                {
                    query = string.Format("UPDATE `order` SET `date` = '{0}', `client_id` = {1}, " +
                            "`costume_size_id` = {2}, `vendor` = '{3}', `returndate_shedule` = '{4}', " +
                            "`costume_price` = {5}, `costume_daily_price` = {6} WHERE `id_order` = {7}",
                            date, client_id, x["costume_size_id"], x["vendor"],
                            DB.DateToMysql((DateTime)x["returndate_shedule"], true, false),
                            x["costume_price"], x["costume_daily_price"], x["id_order"]);
                    DB.SetNoResultQuery(query);
                    string bill_query = string.Format("UPDATE `bill` SET `date` = '{0}', `price` = {1} WHERE " +
                        "`order_id` = {2} AND `bill_type_id` = 1", date, x["rent_price"], x["id_order"]);
                    DB.SetNoResultQuery(bill_query);
                }
            }
            // -----
            SetMainDGV(searchTB.Text);
            CurState = State.Table;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            CurState = State.Table;
        }
        #endregion

        private void costumeDGV_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void dateDTP_ValueChanged(object sender, EventArgs e)
        {
            RecalculateTotal();
        }

        private void costumeDGV_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            costumeDGV.CancelEdit();
        }

        private void costumeDGV_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            RecalculateTotal();
        }

        private void costumeDGV_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            RecalculateTotal();
        }
    }
}
