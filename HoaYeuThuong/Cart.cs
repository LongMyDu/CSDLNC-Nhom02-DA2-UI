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
        
        String sqlConnString;
        long GiaGiam = 0;
        String MaVoucher_ThanhCong = null;

        public Cart(String sqlConnString, HashSet<SanPham> GioHang)
        {
            InitializeComponent();
            List<SanPham> ListTrongGioHang = GioHang.ToList();
            for (var i = 0; i < ListTrongGioHang.Count; i++)
            {
                sanPhamBindingSource.Add(ListTrongGioHang[i]);
            }

            this.sqlConnString = sqlConnString;

            // Cho hình thức thanh toán mặc định là Tiền mặt
            HinhThucTTInput.SelectedIndex = 0;
        }

        private long TinhTongTien_SpTrongGio()
        {
            long TongTien = 0;
            for (var i = 0; i < sanPhamBindingSource.List.Count; i++)
            {
                SanPham SP = (SanPham)sanPhamBindingSource.List[i];
                int SoLuong = 1;
                if (GioHangView.Rows[i].Cells["SL"].Value != null)
                {
                    SoLuong = int.Parse(GioHangView.Rows[i].Cells["SL"].Value.ToString());
                }

                TongTien += long.Parse(SP.GiaBan)*SoLuong;
            }
            return TongTien - GiaGiam;
        }

        //Hàm thêm chi tiết đơn hàng dựa trên SPTrongGio, CHƯA catch Exception
        private void Them_CTDDH(SqlConnection connection, SqlTransaction transaction, int MaDDH)
        {

            for(var i = 0; i < sanPhamBindingSource.List.Count; i++)
            {
                SqlCommand command = connection.CreateCommand();
                command.Connection = connection;
                command.Transaction = transaction;

                SanPham SP = (SanPham)sanPhamBindingSource.List[i];
                String SoLuong = GioHangView.Rows[i].Cells["SL"].Value.ToString();
               
                if (SP.LoaiSP == "HT")
                {
                    command.CommandText =
                    @"INSERT INTO Mua_HOATUOI(DONDATHANGMaDDH, HOATUOIMaHT, DonGia, SoLuong)
                    VALUES(@MaDDH, @MaSP, @DonGia, @SoLuong)";
                }
                else if (SP.LoaiSP == "SPQT")
                {
                    command.CommandText =
                    @"INSERT INTO Mua_SPQT(DONDATHANGMaDDH, SANPHAMQUATANGMaSPQT, DonGia, SoLuong)
                    VALUES(@MaDDH, @MaSP, @DonGia, @SoLuong)";
                }
                else
                {
                    command.CommandText =
                    @"INSERT INTO Mua_SPMK(DONDATHANGMaDDH, SANPHAMMUAKEMMaSPMK, DonGia, SoLuong)
                    VALUES(@MaDDH, @MaSP, @DonGia, @SoLuong)";
                }
                command.Parameters.AddWithValue("@MaDDH", MaDDH);
                command.Parameters.AddWithValue("@MaSP", SP.MaSP);
                command.Parameters.AddWithValue("@DonGia", SP.GiaBan);
                command.Parameters.AddWithValue("@SoLuong", SoLuong);
                command.ExecuteNonQuery();
            }
        }

        private void Them_DDH()
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

            using (SqlConnection connection = new SqlConnection(sqlConnString))
            {
                connection.Open();

                SqlCommand insert_cmd = connection.CreateCommand();
                SqlTransaction transaction;

                // Start a local transaction.
                transaction = connection.BeginTransaction("InsertDDHTransaction");

                insert_cmd.Connection = connection;
                insert_cmd.Transaction = transaction;
                
                try
                {
                    insert_cmd.CommandText =
                    @"INSERT INTO DONDATHANG (TinhTrangDH, CHINHANHMaCN, HoTenNM, SdtNM, EmailNM, DiaChiNM, HoTenNN, SdtNN, SoNhaNN, QuanNN, ThanhPhoNN, ThoiGianGiao, HTThanhToan, PhiVanChuyen, TinhTrangTT, TongTien, VOUCHERMaVoucher)
                    VALUES(N'Đã tiếp nhận', NULL, @HoTenNM, @SdtNM, @EmailNM, @DiaChiNM, @HoTenNN, @SdtNN, @SoNhaNN, @QuanNN, @ThanhPhoNN, @ThoiGianGiao, @HTThanhToan, @PhiVanChuyen, N'Chưa thanh toán', @TongTien, @MaVoucher); SELECT SCOPE_IDENTITY();";

                    long TongTien = TinhTongTien_SpTrongGio();

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
                    insert_cmd.Parameters.AddWithValue("@TongTien", TongTien);
                    // insert_cmd.Parameters.AddWithValue("@MaVoucher", MaVoucher_ThanhCong);
                    if (MaVoucher_ThanhCong == null)
                    {
                        insert_cmd.Parameters.AddWithValue("@MaVoucher", DBNull.Value);
                    }
                    else
                    {
                        insert_cmd.Parameters.AddWithValue("@MaVoucher", MaVoucher_ThanhCong);
                    }

                    int newDDH = Convert.ToInt32(insert_cmd.ExecuteScalar());

                    Them_CTDDH(connection, transaction, newDDH);
                    transaction.Commit();
                    MessageBox.Show("Đặt hàng thành công. Mã đơn hàng của bạn: " + newDDH.ToString(), "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi! Không thể thêm đơn hàng.\n\n" + ex.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    try
                    {
                        transaction.Rollback();
                    }
                    catch (Exception ex2)
                    {
                    }
                }
            }
        }
        
        private void Get_Voucher(String MaVoucher)
        {
            using (SqlConnection connection = new SqlConnection(sqlConnString))
            {
                connection.Open();
                SqlCommand select_cmd = connection.CreateCommand();
                select_cmd.CommandText = @"SELECT * FROM VOUCHER WHERE MaVoucher = @MaVoucher";
                select_cmd.Parameters.AddWithValue("@MaVoucher", MaVoucher);

                SqlDataAdapter da = new SqlDataAdapter(select_cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Đã xảy ra lỗi! Không tìm thấy voucher.\n\n", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                int LuotSuDung = int.Parse(dt.Rows[0].ItemArray[1].ToString());

                if (LuotSuDung > 0)
                {
                    GiaGiam = long.Parse(dt.Rows[0].ItemArray[2].ToString());
                    MaVoucher_ThanhCong = MaVoucher;
                }
            }
        }

        //TIPS: Thêm các điều kiện ràng buộc thông tin vào hàm này
        private bool KiemTra_ThongTinDatHang_HopLe()
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

            //if (String.IsNullOrEmpty(HoTenNM) || String.IsNullOrEmpty(SdtNM) || String.IsNullOrEmpty(EmailNM) || String.IsNullOrEmpty(DiaChiNM) || String.IsNullOrEmpty(HTThanhToan) 
            //    || String.IsNullOrEmpty(HoTenNN) || String.IsNullOrEmpty(SdtNN) || String.IsNullOrEmpty(SoNhaNN) || String.IsNullOrEmpty(QuanNN) || String.IsNullOrEmpty(ThanhPhoNN) || String.IsNullOrEmpty(ThoiGianGiao))
            //{
            //    MessageBox.Show("Thông tin không đầy đủ, xin hãy điền đầy đủ các ô bắt buộc.\n\n", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return false;
            //}

            for (var i = 0; i < sanPhamBindingSource.List.Count; i++)
            {
                String SoLuongStr = GioHangView.Rows[i].Cells["SL"].Value.ToString();
                int SoLuongInt = 0;
                if (int.TryParse(SoLuongStr, out SoLuongInt) == false)
                {
                    MessageBox.Show("Đã xảy ra lỗi! Số lượng của sản phẩm không hợp lệ.\n\n", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }

        private void DatHangButton_Click(object sender, EventArgs e)
        {
            if (KiemTra_ThongTinDatHang_HopLe() == false)
                return;
            
            DialogResult dr = MessageBox.Show("Xác nhận đặt hàng?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {
                    Them_DDH();
            }
        }

        private void GioHangView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            TongTienLabel.Text = "Tổng tiền: " + TinhTongTien_SpTrongGio().ToString();
        }

        private void ThanhPhoNnInput_TextChanged(object sender, EventArgs e)
        {
            PhiVCLabel.Text = "Phí vận chuyển: 20000";
        }

        private void Cart_Load(object sender, EventArgs e)
        {
            for (var i = 0; i < sanPhamBindingSource.List.Count; i++)
            {
                GioHangView.Rows[i].Cells["SL"].Value = "1";
            }

            TongTienLabel.Text = "Tổng tiền: " + TinhTongTien_SpTrongGio().ToString();
        }

        private void GioHangView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GioHangView.Columns[e.ColumnIndex].Name == "XoaSP")
            {
                sanPhamBindingSource.RemoveCurrent();
                TongTienLabel.Text = "Tổng tiền: " + TinhTongTien_SpTrongGio().ToString();
            }
        }

        private void VoucherInput_TextChanged(object sender, EventArgs e)
        {
            String Voucher = VoucherInput.Text;
            if (String.IsNullOrEmpty(Voucher) == false)
            {
                Get_Voucher(Voucher);

                TongTienLabel.Text = "Tổng tiền: " + TinhTongTien_SpTrongGio().ToString();
            }
        }
    }
}
