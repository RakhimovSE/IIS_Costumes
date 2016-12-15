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
    public partial class SizeForm : Form
    {
        public SizeForm()
        {
            InitializeComponent();
        }
        void refreshData()
        {
            mainDGV.AutoGenerateColumns = false;
            DB.FillDGV(mainDGV, "SELECT * FROM size`");
        }
        void show(string str)
        {
            //resetGB();
            mainDGV.Visible = false;
            mainGB.Visible = true;
            OKButton.Enabled = true;
            cancelButton.Enabled = true;

            mainDGV.Enabled = false;
            addButton.Enabled = false;
            editButton.Enabled = false;
            delButton.Enabled = false;
            if (str == "add")
                mainGB.Text = "Добавление размера";
            else
                mainGB.Text = "Редактирование размера";
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
        private void SizeForm_Load(object sender, EventArgs e)
        {
            refreshData();
            hide();
        }
        string state;
        private void addButton_Click(object sender, EventArgs e)
        {
            state = "add";
            show("add");
        }
        private void SetGB(DataGridViewRow row = null)
        {
            if (row == null) return;
            sizeTB.Text = DB.GetRowCol(row, "name").ToString();
            altSizeTB.Text = DB.GetRowCol(row, "numeric").ToString();

        }
        private void editButton_Click(object sender, EventArgs e)
        {
            SetGB(mainDGV.SelectedRows[0]);
            show("no add");
            state = "edit";
        }

        private void delButton_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection rows = mainDGV.SelectedRows;
            int n = rows.Count;
            if (n == 1)
            {
                if (MessageBox.Show(String.Format("Вы уверены, что хотите удалить запись о размере\n{0}?",
                                    mainDGV[0, mainDGV.CurrentRow.Index].Value.ToString()), "Внимание", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.OK)
                {
                    string query = String.Format(@"
                                        DELETE FROM `size`
                                        WHERE id_size={0};", DB.GetRowCol(mainDGV.Rows[mainDGV.SelectedCells[0].RowIndex], "id_size"));
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
                if (MessageBox.Show(String.Format("Вы уверены, что хотите удалить {0} {1} о размерах?",
                                                   n, GetWordForm()), "Внимание", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.OK)
                {
                    var ids = from DataGridViewRow x in rows
                              select DB.GetRowCol(x, "id_costume_type");
                    string query = string.Format("DELETE FROM `size` WHERE `id_size` IN ({0})", string.Join(", ", ids));
                    DB.SetNoResultQuery(query);
                    refreshData();
                }
            }

        }

        private void mainDGV_DoubleClick(object sender, EventArgs e)
        {
            SetGB(mainDGV.SelectedRows[0]);
            show("no add");
        }

        private void mainDGV_SelectionChanged(object sender, EventArgs e)
        {
            mainDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            hide();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if (sizeTB.Text.Trim(' ') == "" || altSizeTB.Text.Trim(' ') == "")
                MessageBox.Show("Заполните все обязательные поля!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                string query;
                string size = sizeTB.Text, altSize = altSizeTB.Text;
                if (state =="add")
                {
                    query = String.Format(@"INSERT INTO `carnaval`.`size`
                                (`name`,
                                 `numeric`)
                                VALUES
                               ('{0}',
                                '{1}');", size, altSize);
                }
                else
                {
                    query = String.Format(@"UPDATE `carnaval`.`size`
                                            SET
                                            `name` = '{0}',
                                            `numeric` = '{1}'
                                            WHERE `id_size` = {2};", size, altSize, DB.GetRowCol(mainDGV.SelectedRows[0], "id_size").ToString());
                }
                long inserted_id = DB.SetNoResultQuery(query);
                if (inserted_id > 0)
                {
                    hide();
                    refreshData();
                }
                else
                {
                    MessageBox.Show("При добавлении размера произошла ошибка, \nобратитесь к системному администратору!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
        }
    }
}
