﻿using System;
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
    public partial class OrderForm : Form
    {
        // Hello Ivan!
        // Сообщение Севастьян
        public OrderForm()
        {
            DataSet ds = DBConnector.GetDBDataSet("SELECT * FROM `carnaval`.`client`");
            dataGridView1.DataSource = ds.Tables[0];
            InitializeComponent();
        }
    }//сообщение 11
}