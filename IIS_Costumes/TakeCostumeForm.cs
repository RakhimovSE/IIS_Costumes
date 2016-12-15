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
            returndateDTP.Value = new DateTime
                (returndateDTP.Value.Year, returndateDTP.Value.Month, returndateDTP.Value.Day);
            int dept;
            if (!Int32.TryParse(deptTB.Text, out dept))
            {
                MessageBox.Show("Поля заполнены некорректно");
                return;
            }
            string dt = DB.DateToMysql(returndateDTP.Value, true, false);
            var return_filter = from DataGridViewRow x in rows
                                select (int)DB.GetRowCol(x, "id_order");
            string return_query = string.Format("UPDATE `order` SET `returndate_actual` = '{0}' " +
                "WHERE `id_order` IN ({1})", dt, string.Join(", ", return_filter));
            DB.SetNoResultQuery(return_query);
            // ИСПРАВИТЬ ВЫЧИСЛЕНИЕ СЧЕТА НА ВОЗВРАТ ДЕПОЗИТА
            var bill_return_filter =
                from DataGridViewRow x in rows
                select string.Format("('{0}', 2, {1}, {2}, {3}, 0)",
                    dt, DB.GetRowCol(x, "id_order"), Program.employee_id,
                    DB.GetRowCol(x, "costume_price"));
            string bill_return_query = string.Format("INSERT INTO `bill` (`date`, `bill_type_id`, `order_id`, " +
                "`employee_id`, `price`, `paid`) VALUES {0}", string.Join(", ", bill_return_filter));
            DB.SetNoResultQuery(bill_return_query);
            var bill_filter = 
                from DataGridViewRow x in rows
                where returndateDTP.Value > (DateTime)DB.GetRowCol(x, "returndate_shedule")
                select string.Format("('{0}', 3, {1}, {2}, {3}, 0)",
                    dt, DB.GetRowCol(x, "id_order"), Program.employee_id,
                    Controller.GetRentPrice((DateTime)DB.GetRowCol(x, "returndate_shedule"), returndateDTP.Value, dept));
            if (bill_filter.Count() > 0)
            {
                string bill_query = string.Format("INSERT INTO `bill` (`date`, `bill_type_id`, `order_id`, " +
                "`employee_id`, `price`, `paid`) VALUES {0}", string.Join(", ", bill_filter));
                DB.SetNoResultQuery(bill_query);
            }
            new BillForm(DB.GetRowCol(rows[0], "client_name").ToString()).Show();
            Close();
        }
    }
}
