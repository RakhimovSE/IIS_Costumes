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

        public static string DateToMysql(DateTime dt, bool date = true, bool time = true)
        {
            string format = string.Format("{0}{1}{2}", date ? "yyyy-MM-dd" : "",
                date && time ? " " : "", time ? "HH:mm:ss" : "");
            string result = dt.ToString(format);
            return result;
        }

        public static object GetRowCol(DataGridViewRow row, string columnName)
        {
            try { return (row.DataBoundItem as DataRowView).Row[columnName]; }
            catch { return null; }
        }

        public static long SetNoResultQuery(string query)
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
                return cmd.LastInsertedId;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public static object GetValueFromDB(string query)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(connStr);
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = query;
                conn.Open();
                object result = cmd.ExecuteScalar();
                conn.Close();
                return result;
            }
            catch (Exception ex)
            {
                return null;
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
            cb.DisplayMember = displayMember;
            cb.ValueMember = valueMember;
        }

        public static void FillDGV(DataGridView dgv, string query)
        {
            DataSet ds = GetDBDataSet(query);
            if (ds.Tables.Count == 0) return;
            dgv.DataSource = ds.Tables[0];
        }
    }
}
