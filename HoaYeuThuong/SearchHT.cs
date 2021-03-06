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
    public partial class SearchHT : Form
    {
        public HashSet<SanPham> SpDuocThemVaoGio { get; }

        // Connection string (@ represents this is a string)
        string strCon = theconnection.getconnect();

        // Connection object
        SqlConnection sqlCon = null;
        string searchText = "";
        int colorID = 0;
        int moneyFrom = 0;
        int moneyTo = 0;
        int index = 1;
        int size = 50;

        //Set the SqlDataAdapter object
        SqlDataAdapter dAdapterMain = new SqlDataAdapter();

        //define dataset
        DataTable dt = new DataTable();

        public SearchHT()
        {
            InitializeComponent();
            SpDuocThemVaoGio = new HashSet<SanPham>();
        }

        private DataSet LoadData(string query)
        {
            ConnectDB();
            //define the SqlCommand object
            SqlCommand cmd = new SqlCommand(query, sqlCon);

            //Set the SqlDataAdapter object
            SqlDataAdapter dAdapter = new SqlDataAdapter(cmd);

            //define dataset
            DataSet ds = new DataSet();

            //fill dataset with query results
            dAdapter.Fill(ds);
            DisconnectDB();
            return ds;
        }

        private void LoadColor()
        {
            string query = @"SELECT * FROM MAUSAC";
            DataSet ds = LoadData(query);
            DataRow row = ds.Tables[0].NewRow();
            row["MaMau"] = 0;
            row["TenMau"] = "--Màu sắc--";
            ds.Tables[0].Rows.InsertAt(row, 0);

            //set the ColorFilter control's data source/data table
            ColorFilter.DataSource = ds.Tables[0];
            ColorFilter.DisplayMember = "TenMau";
            ColorFilter.ValueMember = "MaMau";
        }

        private void LoadAllHT()
        {
            string query = @"SELECT TOP 5000 HT.MaHT, HT.TenHT, HT.YNghiaHT, HT.GiaBan, HT.GiaBanSauGiam, MS.TenMau
            FROM HOATUOI HT JOIN MAUSAC MS ON (HT.MAUSACMaMau = MS.MaMau)";
            LoadHT(query);
        }

        private void LoadHT(string query)
        {
            RetrieveData(query);

            //set DataGridView control to read-only
            grdData.ReadOnly = true;
            grdData.AutoGenerateColumns = false;

            //set the DataGridView control's data source/data table
            grdData.DataSource = dt;
            grdData.Columns["MaHT"].DataPropertyName = "MaHT";
            grdData.Columns["TenHT"].DataPropertyName = "TenHT";
            grdData.Columns["YNghiaHT"].DataPropertyName = "YNghiaHT";
            grdData.Columns["TenMau"].DataPropertyName = "TenMau";
            grdData.Columns["GiaBan"].DataPropertyName = "GiaBan";
            grdData.Columns["GiaBanSauGiam"].DataPropertyName = "GiaBanSauGiam";
            grdData.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void LoadMoney()
        {
            List<string> moneyList = new List<string>();
            moneyList.Add("--Giá tiền thấp nhất--");
            for (int i = 1; i <= 20; i++)
            {
                moneyList.Add((i * 10000).ToString());
            }    
            MoneyFrom.DataSource = moneyList;

            List<string> moneyList2 = new List<string>();
            moneyList2.Add("--Giá tiền cao nhất--");
            for (int i = 1; i <= 20; i++)
            {
                moneyList2.Add((i * 10000).ToString());
            }
            MoneyTo.DataSource = moneyList2;
        }

        private void ConnectDB()
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
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DisconnectDB()
        {
            if (sqlCon != null && sqlCon.State == ConnectionState.Open)
            {
                sqlCon.Close();
            }
        }

        private void RetrieveData(string query)
        {
            ConnectDB();
            //define the SqlCommand object
            SqlCommand cmd = new SqlCommand(query, sqlCon);

            //Set the SqlDataAdapter object
            dAdapterMain.SelectCommand = cmd;

            //fill dataset with query results
            dt.Clear();
            dAdapterMain.Fill((index-1)*size, size, dt);
            DisconnectDB();
        }

        private void GQForm_Load(object sender, EventArgs e)
        {
            LoadColor();
            LoadAllHT();
            LoadMoney();
            PreviousButton.Enabled = false;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string condition = "WHERE";
            string query = @"SELECT TOP 5000 HT.MaHT, HT.TenHT, HT.YNghiaHT, HT.GiaBan, HT.GiaBanSauGiam, MS.TenMau
            FROM HOATUOI HT JOIN MAUSAC MS ON (HT.MAUSACMaMau = MS.MaMau)
            ";

            // if user enter search keyword
            if (!String.Equals(searchText, ""))
            {
                condition = condition + " " + "HT.TenHT LIKE '%" + searchText + "%'";
            }

            // if user use color filter
            if (colorID != 0)
            {
                string getColor = "HT.MAUSACMaMau = " + colorID.ToString();
                if (String.Equals(condition, "WHERE"))
                {
                    condition = condition + " " + getColor;
                }
                else
                {
                    condition = condition + " AND " + getColor;
                }    
            }

            // if user use money filter
            if (moneyFrom != 0)
            {
                string minMoney = "HT.GiaBanSauGiam >= " + moneyFrom.ToString();
                if (String.Equals(condition, "WHERE"))
                {
                    condition = condition + " " + minMoney;
                }
                else
                {
                    condition = condition + " AND " + minMoney;
                }
            }

            if (moneyTo != 0)
            {
                string maxMoney = "HT.GiaBanSauGiam <= " + moneyTo.ToString();
                if (String.Equals(condition, "WHERE"))
                {
                    condition = condition + " " + maxMoney;
                }
                else
                {
                    condition = condition + " AND " + maxMoney;
                }
            }

            if (!String.Equals(condition, "WHERE"))
            {
                query += condition;
            }
            index = 1;
            PageNum.Text = index.ToString();
            if (index == 1)
            {
                PreviousButton.Enabled = false;
            }
            LoadHT(query);
        }

        private void SearchBar_TextChanged(object sender, EventArgs e)
        {
            searchText = SearchBar.Text;
        }

        private void ColorFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            colorID = ColorFilter.SelectedIndex;
        }

        private void MoneyFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            moneyFrom = MoneyFrom.SelectedIndex*10000;
        }

        private void MoneyTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            moneyTo = MoneyTo.SelectedIndex*10000;
        }

        private void grdData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //when the add to cart button is clicked
            if (grdData.Columns[e.ColumnIndex].Name == "AddToCartButton")
            {
                String MaSpHienTai = grdData.Rows[e.RowIndex].Cells["MaHT"].Value.ToString();
                String GiaBanSpHienTai = grdData.Rows[e.RowIndex].Cells["GiaBanSauGiam"].Value.ToString();
                String TenSP = grdData.Rows[e.RowIndex].Cells["TenHT"].Value.ToString();
                SpDuocThemVaoGio.Add(new SanPham() { MaSP = MaSpHienTai, GiaBan = GiaBanSpHienTai, TenSP = TenSP, LoaiSP="HT" });

                //String temp = MaSpHienTai + GiaBanSpHienTai + TenSP + "\n\n";
                //temp += String.Join(", ", SpDuocThemVaoGio[0].TenSP);
                MessageBox.Show("Thêm sản phẩm vào giỏ hàng thành công");

            }
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            PreviousButton.Enabled = true;
            index++;
            PageNum.Text = index.ToString();
            dt.Clear();
            dAdapterMain.Fill((index - 1) * size, size, dt);
        }

        private void PreviousButton_Click(object sender, EventArgs e)
        {
            index--;
            PageNum.Text = index.ToString();
            dt.Clear();
            dAdapterMain.Fill((index - 1) * size, size, dt);
            if (index == 1)
            {
                PreviousButton.Enabled = false;
            }   
        }
    }
}