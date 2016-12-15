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
    public partial class BillForm : Form
    {

        string searchClientName;

        private void SetMainDGV(string search = "")
        {
            string query = string.Format("CALL bill_search('{0}')", search);
            DB.FillDGV(mainDGV, query);
        }

        public BillForm(string searchClientName = "")
        {
            InitializeComponent();
            mainDGV.AutoGenerateColumns = false;
            this.searchClientName = searchClientName;
            SetMainDGV(searchClientName);
        }

        private void BillForm_Load(object sender, EventArgs e)
        {
            mainDGV.AutoGenerateColumns = false;
            searchTB.Text = searchClientName;
        }

        private void searchTB_TextChanged(object sender, EventArgs e)
        {
            SetMainDGV(searchTB.Text);
        }
    }
}
