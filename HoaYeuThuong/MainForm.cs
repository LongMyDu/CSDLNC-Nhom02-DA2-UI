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
        SearchSPMK SPMK_Form = null;
        SearchHT HT_Form = null;
        Cart GioHang_Form = null;
        NVCamHoaForm NvCamHoa_Form = null;
        NVGiaoHangForm NvGiaoHang_Form = null;
        KTDDH_Form KTDDDHForm = null;


        string strCon = theconnection.getconnect() ;
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
            // Nếu đã mở SearchSPQT và có thêm sản phẩm thì thêm những sản phẩm trong đó vào giỏ hàng chính
            if (SPQT_Form != null && SPQT_Form.SpDuocThemVaoGio != null)
            {
                // Thêm các sản phẩm đã được thêm vào giỏ lúc khách hàng mở SearchSPQT Form vào giỏ hàng chính 
                foreach (var SP in SPQT_Form.SpDuocThemVaoGio)
                {
                    GioHang.Add(SP);
                }
            }

            // Nếu đã mở SearchHT và có thêm sản phẩm thì thêm những sản phẩm trong đó vào giỏ hàng chính
            if (HT_Form != null && HT_Form.SpDuocThemVaoGio != null)
            {
                // Thêm các sản phẩm đã được thêm vào giỏ lúc khách hàng mở SearchSPQT Form vào giỏ hàng chính 
                foreach (var SP in HT_Form.SpDuocThemVaoGio)
                {
                    GioHang.Add(SP);
                }
            }

            // Nếu đã mở SearchSPMK và có thêm sản phẩm thì thêm những sản phẩm trong đó vào giỏ hàng chính
            if (SPMK_Form != null && SPMK_Form.SpDuocThemVaoGio != null)
            {
                // Thêm các sản phẩm đã được thêm vào giỏ lúc khách hàng mở SearchSPMK Form vào giỏ hàng chính 
                foreach (var SP in SPMK_Form.SpDuocThemVaoGio)
                {
                    GioHang.Add(SP);
                }
            }

            // Nếu giỏ hàng không có sản phẩm nào thì báo lỗi
            if (GioHang.Count == 0)
            {
                MessageBox.Show("Giỏ hàng trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Mở form Cart, nếu chưa tồn tại hoặc đã bị tắt thì tạo form mới
            if (GioHang_Form == null || GioHang_Form.IsDisposed == true)
            {
                GioHang_Form = new Cart(strCon, GioHang);
            }
            GioHang_Form.Show();
        }

        private void GoToSPMK_Click(object sender, EventArgs e)
        {
            // Mở form Search SPQT, nếu chưa tồn tại hoặc đã bị tắt thì tạo form mới
            if (SPMK_Form == null || SPMK_Form.IsDisposed == true)
            {
                SPMK_Form = new SearchSPMK();
            }
            SPMK_Form.Show();
        }

        private void GoToHT_Click(object sender, EventArgs e)
        {
            // Mở form SearchHT, nếu chưa tồn tại hoặc đã bị tắt thì tạo form mới
            if (HT_Form == null || HT_Form.IsDisposed == true)
            {
                HT_Form = new SearchHT();
            }
            HT_Form.Show();
        }

        private void GoToNVCamHoa_Click(object sender, EventArgs e)
        {
            // Mở form NvCamHoa_Form, nếu chưa tồn tại hoặc đã bị tắt thì tạo form mới
            if (NvCamHoa_Form == null || NvCamHoa_Form.IsDisposed == true)
            {
                NvCamHoa_Form = new NVCamHoaForm();
            }
            NvCamHoa_Form.Show();
        }

        private void GoToNVGiaoHang_Click(object sender, EventArgs e)
        {
            // Mở form NvGiaoHang_Form, nếu chưa tồn tại hoặc đã bị tắt thì tạo form mới
            if (NvGiaoHang_Form == null || NvGiaoHang_Form.IsDisposed == true)
            {
                NvGiaoHang_Form = new NVGiaoHangForm();
            }
            NvGiaoHang_Form.Show();
        }

        private void HoaYeuThuongLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Mở form KTDDH, nếu chưa tồn tại hoặc đã bị tắt thì tạo form mới
            if (KTDDDHForm == null || KTDDDHForm.IsDisposed == true)
            {
                KTDDDHForm = new KTDDH_Form();
            }
            KTDDDHForm.Show();
        }
    }

    public static class theconnection
    {
        public static string getconnect()
        {
            return @"Data Source=TRIEUDUNGFC9F\SQLEXPRESS;Initial Catalog=DB_HOAYEUTHUONG;Integrated Security=True";
        }
    }
}
