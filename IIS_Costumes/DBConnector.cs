using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;

namespace IIS_Costumes
{
    public abstract class DBConnector
    {
        protected string connStr = Properties.Resources.ConnectionString;

        public static string DtToMysql(DateTime dt, bool date = true, bool time = true)
        {
            string format = string.Format("{0}{1}{2}", date ? "yyyy-MM-dd" : "",
                date && time ? " " : "", time ? "HH:mm:ss" : "");
            string result = dt.ToString(format);
            return result;
        }
        public static void SetNoResultQuery(string query)
        {
            try
            {
                string connStr = Properties.Resources.ConnectionString;
                MySqlConnection conn = new MySqlConnection(connStr);
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = query;
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static DataSet GetDBDataSet(string query = null)
        {
            DataSet result = null;
            try
            {
                string connStr = Properties.Resources.ConnectionString;
                MySqlConnection conn = new MySqlConnection(connStr);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = new MySqlCommand(query, conn);
                MySqlCommandBuilder cb = new MySqlCommandBuilder(da);
                conn.Open();
                result = new DataSet();
                da.Fill(result);
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return result;
        }
    }
}
