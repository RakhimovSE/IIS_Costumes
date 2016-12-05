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
        public BillForm(List<int> order_ids)
        {
            InitializeComponent();
            this.order_ids = order_ids;
        }

        List<int> order_ids;
    }
}
