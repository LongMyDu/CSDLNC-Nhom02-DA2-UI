namespace HoaYeuThuong
{
    partial class Cart
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
            this.GioHangView = new System.Windows.Forms.DataGridView();
            this.maSPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenSPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaBanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaiSPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.XoaSP = new System.Windows.Forms.DataGridViewButtonColumn();
            this.sanPhamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DatHangButton = new System.Windows.Forms.Button();
            this.ThongTinLabel = new System.Windows.Forms.Label();
            this.HoTenNmInput = new System.Windows.Forms.TextBox();
            this.HoTenNmLabel = new System.Windows.Forms.Label();
            this.SdtNmLabel = new System.Windows.Forms.Label();
            this.SdtNmInput = new System.Windows.Forms.TextBox();
            this.EmailNmLabel = new System.Windows.Forms.Label();
            this.EmailNmInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.EmailNnLabel = new System.Windows.Forms.Label();
            this.SoNhaNnInput = new System.Windows.Forms.TextBox();
            this.SdtNnLabel = new System.Windows.Forms.Label();
            this.SdtNnInput = new System.Windows.Forms.TextBox();
            this.HoTenNnLabel = new System.Windows.Forms.Label();
            this.HoTenNnInput = new System.Windows.Forms.TextBox();
            this.DiaChiNmLabel = new System.Windows.Forms.Label();
            this.DiaChiNmInput = new System.Windows.Forms.TextBox();
            this.QuanNnLabel = new System.Windows.Forms.Label();
            this.QuanNnInput = new System.Windows.Forms.TextBox();
            this.ThanhPhoNnLabel = new System.Windows.Forms.Label();
            this.ThanhPhoNnInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ThoiGianGiaoInput = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.LoiNhanCHInput = new System.Windows.Forms.RichTextBox();
            this.LoiNhanNNInput = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.HinhThucTTInput = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.VoucherInput = new System.Windows.Forms.TextBox();
            this.PhiVCLabel = new System.Windows.Forms.Label();
            this.TongTienLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GioHangView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // GioHangView
            // 
            this.GioHangView.AllowUserToAddRows = false;
            this.GioHangView.AutoGenerateColumns = false;
            this.GioHangView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GioHangView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maSPDataGridViewTextBoxColumn,
            this.tenSPDataGridViewTextBoxColumn,
            this.giaBanDataGridViewTextBoxColumn,
            this.SL,
            this.loaiSPDataGridViewTextBoxColumn,
            this.XoaSP});
            this.GioHangView.DataSource = this.sanPhamBindingSource;
            this.GioHangView.Dock = System.Windows.Forms.DockStyle.Left;
            this.GioHangView.Location = new System.Drawing.Point(0, 0);
            this.GioHangView.Name = "GioHangView";
            this.GioHangView.Size = new System.Drawing.Size(454, 519);
            this.GioHangView.TabIndex = 0;
            this.GioHangView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GioHangView_CellContentClick);
            this.GioHangView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.GioHangView_CellValueChanged);
            // 
            // maSPDataGridViewTextBoxColumn
            // 
            this.maSPDataGridViewTextBoxColumn.DataPropertyName = "MaSP";
            this.maSPDataGridViewTextBoxColumn.HeaderText = "Mã SP";
            this.maSPDataGridViewTextBoxColumn.Name = "maSPDataGridViewTextBoxColumn";
            this.maSPDataGridViewTextBoxColumn.ReadOnly = true;
            this.maSPDataGridViewTextBoxColumn.Visible = false;
            // 
            // tenSPDataGridViewTextBoxColumn
            // 
            this.tenSPDataGridViewTextBoxColumn.DataPropertyName = "TenSP";
            this.tenSPDataGridViewTextBoxColumn.HeaderText = "Tên sản phẩm";
            this.tenSPDataGridViewTextBoxColumn.Name = "tenSPDataGridViewTextBoxColumn";
            this.tenSPDataGridViewTextBoxColumn.ReadOnly = true;
            this.tenSPDataGridViewTextBoxColumn.Width = 150;
            // 
            // giaBanDataGridViewTextBoxColumn
            // 
            this.giaBanDataGridViewTextBoxColumn.DataPropertyName = "GiaBan";
            this.giaBanDataGridViewTextBoxColumn.HeaderText = "Giá bán";
            this.giaBanDataGridViewTextBoxColumn.Name = "giaBanDataGridViewTextBoxColumn";
            this.giaBanDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // SL
            // 
            this.SL.HeaderText = "Số lượng";
            this.SL.Name = "SL";
            // 
            // loaiSPDataGridViewTextBoxColumn
            // 
            this.loaiSPDataGridViewTextBoxColumn.DataPropertyName = "LoaiSP";
            this.loaiSPDataGridViewTextBoxColumn.HeaderText = "Loại SP";
            this.loaiSPDataGridViewTextBoxColumn.Name = "loaiSPDataGridViewTextBoxColumn";
            this.loaiSPDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // XoaSP
            // 
            this.XoaSP.HeaderText = "Xóa";
            this.XoaSP.Name = "XoaSP";
            // 
            // sanPhamBindingSource
            // 
            this.sanPhamBindingSource.DataSource = typeof(HoaYeuThuong.SanPham);
            // 
            // DatHangButton
            // 
            this.DatHangButton.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatHangButton.Location = new System.Drawing.Point(938, 448);
            this.DatHangButton.Name = "DatHangButton";
            this.DatHangButton.Size = new System.Drawing.Size(248, 43);
            this.DatHangButton.TabIndex = 1;
            this.DatHangButton.Text = "Đặt hàng";
            this.DatHangButton.UseVisualStyleBackColor = true;
            this.DatHangButton.Click += new System.EventHandler(this.DatHangButton_Click);
            // 
            // ThongTinLabel
            // 
            this.ThongTinLabel.AutoSize = true;
            this.ThongTinLabel.Location = new System.Drawing.Point(460, 0);
            this.ThongTinLabel.Name = "ThongTinLabel";
            this.ThongTinLabel.Size = new System.Drawing.Size(57, 15);
            this.ThongTinLabel.TabIndex = 3;
            this.ThongTinLabel.Text = "Thông tin";
            // 
            // HoTenNmInput
            // 
            this.HoTenNmInput.Location = new System.Drawing.Point(596, 29);
            this.HoTenNmInput.Name = "HoTenNmInput";
            this.HoTenNmInput.Size = new System.Drawing.Size(221, 22);
            this.HoTenNmInput.TabIndex = 4;
            // 
            // HoTenNmLabel
            // 
            this.HoTenNmLabel.AutoSize = true;
            this.HoTenNmLabel.Location = new System.Drawing.Point(460, 31);
            this.HoTenNmLabel.Name = "HoTenNmLabel";
            this.HoTenNmLabel.Size = new System.Drawing.Size(107, 15);
            this.HoTenNmLabel.TabIndex = 5;
            this.HoTenNmLabel.Text = "Họ tên người mua*";
            // 
            // SdtNmLabel
            // 
            this.SdtNmLabel.AutoSize = true;
            this.SdtNmLabel.Location = new System.Drawing.Point(460, 71);
            this.SdtNmLabel.Name = "SdtNmLabel";
            this.SdtNmLabel.Size = new System.Drawing.Size(92, 15);
            this.SdtNmLabel.TabIndex = 7;
            this.SdtNmLabel.Text = "SĐT người mua*";
            // 
            // SdtNmInput
            // 
            this.SdtNmInput.Location = new System.Drawing.Point(596, 69);
            this.SdtNmInput.Name = "SdtNmInput";
            this.SdtNmInput.Size = new System.Drawing.Size(221, 22);
            this.SdtNmInput.TabIndex = 6;
            // 
            // EmailNmLabel
            // 
            this.EmailNmLabel.AutoSize = true;
            this.EmailNmLabel.Location = new System.Drawing.Point(460, 112);
            this.EmailNmLabel.Name = "EmailNmLabel";
            this.EmailNmLabel.Size = new System.Drawing.Size(100, 15);
            this.EmailNmLabel.TabIndex = 9;
            this.EmailNmLabel.Text = "Email người mua*";
            // 
            // EmailNmInput
            // 
            this.EmailNmInput.Location = new System.Drawing.Point(596, 110);
            this.EmailNmInput.Name = "EmailNmInput";
            this.EmailNmInput.Size = new System.Drawing.Size(221, 22);
            this.EmailNmInput.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(854, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Gửi tặng đến";
            // 
            // EmailNnLabel
            // 
            this.EmailNnLabel.AutoSize = true;
            this.EmailNnLabel.Location = new System.Drawing.Point(854, 110);
            this.EmailNnLabel.Name = "EmailNnLabel";
            this.EmailNnLabel.Size = new System.Drawing.Size(95, 15);
            this.EmailNnLabel.TabIndex = 18;
            this.EmailNnLabel.Text = "Số nhà + đường*";
            // 
            // SoNhaNnInput
            // 
            this.SoNhaNnInput.Location = new System.Drawing.Point(971, 109);
            this.SoNhaNnInput.Name = "SoNhaNnInput";
            this.SoNhaNnInput.Size = new System.Drawing.Size(221, 22);
            this.SoNhaNnInput.TabIndex = 17;
            // 
            // SdtNnLabel
            // 
            this.SdtNnLabel.AutoSize = true;
            this.SdtNnLabel.Location = new System.Drawing.Point(854, 69);
            this.SdtNnLabel.Name = "SdtNnLabel";
            this.SdtNnLabel.Size = new System.Drawing.Size(96, 15);
            this.SdtNnLabel.TabIndex = 16;
            this.SdtNnLabel.Text = "SĐT người nhận*";
            // 
            // SdtNnInput
            // 
            this.SdtNnInput.Location = new System.Drawing.Point(971, 68);
            this.SdtNnInput.Name = "SdtNnInput";
            this.SdtNnInput.Size = new System.Drawing.Size(221, 22);
            this.SdtNnInput.TabIndex = 15;
            // 
            // HoTenNnLabel
            // 
            this.HoTenNnLabel.AutoSize = true;
            this.HoTenNnLabel.Location = new System.Drawing.Point(854, 29);
            this.HoTenNnLabel.Name = "HoTenNnLabel";
            this.HoTenNnLabel.Size = new System.Drawing.Size(111, 15);
            this.HoTenNnLabel.TabIndex = 14;
            this.HoTenNnLabel.Text = "Họ tên người nhận*";
            // 
            // HoTenNnInput
            // 
            this.HoTenNnInput.Location = new System.Drawing.Point(971, 28);
            this.HoTenNnInput.Name = "HoTenNnInput";
            this.HoTenNnInput.Size = new System.Drawing.Size(221, 22);
            this.HoTenNnInput.TabIndex = 13;
            // 
            // DiaChiNmLabel
            // 
            this.DiaChiNmLabel.AutoSize = true;
            this.DiaChiNmLabel.Location = new System.Drawing.Point(460, 154);
            this.DiaChiNmLabel.Name = "DiaChiNmLabel";
            this.DiaChiNmLabel.Size = new System.Drawing.Size(107, 15);
            this.DiaChiNmLabel.TabIndex = 20;
            this.DiaChiNmLabel.Text = "Địa chỉ người mua*";
            // 
            // DiaChiNmInput
            // 
            this.DiaChiNmInput.Location = new System.Drawing.Point(596, 152);
            this.DiaChiNmInput.Name = "DiaChiNmInput";
            this.DiaChiNmInput.Size = new System.Drawing.Size(221, 22);
            this.DiaChiNmInput.TabIndex = 19;
            // 
            // QuanNnLabel
            // 
            this.QuanNnLabel.AutoSize = true;
            this.QuanNnLabel.Location = new System.Drawing.Point(854, 151);
            this.QuanNnLabel.Name = "QuanNnLabel";
            this.QuanNnLabel.Size = new System.Drawing.Size(42, 15);
            this.QuanNnLabel.TabIndex = 22;
            this.QuanNnLabel.Text = "Quận*";
            // 
            // QuanNnInput
            // 
            this.QuanNnInput.Location = new System.Drawing.Point(971, 150);
            this.QuanNnInput.Name = "QuanNnInput";
            this.QuanNnInput.Size = new System.Drawing.Size(221, 22);
            this.QuanNnInput.TabIndex = 21;
            // 
            // ThanhPhoNnLabel
            // 
            this.ThanhPhoNnLabel.AutoSize = true;
            this.ThanhPhoNnLabel.Location = new System.Drawing.Point(854, 191);
            this.ThanhPhoNnLabel.Name = "ThanhPhoNnLabel";
            this.ThanhPhoNnLabel.Size = new System.Drawing.Size(70, 15);
            this.ThanhPhoNnLabel.TabIndex = 24;
            this.ThanhPhoNnLabel.Text = "Thành phố*";
            // 
            // ThanhPhoNnInput
            // 
            this.ThanhPhoNnInput.Location = new System.Drawing.Point(971, 190);
            this.ThanhPhoNnInput.Name = "ThanhPhoNnInput";
            this.ThanhPhoNnInput.Size = new System.Drawing.Size(221, 22);
            this.ThanhPhoNnInput.TabIndex = 23;
            this.ThanhPhoNnInput.Leave += new System.EventHandler(this.ThanhPhoNnInput_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(854, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 15);
            this.label2.TabIndex = 26;
            this.label2.Text = "Thời gian giao*";
            // 
            // ThoiGianGiaoInput
            // 
            this.ThoiGianGiaoInput.Location = new System.Drawing.Point(971, 232);
            this.ThoiGianGiaoInput.Mask = "00/00/0000 90:00";
            this.ThoiGianGiaoInput.Name = "ThoiGianGiaoInput";
            this.ThoiGianGiaoInput.Size = new System.Drawing.Size(221, 22);
            this.ThoiGianGiaoInput.TabIndex = 27;
            this.ThoiGianGiaoInput.Text = "241220210000";
            this.ThoiGianGiaoInput.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(460, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 96);
            this.label4.TabIndex = 29;
            this.label4.Text = "Lời nhắn tới cửa hàng";
            // 
            // LoiNhanCHInput
            // 
            this.LoiNhanCHInput.Location = new System.Drawing.Point(596, 279);
            this.LoiNhanCHInput.Name = "LoiNhanCHInput";
            this.LoiNhanCHInput.Size = new System.Drawing.Size(221, 96);
            this.LoiNhanCHInput.TabIndex = 30;
            this.LoiNhanCHInput.Text = "";
            // 
            // LoiNhanNNInput
            // 
            this.LoiNhanNNInput.Location = new System.Drawing.Point(971, 281);
            this.LoiNhanNNInput.Name = "LoiNhanNNInput";
            this.LoiNhanNNInput.Size = new System.Drawing.Size(221, 96);
            this.LoiNhanNNInput.TabIndex = 32;
            this.LoiNhanNNInput.Text = "";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(854, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 96);
            this.label5.TabIndex = 31;
            this.label5.Text = "Lời nhắn tới người nhận";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(460, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 24);
            this.label6.TabIndex = 33;
            this.label6.Text = "Hình thức thanh toán";
            // 
            // HinhThucTTInput
            // 
            this.HinhThucTTInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HinhThucTTInput.FormattingEnabled = true;
            this.HinhThucTTInput.Items.AddRange(new object[] {
            "Tiền mặt",
            "Thẻ thanh toán quốc tế",
            "Thẻ ATM nội địa",
            "PayPal",
            "Ví điện tử"});
            this.HinhThucTTInput.Location = new System.Drawing.Point(596, 196);
            this.HinhThucTTInput.Name = "HinhThucTTInput";
            this.HinhThucTTInput.Size = new System.Drawing.Size(221, 23);
            this.HinhThucTTInput.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(460, 233);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 24);
            this.label7.TabIndex = 35;
            this.label7.Text = "Voucher";
            // 
            // VoucherInput
            // 
            this.VoucherInput.Location = new System.Drawing.Point(596, 235);
            this.VoucherInput.Name = "VoucherInput";
            this.VoucherInput.Size = new System.Drawing.Size(221, 22);
            this.VoucherInput.TabIndex = 36;
            // 
            // PhiVCLabel
            // 
            this.PhiVCLabel.Font = new System.Drawing.Font("Open Sans Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhiVCLabel.Location = new System.Drawing.Point(460, 408);
            this.PhiVCLabel.Name = "PhiVCLabel";
            this.PhiVCLabel.Size = new System.Drawing.Size(240, 29);
            this.PhiVCLabel.TabIndex = 37;
            this.PhiVCLabel.Text = "Phí vận chuyển: ";
            // 
            // TongTienLabel
            // 
            this.TongTienLabel.Font = new System.Drawing.Font("Open Sans Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TongTienLabel.Location = new System.Drawing.Point(460, 462);
            this.TongTienLabel.Name = "TongTienLabel";
            this.TongTienLabel.Size = new System.Drawing.Size(240, 29);
            this.TongTienLabel.TabIndex = 38;
            this.TongTienLabel.Text = "Tổng tiền:";
            // 
            // Cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 519);
            this.Controls.Add(this.TongTienLabel);
            this.Controls.Add(this.PhiVCLabel);
            this.Controls.Add(this.VoucherInput);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.HinhThucTTInput);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LoiNhanNNInput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LoiNhanCHInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ThoiGianGiaoInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ThanhPhoNnLabel);
            this.Controls.Add(this.ThanhPhoNnInput);
            this.Controls.Add(this.QuanNnLabel);
            this.Controls.Add(this.QuanNnInput);
            this.Controls.Add(this.DiaChiNmLabel);
            this.Controls.Add(this.DiaChiNmInput);
            this.Controls.Add(this.EmailNnLabel);
            this.Controls.Add(this.SoNhaNnInput);
            this.Controls.Add(this.SdtNnLabel);
            this.Controls.Add(this.SdtNnInput);
            this.Controls.Add(this.HoTenNnLabel);
            this.Controls.Add(this.HoTenNnInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EmailNmLabel);
            this.Controls.Add(this.EmailNmInput);
            this.Controls.Add(this.SdtNmLabel);
            this.Controls.Add(this.SdtNmInput);
            this.Controls.Add(this.HoTenNmLabel);
            this.Controls.Add(this.HoTenNmInput);
            this.Controls.Add(this.ThongTinLabel);
            this.Controls.Add(this.DatHangButton);
            this.Controls.Add(this.GioHangView);
            this.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Cart";
            this.Text = "Cart";
            this.Load += new System.EventHandler(this.Cart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GioHangView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GioHangView;
        private System.Windows.Forms.Button DatHangButton;
        private System.Windows.Forms.Label ThongTinLabel;
        private System.Windows.Forms.TextBox HoTenNmInput;
        private System.Windows.Forms.Label HoTenNmLabel;
        private System.Windows.Forms.Label SdtNmLabel;
        private System.Windows.Forms.TextBox SdtNmInput;
        private System.Windows.Forms.Label EmailNmLabel;
        private System.Windows.Forms.TextBox EmailNmInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label EmailNnLabel;
        private System.Windows.Forms.TextBox SoNhaNnInput;
        private System.Windows.Forms.Label SdtNnLabel;
        private System.Windows.Forms.TextBox SdtNnInput;
        private System.Windows.Forms.Label HoTenNnLabel;
        private System.Windows.Forms.TextBox HoTenNnInput;
        private System.Windows.Forms.Label DiaChiNmLabel;
        private System.Windows.Forms.TextBox DiaChiNmInput;
        private System.Windows.Forms.Label QuanNnLabel;
        private System.Windows.Forms.TextBox QuanNnInput;
        private System.Windows.Forms.Label ThanhPhoNnLabel;
        private System.Windows.Forms.TextBox ThanhPhoNnInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox ThoiGianGiaoInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox LoiNhanCHInput;
        private System.Windows.Forms.RichTextBox LoiNhanNNInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox HinhThucTTInput;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox VoucherInput;
        private System.Windows.Forms.Label PhiVCLabel;
        private System.Windows.Forms.Label TongTienLabel;
        private System.Windows.Forms.BindingSource sanPhamBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaBanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaiSPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn XoaSP;
    }
}