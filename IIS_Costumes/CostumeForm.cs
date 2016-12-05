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
    public partial class CostumeForm: Form
    {

        private void SetMainDGV(string search = "")
        {
            string query = string.Format("CALL costume_search('{0}')", search);
            DBConnector.FillDGV(mainDGV, query);
        }

        public CostumeForm()
        {
            InitializeComponent();
        }

        private void CostumeForm_Load(object sender, EventArgs e)
        {
            mainDGV.AutoGenerateColumns = false;
            SetMainDGV("");
        }

        private void addButton_Click(object sender, EventArgs e)
        {

        }

        private void delButton_Click(object sender, EventArgs e)
        {

        }

        private void searchTB_TextChanged(object sender, EventArgs e)
        {
            SetMainDGV(searchTB.Text);
        }
    }
}
