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
    public partial class SearchSPQT : Form
    {
        public HashSet<SanPham> SpDuocThemVaoGio { get; }

        // Connection string (@ represents this is a string)
        string strCon = theconnection.getconnect() ;

        // Connection object
        SqlConnection sqlCon = null;
        string searchText = "";
        int themeID = 0;
        int colorID = 0;
        int moneyFrom = 0;
        int moneyTo = 0;

        
        public SearchSPQT()
        {
            InitializeComponent();
            SpDuocThemVaoGio = new HashSet<SanPham>();
        }

        private void LoadColor()
        {
            string query = @"SELECT * FROM MAUSAC";
            DataSet ds = RetrieveData(query);
            DataRow row = ds.Tables[0].NewRow();
            row["MaMau"] = 0;
            row["TenMau"] = "--Màu sắc--";
            ds.Tables[0].Rows.InsertAt(row, 0);

            //set the ColorFilter control's data source/data table
            ColorFilter.DataSource = ds.Tables[0];
            ColorFilter.DisplayMember = "TenMau";
            ColorFilter.ValueMember = "MaMau";
        }

        private void LoadTheme()
        {
            string query = @"SELECT * FROM CHUDE";
            DataSet ds = RetrieveData(query);
            DataRow row = ds.Tables[0].NewRow();
            row["MaCD"] = 0;
            row["TenCD"] = "--Chủ đề--";
            ds.Tables[0].Rows.InsertAt(row, 0);

            //set the ColorFilter control's data source/data table
            ThemeFilter.DataSource = ds.Tables[0];
            ThemeFilter.DisplayMember = "TenCD";
            ThemeFilter.ValueMember = "MaCD";
        }

        private void LoadAllSPQT()
        {
            string query = @"SELECT SPQT.MaSPQT, SPQT.TenSPQT, SPQT.MieuTaSPQT, SPQT.GiaBan, SPQT.GiaBanSauGiam, CD.TenCD
            FROM SANPHAMQUATANG SPQT JOIN CHUDE CD ON (SPQT.CHUDEMaCD = CD.MaCD)";
            LoadSPQT(query);
        }

        private void LoadSPQT(string query)
        {
            DataSet ds = RetrieveData(query);

            //set DataGridView control to read-only
            grdData.ReadOnly = true;
            grdData.AutoGenerateColumns = false;

            //set the DataGridView control's data source/data table
            grdData.DataSource = ds.Tables[0];
            grdData.Columns["MaSPQT"].DataPropertyName = "MaSPQT";
            grdData.Columns["TenSPQT"].DataPropertyName = "TenSPQT";
            grdData.Columns["ChuDe"].DataPropertyName = "TenCD";
            grdData.Columns["MieuTaSPQT"].DataPropertyName = "MieuTaSPQT";
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
                moneyList.Add((i * 100000).ToString());
            }    
            MoneyFrom.DataSource = moneyList;

            List<string> moneyList2 = new List<string>();
            moneyList2.Add("--Giá tiền cao nhất--");
            for (int i = 1; i <= 20; i++)
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
            LoadColor();
            LoadTheme();
            LoadAllSPQT();
            LoadMoney();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string condition = "WHERE";
            string query = null;
            bool isJoin = false;
            // if user enter search keyword
            if (!String.Equals(searchText, ""))
            {
                condition = condition + " " + "SPQT.TenSPQT LIKE '%" + searchText + "%'";
            }

            // if user use color filter
            if (colorID != 0)
            {
                isJoin = true;
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

            // if user use theme filter
            if (themeID != 0)
            {
                string getTheme = "SPQT.CHUDEMaCD = " + themeID.ToString();
                if (String.Equals(condition, "WHERE"))
                {
                    condition = condition + " " + getTheme;
                }
                else
                {
                    condition = condition + " AND " + getTheme;
                }
            }

            // if user use money filter
            if (moneyFrom != 0)
            {
                string minMoney = "SPQT.GiaBanSauGiam >= " + moneyFrom.ToString();
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
                string maxMoney = "SPQT.GiaBanSauGiam <= " + moneyTo.ToString();
                if (String.Equals(condition, "WHERE"))
                {
                    condition = condition + " " + maxMoney;
                }
                else
                {
                    condition = condition + " AND " + maxMoney;
                }
            }

            // if user use color filter, we have to join multiple tables
            if (!isJoin)
            {
                query = @"SELECT SPQT.MaSPQT, SPQT.TenSPQT, SPQT.MieuTaSPQT, SPQT.GiaBan, SPQT.GiaBanSauGiam, CD.TenCD
                FROM SANPHAMQUATANG SPQT JOIN CHUDE CD ON (SPQT.CHUDEMaCD = CD.MaCD)
                ";
            }
            else
            {
                query = @"SELECT SPQT.MaSPQT, SPQT.TenSPQT, SPQT.MieuTaSPQT, SPQT.GiaBan, SPQT.GiaBanSauGiam, CD.TenCD
                FROM SANPHAMQUATANG SPQT JOIN HOATUOI_SPQT HS ON (SPQT.MaSPQT = HS.SANPHAMQUATANGMaSPQT) JOIN HOATUOI HT ON (HS.HOATUOIMaHT = HT.MaHT) JOIN CHUDE CD ON (SPQT.CHUDEMaCD = CD.MaCD)
                ";
            }
            
            if (!String.Equals(condition, "WHERE"))
            {
                query += condition;
            }
            LoadSPQT(query);
        }

        private void SearchBar_TextChanged(object sender, EventArgs e)
        {
            searchText = SearchBar.Text;
        }

        private void ColorFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            colorID = ColorFilter.SelectedIndex;
        }

        private void ThemeFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            themeID = ThemeFilter.SelectedIndex;
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
                String MaSpHienTai = grdData.Rows[e.RowIndex].Cells["MaSPQT"].Value.ToString();
                String GiaBanSpHienTai = grdData.Rows[e.RowIndex].Cells["GiaBanSauGiam"].Value.ToString();
                String TenSP = grdData.Rows[e.RowIndex].Cells["TenSPQT"].Value.ToString();
                SpDuocThemVaoGio.Add(new SanPham() { MaSP = MaSpHienTai, GiaBan = GiaBanSpHienTai, TenSP = TenSP, LoaiSP="SPQT" });

                //String temp = MaSpHienTai + GiaBanSpHienTai + TenSP + "\n\n";
                //temp += String.Join(", ", SpDuocThemVaoGio[0].TenSP);
                MessageBox.Show("Thêm sản phẩm vào giỏ hàng thành công");

            }
        }
    }
}