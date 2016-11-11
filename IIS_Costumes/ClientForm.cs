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
    public partial class ClientForm : Form
    {
        public ClientForm()
        {
            InitializeComponent();
        }
        void hide()
        {
            OKButton.Enabled = true;
            cancelButton.Enabled = true;
            searchTB.Enabled = true;
            mainDgv.Enabled = true;
            mainGB.Enabled = false;
        }
        void show(string str)
        {
            OKButton.Enabled = false;
            cancelButton.Enabled = false;
            searchTB.Enabled = false;
            mainDgv.Enabled = true;
            mainGB.Enabled = false;
            if (str == "add")
                mainGB.Text = "Добавление клиента";
            else
                mainGB.Text = "Редактирование клиента ";
        }
        void resetGB()
        { 
            OKButton.ResetText();
            cancelButton.ResetText();
            searchTB.ResetText();
            mainDgv.ResetText();
            mainGB.ResetText();
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            show("add");
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            show("edit");
        }
        
        private void cancelButton_Click(object sender, EventArgs e)
        {
            resetGB();
            hide();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if (fioTB.Text.Trim(' ') == "" && phoneTB.Text.Trim(' ') == "")
            {
                MessageBox.Show("Заполните все обязательные поля!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string adress, numPass, datePass, departPass, fio = fioTB.Text.Replace("'", "\'"), phone = phoneTB.Text.Replace("'", "\'");
                adress = numPass = datePass = departPass = "NULL";
                if (adressTB.Text.Trim(' ') != "")
                    adress = "'" + adressTB.Text + "'";
                if (passDateDTP.Value != null)
                    datePass = "'" + passDateDTP.Value + "'";
                if (passNumTB.Text.Trim(' ') != "")
                    adress = "'" + passNumTB.Text + "'";
                if (passDepartRTB.Text.Trim(' ') != "")
                    adress = "'" + passDepartRTB.Text + "'";

                string query = String.Format(@"INSERT INTO `carnaval`.`client`
                                (`name`,
                                `telephone`,
                                `address`,
                                `id_passport`,
                                `passport_issue`,
                                `passport_depart`)
                                VALUES
                                (
                                '{0}',
                                '{1}',
                                 {2},
                                 {3},
                                 {4},
                                 {5});",fio,phone,adress,numPass,datePass,departPass);

            }
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            hide();
        }
    }
}
