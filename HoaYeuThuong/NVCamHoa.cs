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
    public partial class NVCamHoa : Form
    {
        string strCon = theconnection.getconnect() ;
        SqlConnection sqlCon = null;
        string MaDdhHienTai;
        public NVCamHoa()
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

        private bool CapNhat_NvCamHoa_DDH(String MaDDH, String MaNvCamHoa)
        {
            SqlCommand update_cmd = new SqlCommand((@" UPDATE DONDATHANG 
                                                       SET NHANVIENCAMHOAMaNV = @MaNvCamHoa
                                                       WHERE MaDDH = @MaDDH"), sqlCon);
            update_cmd.Parameters.AddWithValue("@MaDDH", MaDDH);
            update_cmd.Parameters.AddWithValue("@MaNvCamHoa", MaNvCamHoa);
            try
            {
                update_cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi! Không thể cập nhật nhân viên cắm hoa.\n\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void HienThi_DonHang()
        {
            //String MaNvCamHoa = NvInput.Value.ToString();
            String MaCN = CnInput.Value.ToString();
            String select_cmd = @"SELECT MaDDH, HoTenNM, ThoiGianGiao, LoiNhanCH, TinhTrangDH, NHANVIENCAMHOAMaNV, CHINHANHMaCN FROM DONDATHANG WHERE ";

            select_cmd += "CHINHANHMaCN = " + MaCN;
            if (TinhTrangCombobox.SelectedItem != null)
            {
                String SelectedText = TinhTrangCombobox.SelectedItem.ToString();
                if (SelectedText == @"Tất cả")
                {
                    select_cmd += " AND TinhTrangDH != N'Đã hủy' AND TinhTrangDH != N'Đã giao'";
                }
                else
                {
                    select_cmd += " AND TinhTrangDH = N'" + SelectedText + @"'";
                }
            }

            SqlDataAdapter sqlDaDH = new SqlDataAdapter(select_cmd, sqlCon);
            DataTable dtbDH = new DataTable();
            sqlDaDH.Fill(dtbDH);

            NVCamHoaView.AutoGenerateColumns = false;
            NVCamHoaView.DataSource = dtbDH;
        }

        private void HienThiButton_Click(object sender, EventArgs e)
        {
            HienThi_DonHang();
        }

        private void NVCamHoaView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (NVCamHoaView.Columns[e.ColumnIndex].Name == "CTDDH")
            {
                MaDdhHienTai = NVCamHoaView.Rows[e.RowIndex].Cells["MaDDH"].Value.ToString();
                MaDdhHienTaiLabel.Text = "Đơn hiện tại: " + MaDdhHienTai;

                SqlDataAdapter sqlDaCT = new SqlDataAdapter((@"SELECT DONDATHANGMaDDH, SANPHAMQUATANGMaSPQT, TenSPQT, SoLuong 
                                                               FROM DONDATHANG DH JOIN MUA_SPQT SP ON(DH.MaDDH = SP.DONDATHANGMaDDH)
                                                               JOIN SANPHAMQUATANG SPQT ON(SP.SANPHAMQUATANGMaSPQT = SPQT.MaSPQT)
                                                               WHERE DH.MaDDH = " + MaDdhHienTai), sqlCon);
                DataTable dtbCT = new DataTable();
                sqlDaCT.Fill(dtbCT);
                NVCamHoaViewCT.AutoGenerateColumns = false;
                NVCamHoaViewCT.DataSource = dtbCT;
            }
        }

        private void UnfinishButton_Click(object sender, EventArgs e)
        {
            CapNhat_TinhTrang_DDH(MaDdhHienTai, "Đang cắm hoa");
            HienThi_DonHang();
        }

        private void FinishButton_Click(object sender, EventArgs e)
        {
            CapNhat_TinhTrang_DDH(MaDdhHienTai, "Đã cắm xong");
            HienThi_DonHang();
        }

         private void TiepNhanButton_Click(object sender, EventArgs e)
         {
            String MaNvCamHoa = NvInput.Value.ToString();
            if (CapNhat_NvCamHoa_DDH(MaDdhHienTai, MaNvCamHoa))
            {
                CapNhat_TinhTrang_DDH(MaDdhHienTai, "Đang cắm hoa");
            }
            HienThi_DonHang();
         }
    }
}
