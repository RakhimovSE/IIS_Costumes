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
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();
            entered = false;
        }

        bool entered;

        private void loginButton_Click(object sender, EventArgs e)
        {
            string login = loginTB.Text;
            string password = passwordTB.Text;
            string hash = Controller.GetSaltedMD5Hash(login, password);
            string query = string.Format
                ("SELECT * FROM `employee` WHERE `login` = '{0}' AND `password` = '{1}'", login, hash);
            DataSet ds = DBConnector.GetDBDataSet(query);
            if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("Неправильный логин/пароль");
                return;
            }
            entered = true;
            string name = ds.Tables[0].Rows[0]["name"].ToString();
            MessageBox.Show(string.Format("Здравствуйте, {0}!", name));
            Program.employee_id = (int)ds.Tables[0].Rows[0]["id_employee"];
            Program.employee_name = ds.Tables[0].Rows[0]["name"].ToString();
            Close();
        }

        private void AuthForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!entered) Application.Exit();
        }
    }
}
