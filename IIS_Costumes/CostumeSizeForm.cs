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
            SingleTable,
            SingleAdd,
            SingleEdit,
            SingleParams,
            MultiTable,
            MultiAdd,
            MultiEdit,
            MultiParams
        };

        State curState;

        public State CurState
        {
            get { return curState; }
            set
            {
                curState = value;

            }
        }

        public CostumeSizeForm()
        {
            InitializeComponent();
        }

        private void SetMainDGV(string search = "")
        {
            string query = string.Format("CALL costume_size_search('{0}')", search);
            DBConnector.FillDGV(mainDGV, query);
        }

        private void CostumeSizeForm_Load(object sender, EventArgs e)
        {
            mainDGV.AutoGenerateColumns = false;

            SetMainDGV();
        }

        private void searchTB_TextChanged(object sender, EventArgs e)
        {
            SetMainDGV(searchTB.Text);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            switch (CurState)
            {
                case State.Table:
                    CurState = State.Add;
                    break;
                case State.SingleTable:
                    CurState = State.SingleAdd;
                    break;
                case State.MultiTable:
                    CurState = State.MultiAdd;
                    break;
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {

        }

        private void delButton_Click(object sender, EventArgs e)
        {

        }
    }
}
