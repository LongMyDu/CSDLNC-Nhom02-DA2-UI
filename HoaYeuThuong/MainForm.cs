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
    public partial class MainForm : Form
    {
        HashSet<SanPham> GioHang = new HashSet<SanPham>();
        SearchSPQT SPQT_Form = null;
        Cart GioHang_Form = null;

        string strCon = @"Data Source=DESKTOP-R6PKTGC\SQLEXPRESS;Initial Catalog=DB_HoaYeuThuong;Integrated Security=True";
        SqlConnection sqlCon = null;

        public MainForm()
        {
            InitializeComponent();
            ConnectToDB();
        }

        private bool ConnectToDB()
        {
            try
            {
                sqlCon = new SqlConnection(strCon);
                sqlCon.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

            if (sqlCon.State == ConnectionState.Open)
            {
                MessageBox.Show("Connected to DB successfully!");
            }
            return true;
        }

        private void GoToSPQT_Click(object sender, EventArgs e)
        {
            // Mở form Search SPQT, nếu chưa tồn tại hoặc đã bị tắt thì tạo form mới
            if (SPQT_Form == null || SPQT_Form.IsDisposed == true)
            {
                SPQT_Form = new SearchSPQT();
            }
            SPQT_Form.Show();
        }

        private void ViewCartButton_Click(object sender, EventArgs e)
        {
            if (SPQT_Form.SpDuocThemVaoGio == null)
            {
                MessageBox.Show("Giỏ hàng trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Thêm các sản phẩm đã được thêm vào giỏ lúc khách hàng mở SearchSPQT Form vào giỏ hàng chính 
            foreach (var SP in SPQT_Form.SpDuocThemVaoGio)
            {
                GioHang.Add(SP);
            }

            // Mở form Cart, nếu chưa tồn tại hoặc đã bị tắt thì tạo form mới
            if (GioHang_Form == null || GioHang_Form.IsDisposed == true)
            {
                GioHang_Form = new Cart(strCon, GioHang);
            }
            GioHang_Form.Show();
        }
    }
}
