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
        public GQForm()
        {
            InitializeComponent();
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            string connetionString;
            SqlConnection cnn;
            connetionString = "Data Source=DESKTOP-MNUAD46\\SQLEXPRESS;Initial Catalog=DB_HoaYeuThuong;User ID=sa;Password=svcntt";
            cnn = new SqlConnection(connetionString);
            try
            {
                cnn.Open();
                //retrieve the SQL Server instance version
                string query = @"SELECT * FROM SANPHAMQUATANG";

                //define the SqlCommand object
                SqlCommand cmd = new SqlCommand(query, cnn);

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

                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
            }
        }

        private void GQForm_Load(object sender, EventArgs e)
        {
        }
    }
}
