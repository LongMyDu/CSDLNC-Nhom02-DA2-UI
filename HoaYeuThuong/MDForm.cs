using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// library for connecting to MSSQL
using System.Data.SqlClient;


namespace HoaYeuThuong
{
    public partial class MDForm : Form
    {
        // Connection string (@ represents this is a string)
        string strCon = @"Data Source=TRIEUDUNGFC9F\SQLEXPRESS;Initial Catalog=DB_HoaYeuThuong;Integrated Security=True";

        // Connection object
        SqlConnection sqlCon = null;

        public MDForm()
        {
            InitializeComponent();
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            try
            {
                // If null, then initialize
                if (sqlCon == null)
                {
                    // Pass a connection string when initializing a connection object
                    sqlCon = new SqlConnection(strCon);
                }
               
                // If closed, then open
                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();
                    MessageBox.Show("Connect successfully");
                }
                else
                {
                    MessageBox.Show("Already connected");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DisconnectButton_Click(object sender, EventArgs e)
        {
            if (sqlCon != null && sqlCon.State == ConnectionState.Open)
            {
                sqlCon.Close();
                MessageBox.Show("Disconnect sucessfully");
            }
            else
            {
                MessageBox.Show("Have not connected yet");
            }
        }
    }
}
