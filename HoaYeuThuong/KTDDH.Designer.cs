namespace HoaYeuThuong
{
    partial class KTDDH_Form
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MaDDH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTenNM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGianGiao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoiNhanCH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NVCamHoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NVGiaoHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(114, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(536, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "MA DDH";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(685, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "SEARCH";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDDH,
            this.HoTenNM,
            this.ThoiGianGiao,
            this.LoiNhanCH,
            this.TinhTrang,
            this.NVCamHoa,
            this.NVGiaoHang});
            this.dataGridView1.Location = new System.Drawing.Point(31, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(729, 241);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // MaDDH
            // 
            this.MaDDH.HeaderText = "MaDDH";
            this.MaDDH.Name = "MaDDH";
            this.MaDDH.ReadOnly = true;
            // 
            // HoTenNM
            // 
            this.HoTenNM.HeaderText = "HoTenNM";
            this.HoTenNM.Name = "HoTenNM";
            this.HoTenNM.ReadOnly = true;
            // 
            // ThoiGianGiao
            // 
            this.ThoiGianGiao.HeaderText = "ThoiGianGiao";
            this.ThoiGianGiao.Name = "ThoiGianGiao";
            this.ThoiGianGiao.ReadOnly = true;
            // 
            // LoiNhanCH
            // 
            this.LoiNhanCH.HeaderText = "LoiNhanCH";
            this.LoiNhanCH.Name = "LoiNhanCH";
            this.LoiNhanCH.ReadOnly = true;
            // 
            // TinhTrang
            // 
            this.TinhTrang.HeaderText = "TinhTrang";
            this.TinhTrang.Name = "TinhTrang";
            this.TinhTrang.ReadOnly = true;
            // 
            // NVCamHoa
            // 
            this.NVCamHoa.HeaderText = "NVCamHoa";
            this.NVCamHoa.Name = "NVCamHoa";
            this.NVCamHoa.ReadOnly = true;
            // 
            // NVGiaoHang
            // 
            this.NVGiaoHang.HeaderText = "NVGiaoHang";
            this.NVGiaoHang.Name = "NVGiaoHang";
            this.NVGiaoHang.ReadOnly = true;
            // 
            // KTDDH_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 336);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "KTDDH_Form";
            this.Text = "KTDDH";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDDH;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTenNM;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGianGiao;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoiNhanCH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinhTrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn NVCamHoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn NVGiaoHang;
    }
}