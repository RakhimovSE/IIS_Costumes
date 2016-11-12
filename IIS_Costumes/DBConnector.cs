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
        protected static string connStr = Properties.Resources.ConnectionString;

        public static string DtToMysql(DateTime dt, bool date = true, bool time = true)
        {
            string format = string.Format("{0}{1}{2}", date ? "yyyy-MM-dd" : "",
                date && time ? " " : "", time ? "HH:mm:ss" : "");
            string result = dt.ToString(format);
            return result;
        }

        public static object GetRowCol(DataGridViewRow row, string columnName)
        {
            try { return (row.DataBoundItem as DataRowView).Row[columnName].ToString(); }
            catch { return null; }
        }

        public static bool SetNoResultQuery(string query)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(connStr);
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = query;
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static DataSet GetDBDataSet(string query)
        {
            DataSet result = null;
            try
            {
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
            }
            return result;
        }

        public static void FillCB(ComboBox cb, string query, string valueMember, string displayMember)
        {
            DataSet ds = GetDBDataSet(query);
            cb.DataSource = ds.Tables[0];
            cb.ValueMember = valueMember;
            cb.DisplayMember = displayMember;
        }

        public static void FillDGV(DataGridView dgv, string query)
        {
            DataSet ds = GetDBDataSet(query);
            if (ds.Tables.Count == 0) return;
            dgv.DataSource = ds.Tables[0];
        }
    }
}
