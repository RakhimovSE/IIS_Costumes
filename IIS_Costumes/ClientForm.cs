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
        string stat;
        public ClientForm(Form form = null)
        {
            InitializeComponent();
            if (form.GetType() == typeof(OrderForm))
                orderForm = (OrderForm)form;
        }

        OrderForm orderForm;

        void show(string str)
        {
            mainDGV.Visible = false;
            passDateDTP.ResetText();
            mainGB.Visible = true;
            OKButton.Enabled = true;
            cancelButton.Enabled = true;
            searchTB.Enabled = false;
            mainDGV.Enabled = false;
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
            mainDGV.Visible = true;
            addButton.Enabled = true;
            editButton.Enabled = true;
            delButton.Enabled = true;
            mainGB.Visible = false;
            OKButton.Enabled = false;
            cancelButton.Enabled = false;
            searchTB.Enabled = true;
            mainDGV.Enabled = true;

        }
        private void SetMainDGV(string search = "")
        {
            string query = string.Format("CALL client_search('{0}')", search);
            DBConnector.FillDGV(mainDGV, query);
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
        void focusOnRowDGV()
        {
            mainDGV.Rows[mainDGV.RowCount - 1].Selected = true;
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            show("add");
        }
        void refreshData()
        {
            mainDGV.AutoGenerateColumns = false;
            DBConnector.FillDGV(mainDGV, Properties.Resources.ClientQuery);
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
                    datePass = "'" + DBConnector.DtToMysql(passDateDTP.Value, true, false) + "'";
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
                                 {5});", fio, phone, adress, numPass, datePass, departPass);
                bool res = DBConnector.SetNoResultQuery(query);
                if (res == true)
                {
                    hide();
                    //  mainDGV.Rows.Add(fio, phone);
                    //focusOnRowDGV();
                    refreshData();
                }
                else
                {
                    MessageBox.Show("При добавлении клиента произошла ошибка, \nобратитесь к системному администратору!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            refreshData();
            hide();
        }

        private void mainDGV_SelectionChanged(object sender, EventArgs e)
        {
            mainDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void mainDGV_DoubleClick(object sender, EventArgs e)
        {
            if (orderForm != null)
            {
                int client_id = (int)DBConnector.GetRowCol(mainDGV.Rows[mainDGV.SelectedCells[0].RowIndex], "id_client");
                orderForm.clientCB.SelectedValue = client_id;
                this.Close();
            }
        }

        private void delButton_Click(object sender, EventArgs e) //удаление 
        {
            DataGridViewSelectedRowCollection rows = mainDGV.SelectedRows;
            int n = rows.Count;
            string text;
            string caption;
            if (n == 1)
            {
                if (MessageBox.Show(String.Format("Вы уверены, что хотите удалить запись о клиенте\n{0}?",
                                    mainDGV[0, mainDGV.CurrentRow.Index].Value.ToString()), "Внимание", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.OK)
                {
                    string query = String.Format(@"
                                        DELETE FROM `carnaval`.`client`
                                        WHERE id_client={0};", DBConnector.GetRowCol(mainDGV.Rows[mainDGV.SelectedCells[0].RowIndex], "id_client"));
                    DBConnector.SetNoResultQuery(query);
                }
                refreshData();
            }
            else
            {
                Func<string> GetWordForm = () =>
                {
                    if (n % 100 >= 11 && n % 100 <= 19) return "записей";
                    if (n % 10 == 1) return "запись";
                    if (n % 10 >= 2 && n % 10 <= 4) return "записи";
                    return "записей";
                };
                if (MessageBox.Show(String.Format("Вы уверены, что хотите удалить {0} {1} о клиентах?",
                                                   n, GetWordForm()), "Внимание", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.OK)
                {
                    var ids = from DataGridViewRow x in rows
                              select DBConnector.GetRowCol(x, "id_client");
                    string query = string.Format("DELETE FROM `client` WHERE `id_client` IN ({0})", string.Join(", ", ids));
                    DBConnector.SetNoResultQuery(query);
                    refreshData();
                }
            }
        }

        private void searchTB_TextChanged(object sender, EventArgs e)
        {
            SetMainDGV(searchTB.Text);
        }
    }
}
