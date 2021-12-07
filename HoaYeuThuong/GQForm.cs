using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HoaYeuThuong
{
    public partial class GQForm : Form
    {
        // Connection string (@ represents this is a string)
        string strCon = @"Data Source=DESKTOP-MNUAD46\SQLEXPRESS;Initial Catalog=DB_HoaYeuThuong;Integrated Security=True";

        // Connection object
        SqlConnection sqlCon = null;
        string searchText = "";
        public GQForm()
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

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            if (sqlCon == null || sqlCon.State == ConnectionState.Closed)
            {
                MessageBox.Show("Please connect first!");
            }
            else
            {
                //retrieve the SQL Server instance version
                string query = @"SELECT * FROM SANPHAMQUATANG";

                //define the SqlCommand object
                SqlCommand cmd = new SqlCommand(query, sqlCon);

                //Set the SqlDataAdapter object
                SqlDataAdapter dAdapter = new SqlDataAdapter(cmd);

                //define dataset
                DataSet ds = new DataSet();

                //fill dataset with query results
                dAdapter.Fill(ds);

                //set DataGridView control to read-only
                grdData.ReadOnly = true;

                //set the DataGridView control's data source/data table
                grdData.DataSource = ds.Tables[0];
            }
        }

        private void GQForm_Load(object sender, EventArgs e)
        {
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (sqlCon == null || sqlCon.State == ConnectionState.Closed)
            {
                MessageBox.Show("Please connect first!");
            }
            else
            {
                //retrieve the SQL Server instance version
                string query = @"SELECT *
                FROM SANPHAMQUATANG SPQT
                WHERE SPQT.TenSPQT LIKE '%" + searchText + "%'";

                //define the SqlCommand object
                SqlCommand cmd = new SqlCommand(query, sqlCon);

                //Set the SqlDataAdapter object
                SqlDataAdapter dAdapter = new SqlDataAdapter(cmd);

                //define dataset
                DataSet ds = new DataSet();

                //fill dataset with query results
                dAdapter.Fill(ds);

                //set DataGridView control to read-only
                grdData.ReadOnly = true;

                //set the DataGridView control's data source/data table
                grdData.DataSource = ds.Tables[0];
            }
        }

        private void SearchBar_TextChanged(object sender, EventArgs e)
        {
            searchText = SearchBar.Text;
        }
    }
}
