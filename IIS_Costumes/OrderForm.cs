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
            DataSet ds = DBConnector.GetDBDataSet("SELECT * FROM `carnaval`.`client`");
            mainDgv.DataSource = ds.Tables[0];
        }

        private void клиентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientForm client = new ClientForm();
            client.Show();
        }
    }
}
