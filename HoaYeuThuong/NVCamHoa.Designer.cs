namespace HoaYeuThuong
{
    partial class NVCamHoa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.NVCamHoaView = new System.Windows.Forms.DataGridView();
            this.MaDDH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTenNM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGianGiao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoiNhanCH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NVCamHoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChiNhanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CTDDH = new System.Windows.Forms.DataGridViewButtonColumn();
            this.HienThiButton = new System.Windows.Forms.Button();
            this.FinishButton = new System.Windows.Forms.Button();
            this.UnfinishButton = new System.Windows.Forms.Button();
            this.NVCamHoaViewCT = new System.Windows.Forms.DataGridView();
            this.MaDDH_MuaSPQT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSP_MuaSPQT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten_MuaSPQT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SL_MuaSPQT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NVLabel = new System.Windows.Forms.Label();
            this.NvInput = new System.Windows.Forms.NumericUpDown();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.MaDdhHienTaiLabel = new System.Windows.Forms.Label();
            this.TiepNhanButton = new System.Windows.Forms.Button();
            this.CNLabel = new System.Windows.Forms.Label();
            this.CnInput = new System.Windows.Forms.NumericUpDown();
            this.LocTheoTinhTrangLabel = new System.Windows.Forms.Label();
            this.TinhTrangCombobox = new System.Windows.Forms.ComboBox();
            this.nVCamHoaViewDonDatHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.NVCamHoaView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NVCamHoaViewCT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NvInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CnInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nVCamHoaViewDonDatHangBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // NVCamHoaView
            // 
            this.NVCamHoaView.AllowUserToAddRows = false;
            this.NVCamHoaView.AllowUserToDeleteRows = false;
            this.NVCamHoaView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NVCamHoaView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDDH,
            this.HoTenNM,
            this.ThoiGianGiao,
            this.LoiNhanCH,
            this.TinhTrang,
            this.NVCamHoa,
            this.ChiNhanh,
            this.CTDDH});
            this.NVCamHoaView.Location = new System.Drawing.Point(0, 83);
            this.NVCamHoaView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NVCamHoaView.Name = "NVCamHoaView";
            this.NVCamHoaView.Size = new System.Drawing.Size(1184, 284);
            this.NVCamHoaView.TabIndex = 0;
            this.NVCamHoaView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.NVCamHoaView_CellContentClick);
            // 
            // MaDDH
            // 
            this.MaDDH.DataPropertyName = "MaDDH";
            this.MaDDH.HeaderText = "Mã Đơn";
            this.MaDDH.Name = "MaDDH";
            this.MaDDH.ReadOnly = true;
            this.MaDDH.Width = 150;
            // 
            // HoTenNM
            // 
            this.HoTenNM.DataPropertyName = "HoTenNM";
            this.HoTenNM.HeaderText = "Họ tên KH";
            this.HoTenNM.Name = "HoTenNM";
            this.HoTenNM.ReadOnly = true;
            this.HoTenNM.Width = 150;
            // 
            // ThoiGianGiao
            // 
            this.ThoiGianGiao.DataPropertyName = "ThoiGianGiao";
            this.ThoiGianGiao.HeaderText = "Thời gian giao";
            this.ThoiGianGiao.Name = "ThoiGianGiao";
            this.ThoiGianGiao.ReadOnly = true;
            this.ThoiGianGiao.Width = 150;
            // 
            // LoiNhanCH
            // 
            this.LoiNhanCH.DataPropertyName = "LoiNhanCH";
            this.LoiNhanCH.HeaderText = "Lời nhắn tới cửa hàng";
            this.LoiNhanCH.Name = "LoiNhanCH";
            this.LoiNhanCH.ReadOnly = true;
            this.LoiNhanCH.Width = 200;
            // 
            // TinhTrang
            // 
            this.TinhTrang.DataPropertyName = "TinhTrangDH";
            this.TinhTrang.HeaderText = "Tình Trạng";
            this.TinhTrang.Name = "TinhTrang";
            this.TinhTrang.ReadOnly = true;
            this.TinhTrang.Width = 150;
            // 
            // NVCamHoa
            // 
            this.NVCamHoa.DataPropertyName = "NHANVIENCAMHOAMaNV";
            this.NVCamHoa.HeaderText = "NV Cắm Hoa";
            this.NVCamHoa.Name = "NVCamHoa";
            this.NVCamHoa.ReadOnly = true;
            this.NVCamHoa.Width = 120;
            // 
            // ChiNhanh
            // 
            this.ChiNhanh.DataPropertyName = "CHINHANHMaCN";
            this.ChiNhanh.HeaderText = "Chi Nhánh";
            this.ChiNhanh.Name = "ChiNhanh";
            this.ChiNhanh.ReadOnly = true;
            // 
            // CTDDH
            // 
            this.CTDDH.HeaderText = "Chi tiết";
            this.CTDDH.Name = "CTDDH";
            this.CTDDH.Text = "Xem chi tiết";
            this.CTDDH.UseColumnTextForButtonValue = true;
            this.CTDDH.Width = 120;
            // 
            // HienThiButton
            // 
            this.HienThiButton.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HienThiButton.Location = new System.Drawing.Point(961, 17);
            this.HienThiButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HienThiButton.Name = "HienThiButton";
            this.HienThiButton.Size = new System.Drawing.Size(223, 32);
            this.HienThiButton.TabIndex = 1;
            this.HienThiButton.Text = "Hiển thị đơn";
            this.HienThiButton.UseVisualStyleBackColor = true;
            this.HienThiButton.Click += new System.EventHandler(this.HienThiButton_Click);
            // 
            // FinishButton
            // 
            this.FinishButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FinishButton.Location = new System.Drawing.Point(640, 520);
            this.FinishButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FinishButton.Name = "FinishButton";
            this.FinishButton.Size = new System.Drawing.Size(150, 40);
            this.FinishButton.TabIndex = 5;
            this.FinishButton.Text = "Hoàn thành";
            this.FinishButton.UseVisualStyleBackColor = true;
            this.FinishButton.Click += new System.EventHandler(this.FinishButton_Click);
            // 
            // UnfinishButton
            // 
            this.UnfinishButton.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnfinishButton.Location = new System.Drawing.Point(640, 582);
            this.UnfinishButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UnfinishButton.Name = "UnfinishButton";
            this.UnfinishButton.Size = new System.Drawing.Size(150, 40);
            this.UnfinishButton.TabIndex = 9;
            this.UnfinishButton.Text = "Chưa hoàn thành";
            this.UnfinishButton.UseVisualStyleBackColor = true;
            this.UnfinishButton.Click += new System.EventHandler(this.UnfinishButton_Click);
            // 
            // NVCamHoaViewCT
            // 
            this.NVCamHoaViewCT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NVCamHoaViewCT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDDH_MuaSPQT,
            this.MaSP_MuaSPQT,
            this.Ten_MuaSPQT,
            this.SL_MuaSPQT});
            this.NVCamHoaViewCT.Location = new System.Drawing.Point(0, 420);
            this.NVCamHoaViewCT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NVCamHoaViewCT.Name = "NVCamHoaViewCT";
            this.NVCamHoaViewCT.Size = new System.Drawing.Size(594, 203);
            this.NVCamHoaViewCT.TabIndex = 10;
            // 
            // MaDDH_MuaSPQT
            // 
            this.MaDDH_MuaSPQT.DataPropertyName = "DONDATHANGMaDDH";
            this.MaDDH_MuaSPQT.HeaderText = "Mã đơn";
            this.MaDDH_MuaSPQT.Name = "MaDDH_MuaSPQT";
            this.MaDDH_MuaSPQT.ReadOnly = true;
            // 
            // MaSP_MuaSPQT
            // 
            this.MaSP_MuaSPQT.DataPropertyName = "SANPHAMQUATANGMaSPQT";
            this.MaSP_MuaSPQT.HeaderText = "Mã SP";
            this.MaSP_MuaSPQT.Name = "MaSP_MuaSPQT";
            this.MaSP_MuaSPQT.ReadOnly = true;
            // 
            // Ten_MuaSPQT
            // 
            this.Ten_MuaSPQT.DataPropertyName = "TenSPQT";
            this.Ten_MuaSPQT.HeaderText = "Tên SP";
            this.Ten_MuaSPQT.Name = "Ten_MuaSPQT";
            this.Ten_MuaSPQT.Width = 250;
            // 
            // SL_MuaSPQT
            // 
            this.SL_MuaSPQT.DataPropertyName = "SoLuong";
            this.SL_MuaSPQT.HeaderText = "Số lượng";
            this.SL_MuaSPQT.Name = "SL_MuaSPQT";
            this.SL_MuaSPQT.ReadOnly = true;
            // 
            // NVLabel
            // 
            this.NVLabel.AutoSize = true;
            this.NVLabel.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NVLabel.Location = new System.Drawing.Point(243, 26);
            this.NVLabel.Name = "NVLabel";
            this.NVLabel.Size = new System.Drawing.Size(72, 18);
            this.NVLabel.TabIndex = 13;
            this.NVLabel.Text = "Nhân viên:";
            // 
            // NvInput
            // 
            this.NvInput.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NvInput.Location = new System.Drawing.Point(319, 23);
            this.NvInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NvInput.Maximum = new decimal(new int[] {
            -402653185,
            -1613725636,
            54210108,
            0});
            this.NvInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NvInput.Name = "NvInput";
            this.NvInput.Size = new System.Drawing.Size(132, 25);
            this.NvInput.TabIndex = 14;
            this.toolTip1.SetToolTip(this.NvInput, "Hãy nhập mã nhân viên của bạn");
            this.NvInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // MaDdhHienTaiLabel
            // 
            this.MaDdhHienTaiLabel.AutoSize = true;
            this.MaDdhHienTaiLabel.Font = new System.Drawing.Font("Open Sans Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.MaDdhHienTaiLabel.Location = new System.Drawing.Point(635, 420);
            this.MaDdhHienTaiLabel.Name = "MaDdhHienTaiLabel";
            this.MaDdhHienTaiLabel.Size = new System.Drawing.Size(145, 28);
            this.MaDdhHienTaiLabel.TabIndex = 15;
            this.MaDdhHienTaiLabel.Text = "Đơn hiện tại: ";
            // 
            // TiepNhanButton
            // 
            this.TiepNhanButton.Location = new System.Drawing.Point(640, 460);
            this.TiepNhanButton.Name = "TiepNhanButton";
            this.TiepNhanButton.Size = new System.Drawing.Size(150, 40);
            this.TiepNhanButton.TabIndex = 16;
            this.TiepNhanButton.Text = "Tiếp nhận";
            this.TiepNhanButton.UseVisualStyleBackColor = true;
            this.TiepNhanButton.Click += new System.EventHandler(this.TiepNhanButton_Click);
            // 
            // CNLabel
            // 
            this.CNLabel.AutoSize = true;
            this.CNLabel.Location = new System.Drawing.Point(-2, 26);
            this.CNLabel.Name = "CNLabel";
            this.CNLabel.Size = new System.Drawing.Size(72, 18);
            this.CNLabel.TabIndex = 17;
            this.CNLabel.Text = "Chi nhánh:";
            // 
            // CnInput
            // 
            this.CnInput.Location = new System.Drawing.Point(77, 23);
            this.CnInput.Maximum = new decimal(new int[] {
            -402653185,
            -1613725636,
            54210108,
            0});
            this.CnInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CnInput.Name = "CnInput";
            this.CnInput.Size = new System.Drawing.Size(110, 25);
            this.CnInput.TabIndex = 18;
            this.toolTip1.SetToolTip(this.CnInput, "Hãy nhập chi nhánh của bạn");
            this.CnInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // LocTheoTinhTrangLabel
            // 
            this.LocTheoTinhTrangLabel.AutoSize = true;
            this.LocTheoTinhTrangLabel.Location = new System.Drawing.Point(490, 25);
            this.LocTheoTinhTrangLabel.Name = "LocTheoTinhTrangLabel";
            this.LocTheoTinhTrangLabel.Size = new System.Drawing.Size(125, 18);
            this.LocTheoTinhTrangLabel.TabIndex = 19;
            this.LocTheoTinhTrangLabel.Text = "Lọc theo tình trạng:";
            // 
            // TinhTrangCombobox
            // 
            this.TinhTrangCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TinhTrangCombobox.FormattingEnabled = true;
            this.TinhTrangCombobox.Items.AddRange(new object[] {
            "Đã tiếp nhận",
            "Đang cắm hoa",
            "Đã cắm xong",
            "Tất cả"});
            this.TinhTrangCombobox.Location = new System.Drawing.Point(621, 22);
            this.TinhTrangCombobox.Name = "TinhTrangCombobox";
            this.TinhTrangCombobox.Size = new System.Drawing.Size(121, 26);
            this.TinhTrangCombobox.TabIndex = 20;
            // 
            // nVCamHoaViewDonDatHangBindingSource
            // 
            this.nVCamHoaViewDonDatHangBindingSource.DataSource = typeof(HoaYeuThuong.NVCamHoaView_DonDatHang);
            // 
            // LMDForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 641);
            this.Controls.Add(this.TinhTrangCombobox);
            this.Controls.Add(this.LocTheoTinhTrangLabel);
            this.Controls.Add(this.CnInput);
            this.Controls.Add(this.CNLabel);
            this.Controls.Add(this.TiepNhanButton);
            this.Controls.Add(this.MaDdhHienTaiLabel);
            this.Controls.Add(this.NvInput);
            this.Controls.Add(this.NVLabel);
            this.Controls.Add(this.NVCamHoaViewCT);
            this.Controls.Add(this.UnfinishButton);
            this.Controls.Add(this.FinishButton);
            this.Controls.Add(this.HienThiButton);
            this.Controls.Add(this.NVCamHoaView);
            this.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "LMDForm";
            this.Text = "LMDForm";
            ((System.ComponentModel.ISupportInitialize)(this.NVCamHoaView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NVCamHoaViewCT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NvInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CnInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nVCamHoaViewDonDatHangBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView NVCamHoaView;
        private System.Windows.Forms.BindingSource nVCamHoaViewDonDatHangBindingSource;
        private System.Windows.Forms.Button HienThiButton;
        private System.Windows.Forms.Button FinishButton;
        private System.Windows.Forms.Button UnfinishButton;
        private System.Windows.Forms.DataGridView NVCamHoaViewCT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDDH_MuaSPQT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP_MuaSPQT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten_MuaSPQT;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL_MuaSPQT;
        private System.Windows.Forms.Label NVLabel;
        private System.Windows.Forms.NumericUpDown NvInput;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label MaDdhHienTaiLabel;
        private System.Windows.Forms.Button TiepNhanButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDDH;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTenNM;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGianGiao;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoiNhanCH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinhTrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn NVCamHoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChiNhanh;
        private System.Windows.Forms.DataGridViewButtonColumn CTDDH;
        private System.Windows.Forms.Label CNLabel;
        private System.Windows.Forms.NumericUpDown CnInput;
        private System.Windows.Forms.Label LocTheoTinhTrangLabel;
        private System.Windows.Forms.ComboBox TinhTrangCombobox;
    }
}