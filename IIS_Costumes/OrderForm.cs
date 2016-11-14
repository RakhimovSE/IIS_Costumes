using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace IIS_Costumes
{
    public partial class OrderForm : Form
    {
        enum State
        {
            Table,
            Issue,
            Edit
        }

        State curState;

        State CurState
        {
            get { return curState; }
            set
            {
                curState = value;
                searchTB.Enabled = mainDGV.Visible = issueButton.Enabled = takeButton.Enabled =
                    editButton.Enabled = deleteButton.Enabled = value == State.Table;
                orderGB.Visible = value != State.Table;
                costumeAddButton.Enabled = costumeRemoveButton.Enabled = value == State.Issue;
                orderGB.Text = value == State.Issue ? "Выдача костюмов" : "Редактирование записи о выдаче";
            }
        }

        ClientForm clientForm;
        CostumeForm costumeForm;
        #region Methods
        private void SetMainDGV(string search = "")
        {
            string query = string.Format("CALL order_search('{0}')", search);
            DBConnector.FillDGV(mainDGV, query);
            SetDgvBgColor();
        }

        private void SetDgvBgColor()
        {
            foreach (DataGridViewRow row in mainDGV.Rows)
            {
                DateTime dtShedule;
                dtShedule = (DateTime)DBConnector.GetRowCol(row, "returndate_shedule");
                object objActual = DBConnector.GetRowCol(row, "returndate_actual");
                if (objActual.GetType() == typeof(DBNull))
                {
                    if (dtShedule < DateTime.Now)
                        row.DefaultCellStyle.BackColor = Color.Red;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.LightGray;
                }
            }
        }

        private void CheckSelectedRows()
        {
            foreach (DataGridViewRow row in mainDGV.Rows)
                row.Cells["mainSelected"].Value = row.Selected;
        }

        private void SetGB(int id_order = -1)
        {
            if (id_order == -1)
            {
                dateDTP.Value = DateTime.Now;
                DBConnector.FillCB(clientCB, Properties.Resources.ClientQuery, "id_client", "name");
                sheduleDTP.Value = DateTime.Now.AddDays(7);
                returnedChB.Checked = true;
                returnedChB.Checked = false;
                actualDTP.Value = DateTime.Now;
                costumeDGV.Rows.Clear();
                return;
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
            clientForm = new ClientForm();
            costumeForm = new CostumeForm();

            mainDGV.AutoGenerateColumns = false;
            SetMainDGV();

            CurState = State.Table;
        }

        private void searchTB_TextChanged(object sender, EventArgs e)
        {
            SetMainDGV(searchTB.Text);
        }

        private void mainDGV_Sorted(object sender, EventArgs e)
        {
            SetDgvBgColor();
        }

        private void mainDgv_SelectionChanged(object sender, EventArgs e)
        {
            CheckSelectedRows();
        }
        #endregion
        #region Menu
        private void клиентыToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            clientForm = (ClientForm)Controller.ShowForm(clientForm);
        }

        private void костюмыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            costumeForm = (CostumeForm)Controller.ShowForm(costumeForm);
        }
        #endregion
        #region Tools
        private void issueButton_Click(object sender, EventArgs e)
        {
            CurState = State.Issue;
            SetGB();
        }

        private void takeButton_Click(object sender, EventArgs e)
        {
            
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
                    DBConnector.GetRowCol(rows[0], "costume_name"));
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
                      select DBConnector.GetRowCol(x, "id_order");
            string query = string.Format("DELETE FROM `order` WHERE `id_order` IN ({0})", string.Join(", ", ids));
            DBConnector.SetNoResultQuery(query);
            SetMainDGV(searchTB.Text);
        }
        #endregion
        #region OrderGroupBox
        private void clientButton_Click(object sender, EventArgs e)
        {

        }

        private void returnedChB_CheckedChanged(object sender, EventArgs e)
        {
            actualDTP.Enabled = returnedChB.Checked;
        }

        private void costumeAddButton_Click(object sender, EventArgs e)
        {

        }

        private void costumeRemoveButton_Click(object sender, EventArgs e)
        {

        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            // -----
            CurState = State.Table;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            // -----
            CurState = State.Table;
        }
        #endregion
    }
}
