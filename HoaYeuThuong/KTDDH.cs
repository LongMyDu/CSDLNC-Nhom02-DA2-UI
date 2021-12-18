using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HoaYeuThuong
{
    public partial class KTDDH_Form : Form
    {

        string strCon = theconnection.getconnect();
        SqlConnection sqlCon = null;
        string keysearch ="";
        // Connection object
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
            return true;
        }

  
        private void HienThi_DonHang()
        {
           
            String querry = @"SELECT MaDDH, HoTenNM, ThoiGianGiao, LoiNhanCH, TinhTrangDH, NHANVIENCAMHOAMaNV, NHANVIENGIAOHANGMaNV, TongTien FROM DONDATHANG WHERE MaDDH =" + keysearch;
            // querry += "OR SdtNM =" + keysearch;
            // querry += "OR EmailNM =" + keysearch;


            SqlDataAdapter sqlDaDH = new SqlDataAdapter(querry, sqlCon);
            DataTable dtbDH = new DataTable();
            sqlDaDH.Fill(dtbDH);

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = dtbDH;

            //set DataGridView control to read-only
            dataGridView1.ReadOnly = true;
            dataGridView1.Columns["MaDDH"].DataPropertyName = "MaDDH";
            dataGridView1.Columns["HoTenNM"].DataPropertyName = "HoTenNM";
            dataGridView1.Columns["ThoiGianGiao"].DataPropertyName = "ThoiGianGiao";
            dataGridView1.Columns["LoiNhanCH"].DataPropertyName = "LoiNhanCH";
            dataGridView1.Columns["TinhTrang"].DataPropertyName = "TinhTrangDH";
            dataGridView1.Columns["NVCamHoa"].DataPropertyName = "NHANVIENCAMHOAMaNV";
            dataGridView1.Columns["NVGiaoHang"].DataPropertyName = "NHANVIENGIAOHANGMaNV";
            dataGridView1.Columns["TongTien"].DataPropertyName = "TongTien";
            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        public KTDDH_Form()
        {
            InitializeComponent();
            ConnectToDB();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            keysearch = textBox1.Text;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // if user enter search keyword
            if (!String.Equals(keysearch, ""))
            {
                HienThi_DonHang();
            }
        }
    }
}
