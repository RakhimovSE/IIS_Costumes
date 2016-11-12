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
        public CostumeForm()
        {
            InitializeComponent();
        }

        private void CostumeForm_Load(object sender, EventArgs e)
        {
            mainDGV.AutoGenerateColumns = false;
            DBConnector.FillDGV(mainDGV, "SELECT * FROM `costume`");
        }
    }
}
