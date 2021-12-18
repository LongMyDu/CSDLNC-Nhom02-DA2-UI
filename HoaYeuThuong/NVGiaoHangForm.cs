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
    public partial class NVGiaoHangForm : Form
    {
        string strCon = theconnection.getconnect();
        SqlConnection sqlCon = null;
        string MaDdhHienTai;
        public NVGiaoHangForm()
        {
            InitializeComponent();
            ConnectToDB();
            LTCNComboBox.SelectedItem = null;
            LTTTComboBox.SelectedItem = null;
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

        private bool CapNhat_TinhTrang_DDH(String MaDDH, String TinhTrang)
        {
            SqlCommand update_cmd = new SqlCommand((@" UPDATE DONDATHANG 
                                                       SET TinhTrangDH = N'" + TinhTrang + @"'
                                                       WHERE MaDDH = @MaDDH"), sqlCon);
            update_cmd.Parameters.AddWithValue("@MaDDH", MaDDH);

            int row_affected = update_cmd.ExecuteNonQuery();
            if (row_affected == 0)
            {
                MessageBox.Show("Đã xảy ra lỗi! Không thể cập nhật tình trạng của đơn hàng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                MessageBox.Show("Cập nhật tình trạng đơn hàng thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
        }

        private bool CapNhat_NvGiaoHang_DDH(String MaDDH, String MaNvGiaoHang)
        {
            SqlCommand update_cmd = new SqlCommand((@" UPDATE DONDATHANG 
                                                       SET NHANVIENGIAOHANGMaNV = @MaNvGiaoHang
                                                       WHERE MaDDH = @MaDDH"), sqlCon);
            update_cmd.Parameters.AddWithValue("@MaDDH", MaDDH);
            update_cmd.Parameters.AddWithValue("@MaNvGiaoHang", MaNvGiaoHang);
            try
            {
                update_cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi! Không thể cập nhật nhân viên giao hàng.\n\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void HienThi_DonHang()
        {
            String MaNVGH = NVGHInput.Value.ToString();
            String MaCN = LTCNComboBox.SelectedItem.ToString();
            String select_cmd = @"SELECT TOP (1000) MaDDH, HoTenNN, SdtNN, SoNhaNN, QuanNN, ThanhPhoNN, ThoiGianGiao, PhiVanChuyen, TongTien, TinhTrangTT, TinhTrangDH, NHANVIENGIAOHANGMaNV, CHINHANHMaCN FROM DONDATHANG WHERE ";
            if (LTTTComboBox.SelectedItem != null)
            {
                String SelectedText = LTTTComboBox.SelectedItem.ToString();
                if (SelectedText == @"Tất cả")
                {
                    select_cmd += " TinhTrangDH != N'Đang giao hàng' AND TinhTrangDH != N'Giao hàng thành công'";
                }
                else
                {
                    select_cmd += " TinhTrangDH = N'" + SelectedText + @"'";
                }
            }
            if (LTCNComboBox.SelectedItem != null)
            {
                String SelectedText = LTTTComboBox.SelectedItem.ToString();
                if (SelectedText == @"Tất cả")
                {
                    select_cmd += " ";
                }
                else
                {
                    select_cmd += " AND CHINHANHMaCN = " + MaCN;
                }
            }

            SqlDataAdapter sqlDaDH = new SqlDataAdapter(select_cmd, sqlCon);
            DataTable dtbDH = new DataTable();
            sqlDaDH.Fill(dtbDH);

            NVGiaoHangView.AutoGenerateColumns = true;
            NVGiaoHangView.DataSource = dtbDH;
        }

        private void HienThiButton_Click(object sender, EventArgs e)
        {
            HienThi_DonHang();
        }

        private void NVGiaoHangView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (NVGiaoHangView.Columns[e.ColumnIndex].Name == "MaDDH")
            {
                MaDdhHienTai = NVGiaoHangView.Rows[e.RowIndex].Cells["MaDDH"].Value.ToString();
                DonHienTaiLabel.Text = "Đơn hiện tại: " + MaDdhHienTai;
            }
        }

        private void DangGiaoButton_Click(object sender, EventArgs e)
        {
            String MaNvGiaoHang = NVGHInput.Value.ToString();
            if (CapNhat_NvGiaoHang_DDH(MaDdhHienTai, MaNvGiaoHang))
            {
                CapNhat_TinhTrang_DDH(MaDdhHienTai, "Đang giao hàng");
            }
            HienThi_DonHang();
        }

        private void DaGiaoButton_Click(object sender, EventArgs e)
        {
            CapNhat_TinhTrang_DDH(MaDdhHienTai, "Giao hàng thành công");
            HienThi_DonHang();
        }
    }
}
