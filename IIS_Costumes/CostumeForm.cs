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
        private void SetMainDGV(string search = "")
        {
            string query = string.Format("CALL costume_search('{0}')", search);
            DB.FillDGV(mainDGV, query);
        }
        void refreshData()
        {
            mainDGV.AutoGenerateColumns = false;
            DB.FillDGV(mainDGV, Properties.Resources.CostumeQuery);
        }
        void show(string str)
        {
            resetGB();
            mainDGV.Visible = false;
            DB.FillCB(typeCB, "SELECT * FROM `costume_type`", "id_costume_type", "name");
            mainGB.Visible = true;
            OKButton.Enabled = true;
            cancelButton.Enabled = true;
            searchTB.Enabled = false;
            mainDGV.Enabled = false;
            addButton.Enabled = false;
            editButton.Enabled = false;
            deleteButton.Enabled = false;
            if (str == "add")
                mainGB.Text = "Добавление клиента";
            else
                mainGB.Text = "Редактирование клиента ";
        }
        void resetGB()
        {
            nameTB.ResetText();
            priceTB.ResetText();
            daily_priceTB.ResetText();
            typeCB.ResetText();
        }
        void hide()
        {
            mainDGV.Visible = true;
            addButton.Enabled = true;
            editButton.Enabled = true;
            deleteButton.Enabled = true;
            mainGB.Visible = false;
            OKButton.Enabled = false;
            cancelButton.Enabled = false;
            searchTB.Enabled = true;
            mainDGV.Enabled = true;

        }
        public CostumeForm(Form callerForm = null)
        {
            InitializeComponent();
            this.callerForm = callerForm;
        }

        Form callerForm;
        private void SetGB(DataGridViewRow row = null)
        {
            if (row == null) return;
            nameTB.Text = DB.GetRowCol(row, "name").ToString();
            priceTB.Text = DB.GetRowCol(row, "price").ToString();
            daily_priceTB.Text = DB.GetRowCol(row, "daily_price").ToString();
            DB.FillCB(typeCB, "SELECT * FROM carnaval.costume_type;", "id_costume_type", "name");
            typeCB.SelectedIndex = Convert.ToInt32(DB.GetRowCol(row, "costume_type_id"))-1;
        }
        private void CostumeForm_Load(object sender, EventArgs e)
        {
            refreshData();
            if (callerForm != null && callerForm.GetType() == typeof(CostumeSizeForm))
                show("add");
            else
                hide();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            show("add");
            state = "add";
        }

        private void deleteButton_Click(object sender, EventArgs e) //не доделал
        {
            DataGridViewSelectedRowCollection rows = mainDGV.SelectedRows;
            int n = rows.Count;
            string text;
            string caption;
            if (n == 1)
            {
                if (MessageBox.Show(String.Format("Вы уверены, что хотите удалить запись о костюме\n{0}?",
                                    mainDGV[0, mainDGV.CurrentRow.Index].Value.ToString()), "Внимание", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.OK)
                {
                    string query = String.Format(@"
                                        DELETE FROM `carnaval`.`costume`
                                        WHERE id_costume={0};", DB.GetRowCol(mainDGV.Rows[mainDGV.SelectedCells[0].RowIndex], "id_costume"));
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
                              select DB.GetRowCol(x, "id_costume");
                    string query = string.Format("DELETE FROM `costume` WHERE `id_costume` IN ({0})", string.Join(", ", ids));
                    DB.SetNoResultQuery(query);
                    refreshData();
                }
            }
        }

        private void searchTB_TextChanged(object sender, EventArgs e)
        {
            SetMainDGV(searchTB.Text);
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            SetGB(mainDGV.SelectedRows[0]);
            show("no add");
            state = "edit";
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            hide();
        }
        string state;
        private void OKButton_Click(object sender, EventArgs e)
        {
            if (nameTB.Text.Trim(' ') == "" || priceTB.Text.Trim(' ') == "" || typeCB.SelectedText.ToString()==null || daily_priceTB.Text.Trim(' ') == "")
            {
                MessageBox.Show("Заполните все обязательные поля!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string priceCostume=priceTB.Text, daily_priceCostume=daily_priceTB.Text, typeCostume= typeCB.SelectedValue.ToString(), nameCostume = nameTB.Text.Replace("'", "\'");

                string query;
                if (state == "add")
                {
                    query = String.Format(@"INSERT INTO `carnaval`.`costume`
                                (`name`,
                                `costume_type_id`,
                                `price`,
                                `daily_price`)
                                VALUES
                               ('{0}',
                                 {1},
                                 {2},
                                 {3});", nameCostume, typeCostume, priceCostume, daily_priceCostume);
                }
                else
                {
                    query = String.Format(@"UPDATE `carnaval`.`costume`
                                            SET
                                            `name` = '{0}',
                                            `costume_type_id` = '{1}',
                                            `price` = '{2}',
                                            `daily_price` = '{3}'
                                            WHERE `id_costume` = '{4}';
                                            ", nameCostume, typeCostume, priceCostume, daily_priceCostume, DB.GetRowCol(mainDGV.SelectedRows[0], "id_costume").ToString());
                }
                long inserted_id = DB.SetNoResultQuery(query);
                if (inserted_id > 0)
                {
                    hide();
                    //  mainDGV.Rows.Add(fio, phone);
                    //focusOnRowDGV();
                    refreshData();
                    if (callerForm != null && callerForm.GetType() == typeof(CostumeSizeForm))
                    {
                        CostumeSizeForm CSForm = (CostumeSizeForm)callerForm;
                        DB.FillCB(CSForm.costumeCB, Properties.Resources.CostumeQuery, "id_costume", "name");
                        CSForm.costumeCB.SelectedValue = inserted_id;
                        Close();
                    }
                }
                else
                {
                    MessageBox.Show("При добавлении костюма произошла ошибка, \nобратитесь к системному администратору!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
        }

        private void mainDGV_SelectionChanged(object sender, EventArgs e)
        {
            mainDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void typeButton_Click(object sender, EventArgs e)
        {
            CostumeType ct = new CostumeType(this);
            ct.Show();
        }

        private void mainDGV_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (callerForm == null)
            {
                show("no add");
                SetGB(mainDGV.SelectedRows[0]);
                return;
            }
            int costume_id = (int)DB.GetRowCol(mainDGV.SelectedRows[0], "id_costume");

           
        }
    }
}
