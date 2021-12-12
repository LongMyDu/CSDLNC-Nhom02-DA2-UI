namespace HoaYeuThuong
{
    partial class MainForm
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
            this.GoToSPQT = new System.Windows.Forms.Button();
            this.ViewCartButton = new System.Windows.Forms.Button();
            this.GoToSPMK = new System.Windows.Forms.Button();
            this.GoToHT = new System.Windows.Forms.Button();
            this.HoaYeuThuongLabel = new System.Windows.Forms.Label();
            this.GoToNVCamHoa = new System.Windows.Forms.Button();
            this.GoToNVGiaoHang = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GoToSPQT
            // 
            this.GoToSPQT.Location = new System.Drawing.Point(23, 157);
            this.GoToSPQT.Name = "GoToSPQT";
            this.GoToSPQT.Size = new System.Drawing.Size(174, 23);
            this.GoToSPQT.TabIndex = 0;
            this.GoToSPQT.Text = "Tìm sản phẩm";
            this.GoToSPQT.UseVisualStyleBackColor = true;
            this.GoToSPQT.Click += new System.EventHandler(this.GoToSPQT_Click);
            // 
            // ViewCartButton
            // 
            this.ViewCartButton.Location = new System.Drawing.Point(612, 157);
            this.ViewCartButton.Name = "ViewCartButton";
            this.ViewCartButton.Size = new System.Drawing.Size(174, 23);
            this.ViewCartButton.TabIndex = 1;
            this.ViewCartButton.Text = "Xem giỏ hàng";
            this.ViewCartButton.UseVisualStyleBackColor = true;
            this.ViewCartButton.Click += new System.EventHandler(this.ViewCartButton_Click);
            // 
            // GoToSPMK
            // 
            this.GoToSPMK.Location = new System.Drawing.Point(223, 157);
            this.GoToSPMK.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.GoToSPMK.Name = "GoToSPMK";
            this.GoToSPMK.Size = new System.Drawing.Size(174, 23);
            this.GoToSPMK.TabIndex = 2;
            this.GoToSPMK.Text = "Tìm sản phẩm mua kèm";
            this.GoToSPMK.UseVisualStyleBackColor = true;
            this.GoToSPMK.Click += new System.EventHandler(this.GoToSPMK_Click);
            // 
            // GoToHT
            // 
            this.GoToHT.Location = new System.Drawing.Point(418, 157);
            this.GoToHT.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.GoToHT.Name = "GoToHT";
            this.GoToHT.Size = new System.Drawing.Size(174, 23);
            this.GoToHT.TabIndex = 3;
            this.GoToHT.Text = "Tìm hoa tươi";
            this.GoToHT.UseVisualStyleBackColor = true;
            this.GoToHT.Click += new System.EventHandler(this.GoToHT_Click);
            // 
            // HoaYeuThuongLabel
            // 
            this.HoaYeuThuongLabel.AutoSize = true;
            this.HoaYeuThuongLabel.Font = new System.Drawing.Font("Segoe Print", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoaYeuThuongLabel.Location = new System.Drawing.Point(188, 19);
            this.HoaYeuThuongLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HoaYeuThuongLabel.Name = "HoaYeuThuongLabel";
            this.HoaYeuThuongLabel.Size = new System.Drawing.Size(431, 84);
            this.HoaYeuThuongLabel.TabIndex = 4;
            this.HoaYeuThuongLabel.Text = "Hoa Yeu Thuong";
            this.HoaYeuThuongLabel.Click += new System.EventHandler(this.HoaYeuThuongLabel_Click);
            // 
            // GoToNVCamHoa
            // 
            this.GoToNVCamHoa.Location = new System.Drawing.Point(23, 211);
            this.GoToNVCamHoa.Margin = new System.Windows.Forms.Padding(2);
            this.GoToNVCamHoa.Name = "GoToNVCamHoa";
            this.GoToNVCamHoa.Size = new System.Drawing.Size(260, 21);
            this.GoToNVCamHoa.TabIndex = 5;
            this.GoToNVCamHoa.Text = "[NV Cắm hoa] Quản lý đơn hàng";
            this.GoToNVCamHoa.UseVisualStyleBackColor = true;
            this.GoToNVCamHoa.Click += new System.EventHandler(this.GoToNVCamHoa_Click);
            // 
            // GoToNVGiaoHang
            // 
            this.GoToNVGiaoHang.Location = new System.Drawing.Point(323, 211);
            this.GoToNVGiaoHang.Margin = new System.Windows.Forms.Padding(2);
            this.GoToNVGiaoHang.Name = "GoToNVGiaoHang";
            this.GoToNVGiaoHang.Size = new System.Drawing.Size(251, 21);
            this.GoToNVGiaoHang.TabIndex = 6;
            this.GoToNVGiaoHang.Text = "[NV Giao Hàng] Quản lý đơn hàng";
            this.GoToNVGiaoHang.UseVisualStyleBackColor = true;
            this.GoToNVGiaoHang.Click += new System.EventHandler(this.GoToNVGiaoHang_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(612, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(198, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "kiểm tra trạng thái đơn hàng";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 429);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.GoToNVGiaoHang);
            this.Controls.Add(this.GoToNVCamHoa);
            this.Controls.Add(this.HoaYeuThuongLabel);
            this.Controls.Add(this.GoToHT);
            this.Controls.Add(this.GoToSPMK);
            this.Controls.Add(this.ViewCartButton);
            this.Controls.Add(this.GoToSPQT);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GoToSPQT;
        private System.Windows.Forms.Button ViewCartButton;
        private System.Windows.Forms.Button GoToSPMK;
        private System.Windows.Forms.Button GoToHT;
        private System.Windows.Forms.Label HoaYeuThuongLabel;
        private System.Windows.Forms.Button GoToNVCamHoa;
        private System.Windows.Forms.Button GoToNVGiaoHang;
        private System.Windows.Forms.Button button1;
    }
}