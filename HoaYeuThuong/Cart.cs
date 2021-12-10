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
using System.Globalization;

namespace HoaYeuThuong
{
    public partial class Cart : Form
    {
        List<SanPham> SpTrongGio;
        SqlConnection sqlCon;
        public Cart(SqlConnection sqlConn, HashSet<SanPham> GioHang)
        {
            InitializeComponent();
            SpTrongGio = GioHang.ToList();

            GioHangView.DataSource = SpTrongGio;
            sqlCon = sqlConn;
        }

        private bool Them_DDH()
        {
            String HoTenNM = HoTenNmInput.Text;
            String SdtNM = SdtNmInput.Text;
            String EmailNM = EmailNmInput.Text;
            String DiaChiNM = DiaChiNmInput.Text;
            String HTThanhToan = HinhThucTTInput.SelectedItem.ToString();
            String Voucher = VoucherInput.Text;
            String LoiNhanCH = LoiNhanCHInput.Text;

            String HoTenNN = HoTenNnInput.Text;
            String SdtNN = SdtNnInput.Text;
            String SoNhaNN = SoNhaNnInput.Text;
            String QuanNN = QuanNnInput.Text;
            String ThanhPhoNN = ThanhPhoNnInput.Text;
            String LoiNhanNN = LoiNhanNNInput.Text;
            String ThoiGianGiao = ThoiGianGiaoInput.Text;

            String PhiVanChuyen = "20000";

            var cultureInfo = new CultureInfo("de-DE");
            var dateTime = DateTime.Parse(ThoiGianGiao, cultureInfo);

            MessageBox.Show(dateTime.ToString());
            SqlCommand insert_cmd = new SqlCommand((@"INSERT INTO DONDATHANG (TinhTrangDH, CHINHANHMaCN, HoTenNM, SdtNM, EmailNM, DiaChiNM, HoTenNN, SdtNN, SoNhaNN, QuanNN, ThanhPhoNN, ThoiGianGiao, HTThanhToan, PhiVanChuyen, TinhTrangTT)
                                                      VALUES(N'Đã tiếp nhận', NULL, @HoTenNM, @SdtNM, @EmailNM, @DiaChiNM, @HoTenNN, @SdtNN, @SoNhaNN, @QuanNN, @ThanhPhoNN, @ThoiGianGiao, @HTThanhToan, @PhiVanChuyen, N'Chưa thanh toán')"), sqlCon);
            insert_cmd.Parameters.AddWithValue("@HoTenNM", HoTenNM);
            insert_cmd.Parameters.AddWithValue("@SdtNM", SdtNM);
            insert_cmd.Parameters.AddWithValue("@EmailNM", EmailNM);
            insert_cmd.Parameters.AddWithValue("@DiaChiNM", DiaChiNM);

            insert_cmd.Parameters.AddWithValue("@HoTenNN", HoTenNN);
            insert_cmd.Parameters.AddWithValue("@SoNhaNN", SoNhaNN);
            insert_cmd.Parameters.AddWithValue("@SdtNN", SdtNN);
            insert_cmd.Parameters.AddWithValue("@QuanNN", QuanNN);
            insert_cmd.Parameters.AddWithValue("@ThanhPhoNN", ThanhPhoNN);
            insert_cmd.Parameters.AddWithValue("@ThoiGianGiao", dateTime);
            insert_cmd.Parameters.AddWithValue("@HTThanhToan", HTThanhToan);
            insert_cmd.Parameters.AddWithValue("@PhiVanChuyen", PhiVanChuyen);


            int row_affected = insert_cmd.ExecuteNonQuery();
            if (row_affected == 0)
            {
                MessageBox.Show("Đã xảy ra lỗi! Không thể thêm đơn hàng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                MessageBox.Show("Đặt hàng thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
        }
        private void DatHangButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Xác nhận đặt hàng?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {
                Them_DDH();
            }
        }
    }
}
