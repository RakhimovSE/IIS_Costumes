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
        void show(string str)
        {
            passDateDTP.ResetText();
            mainGB.Visible = true;
            OKButton.Enabled = true;
            cancelButton.Enabled = true;
            searchTB.Enabled = false;
            mainDgv.Enabled = true;
            addButton.Enabled = false;
            editButton.Enabled = false;
            delButton.Enabled = false;
            if (str == "add")
                mainGB.Text = "Добавление клиента";
            else
                mainGB.Text = "Редактирование клиента ";
        }
        void hide()
        {
            addButton.Enabled = true;
            editButton.Enabled = true;
            delButton.Enabled = true;
            mainGB.Visible = false;
            OKButton.Enabled = false;
            cancelButton.Enabled = false;
            searchTB.Enabled = true;
            mainDgv.Enabled = true;
            
        }
        void resetGB()
        {
            fioTB.ResetText();
            phoneTB.ResetText();
            adressTB.ResetText();
            passDateDTP.ResetText();
            passDepartRTB.ResetText();
            passNumTB.ResetText();
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
                    datePass = "'" + DBConnector.DtToMysql(passDateDTP.Value,true,false) + "'";
                if (passNumTB.Text.Trim(' ') != "")
                    numPass = "'" + passNumTB.Text + "'";
                if (passDepartRTB.Text.Trim(' ') != "")
                    departPass = "'" + passDepartRTB.Text + "'";

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
                DBConnector.SetNoResultQuery(query);

            }
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            hide();
        }
    }
}
