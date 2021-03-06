﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace IIS_Costumes
{
    static class Program
    {
        public static MySqlConnection conn = new MySqlConnection(Properties.Resources.ConnectionString);
        public static int employee_id;
        public static string employee_name;
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            new AuthForm().ShowDialog();
            if (employee_id != default(int))
                Application.Run(new OrderForm());
        }
    }
}
