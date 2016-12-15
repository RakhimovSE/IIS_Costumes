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
        enum State
        {
            Table,
            Add,
            Edit
        }

        State curState;

        State CurState
        {
            get { return curState; }
            set
            {
                curState = value;
                if (value == State.Add || value == State.Edit) costumeDT = null;
                orderGB.Visible = value != State.Table;
                searchTB.Enabled = mainDGV.Visible = issueButton.Enabled = takeButton.Enabled =
                    editButton.Enabled = deleteButton.Enabled = value == State.Table;
                costumeAddButton.Enabled = costumeRemoveButton.Enabled = value == State.Add;
                orderGB.Text = value == State.Add ? "Выдача костюмов" : "Редактирование записи о выдаче";
                CancelButton = value == State.Edit || value == State.Add ? cancelButton : null;
            }
        }

        ClientForm clientForm;
        CostumeForm costumeForm;
        CostumeSizeForm costumeSizeForm;

        public DataTable costumeDT;
        int total;

        public int Total
        {
            get { return total; }
            set
            {
                total = value;
                totalLabel.Text = string.Format("Итого: {0} руб.", total);
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
        
        private void PerformEdit()
        {
            IEnumerable<DataGridViewRow> filter = from DataGridViewRow x in mainDGV.SelectedRows
                                                  select x;
            CurState = State.Edit;
            SetGB(filter.ToList());
        }

        private void SetGB(List<DataGridViewRow> rows = null)
        {
            SetCostumeDT();
            Total = 0;
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
                string size_name = DB.GetRowCol(row, "size_name").ToString();
                int price = Convert.ToInt32(DB.GetRowCol(row, "price"));
                int costume_daily_price = (int)DB.GetRowCol(row, "costume_daily_price");
                DateTime returndate_shedule = (DateTime)DB.GetRowCol(row, "returndate_shedule");
                string note = DB.GetRowCol(row, "note").ToString();
                int order_id = (int)DB.GetRowCol(row, "id_order");
                costumeDT.Rows.Add(costume_size_id, costume_name, vendor,
                    size_name, price, costume_daily_price, returndate_shedule, note, order_id);

                Total += price;
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
            costumeDT.Columns.Add("size_name", typeof(string));
            costumeDT.Columns.Add("price", typeof(int));
            costumeDT.Columns.Add("costume_daily_price", typeof(int));
            costumeDT.Columns.Add("returndate_shedule", typeof(DateTime));
            costumeDT.Columns.Add("note", typeof(string));
            costumeDT.Columns.Add("id_order", typeof(int));
        }
        #endregion
        #region Main
        public OrderForm()
        {
            InitializeComponent();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            clientForm = new ClientForm();
            costumeForm = new CostumeForm();
            costumeSizeForm = new CostumeSizeForm();

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
            foreach (DataGridViewRow row in mainDGV.Rows)
                row.Cells["mainSelected"].Value = row.Selected;
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
            PerformEdit();
        }
        #endregion
        #region Menu
        private void костюмыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            costumeForm = (CostumeForm)Controller.ShowForm(costumeForm);
        }

        private void журналЗаказовToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void счетаToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void клиентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clientForm = (ClientForm)Controller.ShowForm(clientForm);
        }

        private void размерыКостюмовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            costumeSizeForm = (CostumeSizeForm)Controller.ShowForm(costumeSizeForm);
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
            SetGB();
        }

        private void takeButton_Click(object sender, EventArgs e)
        {
            new TakeCostumeForm(mainDGV.SelectedRows).ShowDialog();
            SetMainDGV(searchTB.Text);
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            PerformEdit();
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
                var values = from DataRow x in costumeDT.Rows
                             select string.Format("('{0}', {1}, {2}, {3}, '{4}', '{5}', {6}, '{7}')",
                                date, client_id, Program.employee_id, x["costume_size_id"], x["vendor"],
                                DB.DateToMysql((DateTime)x["returndate_shedule"], true, false),
                                x["price"], x["note"]);
                query = string.Format("INSERT INTO `order` (`date`, `client_id`, `employee_id`, " +
                        "`costume_size_id`, `vendor`, `returndate_shedule`, `price`, `note`) VALUES {0}",
                        string.Join(", ", values));
                DB.SetNoResultQuery(query);
            }
            else
            {
                foreach (DataRow x in costumeDT.Rows)
                {
                    query = string.Format("UPDATE `order` SET `date` = '{0}', `client_id` = {1}, " +
                            "`employee_id` = {2}, `costume_size_id` = {3}, `vendor` = '{4}', " +
                            "`returndate_shedule` = '{5}', `price` = {6}, `note` = '{7}' WHERE `id_order` = {8}",
                            date, client_id, Program.employee_id, x["costume_size_id"], x["vendor"],
                            DB.DateToMysql((DateTime)x["returndate_shedule"], true, false),
                            x["price"], x["note"], x["id_order"]);
                    DB.SetNoResultQuery(query);
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
            new CostumeSizeForm(DB.DGVR2DR(costumeDGV.SelectedRows[0])).ShowDialog();
        }
    }
}
