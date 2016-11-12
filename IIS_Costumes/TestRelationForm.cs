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
    /*
        MySqlDataAdapter clientAdapter = new MySqlDataAdapter("SELECT * FROM `client`", Program.conn);
        MySqlDataAdapter orderAdapter = new MySqlDataAdapter("SELECT * FROM `order`", Program.conn);

        DataSet ds = new DataSet();
        clientAdapter.Fill(ds, "Client");
        orderAdapter.Fill(ds, "Order");

        DataRelation relation = new DataRelation("ClientOrder", ds.Tables["Client"].Columns["id_client"],
            ds.Tables["Order"].Columns["client_id"]);
        ds.Relations.Add(relation);

        foreach (DataRow pRow in ds.Tables["Client"].Rows)
        {
            listBox1.Items.Add(pRow["name"]);
            foreach (DataRow cRow in pRow.GetChildRows(relation))
            {
                listBox1.Items.Add("\t" + cRow["id_order"]);
            }
        }

        mainDGV.DataSource = ds;
        mainDGV.DataMember = "Order";
    */
    public partial class TestRelationForm : Form
    {
        private DataGridView masterDataGridView = new DataGridView();
        private BindingSource masterBindingSource = new BindingSource();
        private DataGridView detailsDataGridView = new DataGridView();
        private BindingSource detailsBindingSource = new BindingSource();
        
        public TestRelationForm()
        {
            masterDataGridView.Dock = DockStyle.Fill;
            detailsDataGridView.Dock = DockStyle.Fill;

            SplitContainer splitContainer1 = new SplitContainer();
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Orientation = Orientation.Horizontal;
            splitContainer1.Panel1.Controls.Add(masterDataGridView);
            splitContainer1.Panel2.Controls.Add(detailsDataGridView);

            this.Controls.Add(splitContainer1);
            this.Load += new System.EventHandler(Form1_Load);
            this.Text = "DataGridView master/detail demo";
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            // Bind the DataGridView controls to the BindingSource
            // components and load the data from the database.
            masterDataGridView.DataSource = masterBindingSource;
            detailsDataGridView.DataSource = detailsBindingSource;
            GetData();

            // Resize the master DataGridView columns to fit the newly loaded data.
            masterDataGridView.AutoResizeColumns();

            // Configure the details DataGridView so that its columns automatically
            // adjust their widths when the data changes.
            detailsDataGridView.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void GetData()
        {
            try
            {
                // Specify a connection string. Replace the given value with a 
                // valid connection string for a Northwind MySql Server sample
                // database accessible to your system.
                String connectionString = "server=127.0.0.1;port=3306;user id=root;password=;database=carnaval;characterset=utf8";
                MySqlConnection connection = new MySqlConnection(connectionString);

                // Create a DataSet.
                DataSet data = new DataSet();
                data.Locale = System.Globalization.CultureInfo.InvariantCulture;

                // Add data from the Customers table to the DataSet.
                MySqlDataAdapter masterDataAdapter = new
                    MySqlDataAdapter("select * from `client`", connection);
                masterDataAdapter.Fill(data, "Client");

                // Add data from the Orders table to the DataSet.
                MySqlDataAdapter detailsDataAdapter = new
                    MySqlDataAdapter("select * from `order`", connection);
                detailsDataAdapter.Fill(data, "Order");

                // Establish a relationship between the two tables.
                DataRelation relation = new DataRelation("ClientOrder",
                    data.Tables["Client"].Columns["id_client"],
                    data.Tables["Order"].Columns["client_id"]);
                data.Relations.Add(relation);

                // Bind the master data connector to the Customers table.
                masterBindingSource.DataSource = data;
                masterBindingSource.DataMember = "Client";

                // Bind the details data connector to the master data connector,
                // using the DataRelation name to filter the information in the 
                // details table based on the current row in the master table. 
                detailsBindingSource.DataSource = masterBindingSource;
                detailsBindingSource.DataMember = "ClientOrder";
            }
            catch (MySqlException)
            {
                MessageBox.Show("To run this example, replace the value of the " +
                    "connectionString variable with a connection string that is " +
                    "valid for your system.");
            }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // TestRelationForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Name = "TestRelationForm";
            this.ResumeLayout(false);

        }
    }
}
