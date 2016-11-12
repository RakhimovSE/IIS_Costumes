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
        public OrderForm()
        {
            InitializeComponent();
        }

        ClientForm clientForm;
        CostumeForm costumeForm;

        private void OrderForm_Load(object sender, EventArgs e)
        {
            clientForm = new ClientForm();
            costumeForm = new CostumeForm();

            mainDGV.AutoGenerateColumns = false;
            DBConnector.FillDGV(mainDGV, Properties.Resources.VOrderQuery);
        }

        private void mainDgv_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow row = mainDGV.SelectedCells[0].OwningRow;
            searchTB.Text = (string)DBConnector.GetRowCol(row, "address");
        }

        private void клиентыToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            clientForm = (ClientForm)Controller.ShowForm(clientForm);
        }

        private void костюмыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            costumeForm = (CostumeForm)Controller.ShowForm(costumeForm);
        }
    }
}
