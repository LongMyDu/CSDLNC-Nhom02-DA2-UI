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
    public partial class SearchSPMK : Form
    {
        public HashSet<SanPham> SpDuocThemVaoGio { get; }

        // Connection string (@ represents this is a string)
        string strCon = @"Data Source=DESKTOP-MNUAD46\SQLEXPRESS;Initial Catalog=DB_HoaYeuThuong;Integrated Security=True";

        // Connection object
        SqlConnection sqlCon = null;
        string searchText = "";
        int moneyFrom = 0;
        int moneyTo = 0;

        public SearchSPMK()
        {
            InitializeComponent();
            SpDuocThemVaoGio = new HashSet<SanPham>();
        }

        private void LoadAllSPMK()
        {
            string query = @"SELECT SPMK.MaSPMK, SPMK.TenSPMK, SPMK.MieuTaSPMK, SPMK.GiaBan, DT.TenDT
            FROM SANPHAMMUAKEM SPMK JOIN DOITAC DT ON (SPMK.DOITACMaDT = DT.MaDT)";
            LoadSPMK(query);
        }

        private void LoadSPMK(string query)
        {
            DataSet ds = RetrieveData(query);

            //set DataGridView control to read-only
            grdData.ReadOnly = true;
            grdData.AutoGenerateColumns = false;

            //set the DataGridView control's data source/data table
            grdData.DataSource = ds.Tables[0];
            grdData.Columns["MaSPMK"].DataPropertyName = "MaSPMK";
            grdData.Columns["TenSPMK"].DataPropertyName = "TenSPMK";
            grdData.Columns["MieuTaSPMK"].DataPropertyName = "MieuTaSPMK";
            grdData.Columns["GiaBan"].DataPropertyName = "GiaBan";
            grdData.Columns["DoiTac"].DataPropertyName = "TenDT";
            grdData.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void LoadMoney()
        {
            List<string> moneyList = new List<string>();
            moneyList.Add("--Giá tiền thấp nhất--");
            for (int i = 1; i <= 15; i++)
            {
                moneyList.Add((i * 100000).ToString());
            }    
            MoneyFrom.DataSource = moneyList;

            List<string> moneyList2 = new List<string>();
            moneyList2.Add("--Giá tiền cao nhất--");
            for (int i = 1; i <= 15; i++)
            {
                moneyList2.Add((i * 100000).ToString());
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

        private DataSet RetrieveData(string query)
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

        private void GQForm_Load(object sender, EventArgs e)
        {
            LoadAllSPMK();
            LoadMoney();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string condition = "WHERE";
            string query = @"SELECT SPMK.MaSPMK, SPMK.TenSPMK, SPMK.MieuTaSPMK, SPMK.GiaBan, DT.TenDT
            FROM SANPHAMMUAKEM SPMK JOIN DOITAC DT ON (SPMK.DOITACMaDT = DT.MaDT)
            ";
            // if user enter search keyword
            if (!String.Equals(searchText, ""))
            {
                condition = condition + " " + "SPMK.TenSPMK LIKE '%" + searchText + "%'";
            }

            // if user use money filter
            if (moneyFrom != 0)
            {
                string minMoney = "SPMK.GiaBan >= " + moneyFrom.ToString();
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
                string maxMoney = "SPMK.GiaBan <= " + moneyTo.ToString();
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
            LoadSPMK(query);
        }

        private void SearchBar_TextChanged(object sender, EventArgs e)
        {
            searchText = SearchBar.Text;
        }

        private void MoneyFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            moneyFrom = MoneyFrom.SelectedIndex*100000;
        }

        private void MoneyTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            moneyTo = MoneyTo.SelectedIndex*100000;
        }

        private void grdData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //when the add to cart button is clicked
            if (grdData.Columns[e.ColumnIndex].Name == "AddToCartButton")
            {
                String MaSpHienTai = grdData.Rows[e.RowIndex].Cells["MaSPMK"].Value.ToString();
                String GiaBanSpHienTai = grdData.Rows[e.RowIndex].Cells["GiaBan"].Value.ToString();
                String TenSP = grdData.Rows[e.RowIndex].Cells["TenSPMK"].Value.ToString();
                SpDuocThemVaoGio.Add(new SanPham() { MaSP = MaSpHienTai, GiaBan = GiaBanSpHienTai, TenSP = TenSP, LoaiSP="SPMK" });

                //String temp = MaSpHienTai + GiaBanSpHienTai + TenSP + "\n\n";
                //temp += String.Join(", ", SpDuocThemVaoGio[0].TenSP);
                MessageBox.Show("Thêm sản phẩm vào giỏ hàng thành công");

            }
        }
    }
}