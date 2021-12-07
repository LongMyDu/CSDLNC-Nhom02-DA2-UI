using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HoaYeuThuong
{
    public partial class NTForm : Form
    {

        public NTForm()
        {
            InitializeComponent();
        }

     
        private void button1_Click_1(object sender, EventArgs e)
        {
            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=LEOSMAC25A1\SQLEXPRESS;Initial Catalog=DB_HoaYeuThuong;User ID=sa;Password=svcntt";
            cnn = new SqlConnection(connetionString);
            cnn.Open();

            try
            {

                    //retrieve the SQL Server instance version
                    string query = @"SELECT *
                                    FROM HOATUOI_SPQT";

                    //define the SqlCommand object
                    SqlCommand cmd = new SqlCommand(query, cnn);


                    //Set the SqlDataAdapter object
                    SqlDataAdapter dAdapter = new SqlDataAdapter(cmd);

                    //define dataset
                    DataSet ds = new DataSet();

                    //fill dataset with query results
                    dAdapter.Fill(ds);

                //set DataGridView control to read-only
                    SPQT.ReadOnly = true;

                //set the DataGridView control's data source/data table
                    SPQT.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                //display error message
                MessageBox.Show("Exception: " + ex.Message);
            }
            //close connection
            cnn.Close();

        }

        private void NTForm_Load(object sender, EventArgs e)
        {
        }
    }
}
