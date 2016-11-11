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
        public OrderForm()
        {
            InitializeComponent();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            mainDgv.AutoGenerateColumns = false;
            DBConnector.FillDGV(mainDgv, "SELECT * FROM `client`");
        }

        private void mainDgv_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow row = mainDgv.SelectedCells[0].OwningRow;
            MessageBox.Show(DBConnector.GetRowCol(row, "id_client").ToString());
        }

        private void клиентыToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ClientForm client = new ClientForm();
            client.Show();
        }
    }
}
