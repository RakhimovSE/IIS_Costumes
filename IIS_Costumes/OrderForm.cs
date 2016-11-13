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

        }
        #endregion
        #region OrderGroupBox
        private void clientButton_Click(object sender, EventArgs e)
        {

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
