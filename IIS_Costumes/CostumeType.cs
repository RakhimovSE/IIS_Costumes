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
    public partial class CostumeType : Form
    {
        public CostumeType()
        {
            InitializeComponent();
        }
        CostumeForm costume;
        public CostumeType(Form form = null)
        {
            InitializeComponent();
            if (form.GetType() == typeof(CostumeForm))
                costume = (CostumeForm)form;
        }
        void refreshData()
        {
            mainDGV.AutoGenerateColumns = false;
            DB.FillDGV(mainDGV, "SELECT * FROM `costume_type`");
        }
        void show(string str)
        {
            resetGB();
            mainDGV.Visible = false;
            mainGB.Visible = true;
            OKButton.Enabled = true;
            cancelButton.Enabled = true;
           
            mainDGV.Enabled = false;
            addButton.Enabled = false;
            editButton.Enabled = false;
            delButton.Enabled = false;
            if (str == "add")
                mainGB.Text = "Добавление типа костюма";
            else
                mainGB.Text = "Редактирование типа костюма ";
        }
        void resetGB()
        {
            nameTypeTB.ResetText();
         
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
           
            mainDGV.Enabled = true;

        }

        private void mainDGV_SelectionChanged(object sender, EventArgs e)
        {
            mainDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            show("add");
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if (nameTypeTB.Text.Trim(' ') == "")
                MessageBox.Show("Заполните все обязательные поля!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                string nameCostumeType = nameTypeTB.Text;
                string query = String.Format(@"INSERT INTO `carnaval`.`costume_type`
                                (`name`)
                                VALUES
                               ('{0}');", nameCostumeType);
                long inserted_id = DB.SetNoResultQuery(query);
                if (inserted_id > 0)
                {
                    hide();
                    refreshData();
                }
                else
                {
                    MessageBox.Show("При добавлении костюма произошла ошибка, \nобратитесь к системному администратору!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
        }

        private void CostumeType_Load(object sender, EventArgs e)
        {
            refreshData();
            hide();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            show("no add");
        }

        private void delButton_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection rows = mainDGV.SelectedRows;
            int n = rows.Count;
            string text;
            string caption;
            if (n == 1)
            {
                if (MessageBox.Show(String.Format("Вы уверены, что хотите удалить запись о типе костюма\n{0}?",
                                    mainDGV[0, mainDGV.CurrentRow.Index].Value.ToString()), "Внимание", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.OK)
                {
                    string query = String.Format(@"
                                        DELETE FROM `costume_type`
                                        WHERE id_costume_type={0};", DB.GetRowCol(mainDGV.Rows[mainDGV.SelectedCells[0].RowIndex], "id_costume_type"));
                    DB.SetNoResultQuery(query);
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
                              select DB.GetRowCol(x, "id_costume_type");
                    string query = string.Format("DELETE FROM `costume_type` WHERE `id_costume_type` IN ({0})", string.Join(", ", ids));
                    DB.SetNoResultQuery(query);
                    refreshData();
                }
            }
        }

        private void mainDGV_DoubleClick(object sender, EventArgs e)
        {
            if (costume != null)
            {
                int costume_id = (int)DB.GetRowCol(mainDGV.Rows[mainDGV.SelectedCells[0].RowIndex], "id_costume_type");
                costume.typeCB.SelectedValue = costume_id;
                this.Close();
            }
        }
    }
}
