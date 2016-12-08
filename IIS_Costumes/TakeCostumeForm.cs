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
    public partial class TakeCostumeForm : Form
    {
        public TakeCostumeForm(DataGridViewSelectedRowCollection rows)
        {
            InitializeComponent();
            this.rows = rows;
        }

        DataGridViewSelectedRowCollection rows;

        private void TakeCostumeForm_Load(object sender, EventArgs e)
        {

        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            string dt = DB.DateToMysql(returndateDTP.Value, true, false);
            var return_filter = from DataGridViewRow x in rows
                            select (int)DB.GetRowCol(x, "id_order");
            string return_query = string.Format("UPDATE `order` SET `returndate_actual` = '{0}' "+
                "WHERE `id_order` IN ({1})", dt, string.Join(", ", return_filter));
            DB.SetNoResultQuery(return_query);
            var bill_filter = from DataGridViewRow x in rows
                              where returndateDTP.Value > (DateTime)DB.GetRowCol(x, "returndate_shedule")
                              select (int)DB.GetRowCol(x, "id_order");
            if (bill_filter.Count() > 0)
            {
                string bill_query = string.Format("UPDATE `order` SET `bill_id` = `id_order` WHERE `id_order` IN ({0})",
                    string.Join(", ", bill_filter));
                DB.SetNoResultQuery(bill_query);
                new BillForm(bill_filter.ToList()).ShowDialog();
            }
            Close();
        }
    }
}
