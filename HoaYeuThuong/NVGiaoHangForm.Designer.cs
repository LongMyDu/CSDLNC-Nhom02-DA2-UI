namespace HoaYeuThuong
{
    partial class NVGiaoHangForm
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
            this.NVGiaoHang = new System.Windows.Forms.Label();
            this.NVGHInput = new System.Windows.Forms.NumericUpDown();
            this.LTTTLabel = new System.Windows.Forms.Label();
            this.LTTTComboBox = new System.Windows.Forms.ComboBox();
            this.HienThiButton = new System.Windows.Forms.Button();
            this.NVGiaoHangView = new System.Windows.Forms.DataGridView();
            this.CNInput = new System.Windows.Forms.Label();
            this.LTCNComboBox = new System.Windows.Forms.ComboBox();
            this.DonHienTaiLabel = new System.Windows.Forms.Label();
            this.DangGiaoButton = new System.Windows.Forms.Button();
            this.DaGiaoButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NVGHInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NVGiaoHangView)).BeginInit();
            this.SuspendLayout();
            // 
            // NVGiaoHang
            // 
            this.NVGiaoHang.AutoSize = true;
            this.NVGiaoHang.Location = new System.Drawing.Point(34, 56);
            this.NVGiaoHang.Name = "NVGiaoHang";
            this.NVGiaoHang.Size = new System.Drawing.Size(210, 25);
            this.NVGiaoHang.TabIndex = 0;
            this.NVGiaoHang.Text = "Nhân viên giao hàng";
            // 
            // NVGHInput
            // 
            this.NVGHInput.Location = new System.Drawing.Point(266, 56);
            this.NVGHInput.Name = "NVGHInput";
            this.NVGHInput.Size = new System.Drawing.Size(120, 31);
            this.NVGHInput.TabIndex = 1;
            // 
            // LTTTLabel
            // 
            this.LTTTLabel.AutoSize = true;
            this.LTTTLabel.Location = new System.Drawing.Point(456, 56);
            this.LTTTLabel.Name = "LTTTLabel";
            this.LTTTLabel.Size = new System.Drawing.Size(191, 25);
            this.LTTTLabel.TabIndex = 2;
            this.LTTTLabel.Text = "Lọc theo tình trạng";
            // 
            // LTTTComboBox
            // 
            this.LTTTComboBox.FormattingEnabled = true;
            this.LTTTComboBox.Items.AddRange(new object[] {
            "Tất cả",
            "Đã tiếp nhận",
            "Đang cắm hoa",
            "Đã cắm xong",
            "Đang giao hàng",
            "Giao hàng thành công"});
            this.LTTTComboBox.Location = new System.Drawing.Point(670, 53);
            this.LTTTComboBox.Name = "LTTTComboBox";
            this.LTTTComboBox.Size = new System.Drawing.Size(121, 33);
            this.LTTTComboBox.TabIndex = 3;
            // 
            // HienThiButton
            // 
            this.HienThiButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HienThiButton.Location = new System.Drawing.Point(1322, 33);
            this.HienThiButton.Name = "HienThiButton";
            this.HienThiButton.Size = new System.Drawing.Size(173, 63);
            this.HienThiButton.TabIndex = 4;
            this.HienThiButton.Text = "Hiển thị";
            this.HienThiButton.UseVisualStyleBackColor = true;
            this.HienThiButton.Click += new System.EventHandler(this.HienThiButton_Click);
            // 
            // NVGiaoHangView
            // 
            this.NVGiaoHangView.AllowUserToAddRows = false;
            this.NVGiaoHangView.AllowUserToDeleteRows = false;
            this.NVGiaoHangView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NVGiaoHangView.Location = new System.Drawing.Point(39, 154);
            this.NVGiaoHangView.Name = "NVGiaoHangView";
            this.NVGiaoHangView.ReadOnly = true;
            this.NVGiaoHangView.RowHeadersWidth = 82;
            this.NVGiaoHangView.RowTemplate.Height = 33;
            this.NVGiaoHangView.Size = new System.Drawing.Size(1456, 252);
            this.NVGiaoHangView.TabIndex = 5;
            this.NVGiaoHangView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.NVGiaoHangView_CellContentClick);
            // 
            // CNInput
            // 
            this.CNInput.AutoSize = true;
            this.CNInput.Location = new System.Drawing.Point(854, 56);
            this.CNInput.Name = "CNInput";
            this.CNInput.Size = new System.Drawing.Size(195, 25);
            this.CNInput.TabIndex = 6;
            this.CNInput.Text = "Lọc theo chi nhánh";
            // 
            // LTCNComboBox
            // 
            this.LTCNComboBox.FormattingEnabled = true;
            this.LTCNComboBox.Items.AddRange(new object[] {
            "Tất cả",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.LTCNComboBox.Location = new System.Drawing.Point(1070, 53);
            this.LTCNComboBox.Name = "LTCNComboBox";
            this.LTCNComboBox.Size = new System.Drawing.Size(121, 33);
            this.LTCNComboBox.TabIndex = 7;
            // 
            // DonHienTaiLabel
            // 
            this.DonHienTaiLabel.AutoSize = true;
            this.DonHienTaiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DonHienTaiLabel.Location = new System.Drawing.Point(84, 446);
            this.DonHienTaiLabel.Name = "DonHienTaiLabel";
            this.DonHienTaiLabel.Size = new System.Drawing.Size(217, 42);
            this.DonHienTaiLabel.TabIndex = 8;
            this.DonHienTaiLabel.Text = "Đơn hiện tại";
            // 
            // DangGiaoButton
            // 
            this.DangGiaoButton.Location = new System.Drawing.Point(988, 452);
            this.DangGiaoButton.Name = "DangGiaoButton";
            this.DangGiaoButton.Size = new System.Drawing.Size(184, 42);
            this.DangGiaoButton.TabIndex = 9;
            this.DangGiaoButton.Text = "Đang giao";
            this.DangGiaoButton.UseVisualStyleBackColor = true;
            this.DangGiaoButton.Click += new System.EventHandler(this.DangGiaoButton_Click);
            // 
            // DaGiaoButton
            // 
            this.DaGiaoButton.Location = new System.Drawing.Point(1227, 452);
            this.DaGiaoButton.Name = "DaGiaoButton";
            this.DaGiaoButton.Size = new System.Drawing.Size(184, 42);
            this.DaGiaoButton.TabIndex = 10;
            this.DaGiaoButton.Text = "Đã giao";
            this.DaGiaoButton.UseVisualStyleBackColor = true;
            this.DaGiaoButton.Click += new System.EventHandler(this.DaGiaoButton_Click);
            // 
            // NVGiaoHangForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1550, 924);
            this.Controls.Add(this.DaGiaoButton);
            this.Controls.Add(this.DangGiaoButton);
            this.Controls.Add(this.DonHienTaiLabel);
            this.Controls.Add(this.LTCNComboBox);
            this.Controls.Add(this.CNInput);
            this.Controls.Add(this.NVGiaoHangView);
            this.Controls.Add(this.HienThiButton);
            this.Controls.Add(this.LTTTComboBox);
            this.Controls.Add(this.LTTTLabel);
            this.Controls.Add(this.NVGHInput);
            this.Controls.Add(this.NVGiaoHang);
            this.Name = "NVGiaoHangForm";
            this.Text = "NVGiaoHang";
            ((System.ComponentModel.ISupportInitialize)(this.NVGHInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NVGiaoHangView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NVGiaoHang;
        private System.Windows.Forms.NumericUpDown NVGHInput;
        private System.Windows.Forms.Label LTTTLabel;
        private System.Windows.Forms.ComboBox LTTTComboBox;
        private System.Windows.Forms.Button HienThiButton;
        private System.Windows.Forms.DataGridView NVGiaoHangView;
        private System.Windows.Forms.Label CNInput;
        private System.Windows.Forms.ComboBox LTCNComboBox;
        private System.Windows.Forms.Label DonHienTaiLabel;
        private System.Windows.Forms.Button DangGiaoButton;
        private System.Windows.Forms.Button DaGiaoButton;
    }
}