namespace HoaYeuThuong
{
    partial class SearchHT
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grdData = new System.Windows.Forms.DataGridView();
            this.SearchBar = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.ColorFilter = new System.Windows.Forms.ComboBox();
            this.MoneyFrom = new System.Windows.Forms.ComboBox();
            this.MoneyTo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MaHT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YNghiaHT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaBanSauGiam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddToCartButton = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).BeginInit();
            this.SuspendLayout();
            // 
            // grdData
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHT,
            this.TenHT,
            this.YNghiaHT,
            this.GiaBan,
            this.GiaBanSauGiam,
            this.TenMau,
            this.AddToCartButton});
            this.grdData.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grdData.Location = new System.Drawing.Point(0, 161);
            this.grdData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grdData.Name = "grdData";
            this.grdData.RowHeadersWidth = 51;
            this.grdData.RowTemplate.Height = 24;
            this.grdData.Size = new System.Drawing.Size(1284, 447);
            this.grdData.TabIndex = 1;
            this.grdData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdData_CellContentClick);
            // 
            // SearchBar
            // 
            this.SearchBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBar.Location = new System.Drawing.Point(27, 30);
            this.SearchBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchBar.Name = "SearchBar";
            this.SearchBar.Size = new System.Drawing.Size(1137, 23);
            this.SearchBar.TabIndex = 4;
            this.SearchBar.TextChanged += new System.EventHandler(this.SearchBar_TextChanged);
            // 
            // SearchButton
            // 
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.Location = new System.Drawing.Point(1171, 30);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(99, 27);
            this.SearchButton.TabIndex = 5;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // ColorFilter
            // 
            this.ColorFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColorFilter.FormattingEnabled = true;
            this.ColorFilter.Location = new System.Drawing.Point(128, 75);
            this.ColorFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ColorFilter.Name = "ColorFilter";
            this.ColorFilter.Size = new System.Drawing.Size(123, 25);
            this.ColorFilter.TabIndex = 6;
            this.ColorFilter.SelectedIndexChanged += new System.EventHandler(this.ColorFilter_SelectedIndexChanged);
            // 
            // MoneyFrom
            // 
            this.MoneyFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoneyFrom.FormattingEnabled = true;
            this.MoneyFrom.Location = new System.Drawing.Point(487, 75);
            this.MoneyFrom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MoneyFrom.Name = "MoneyFrom";
            this.MoneyFrom.Size = new System.Drawing.Size(161, 25);
            this.MoneyFrom.TabIndex = 8;
            this.MoneyFrom.SelectedIndexChanged += new System.EventHandler(this.MoneyFrom_SelectedIndexChanged);
            // 
            // MoneyTo
            // 
            this.MoneyTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoneyTo.FormattingEnabled = true;
            this.MoneyTo.Location = new System.Drawing.Point(655, 75);
            this.MoneyTo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MoneyTo.Name = "MoneyTo";
            this.MoneyTo.Size = new System.Drawing.Size(161, 25);
            this.MoneyTo.TabIndex = 9;
            this.MoneyTo.SelectedIndexChanged += new System.EventHandler(this.MoneyTo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Lọc sản phẩm";
            // 
            // MaHT
            // 
            this.MaHT.HeaderText = "Mã HT";
            this.MaHT.MinimumWidth = 6;
            this.MaHT.Name = "MaHT";
            this.MaHT.Width = 125;
            // 
            // TenHT
            // 
            this.TenHT.HeaderText = "Tên";
            this.TenHT.MinimumWidth = 6;
            this.TenHT.Name = "TenHT";
            this.TenHT.Width = 175;
            // 
            // YNghiaHT
            // 
            this.YNghiaHT.HeaderText = "Ý nghĩa";
            this.YNghiaHT.MinimumWidth = 6;
            this.YNghiaHT.Name = "YNghiaHT";
            this.YNghiaHT.Width = 250;
            // 
            // GiaBan
            // 
            this.GiaBan.HeaderText = "Giá gốc";
            this.GiaBan.MinimumWidth = 6;
            this.GiaBan.Name = "GiaBan";
            this.GiaBan.Width = 125;
            // 
            // GiaBanSauGiam
            // 
            this.GiaBanSauGiam.HeaderText = "Giá đã giảm";
            this.GiaBanSauGiam.MinimumWidth = 6;
            this.GiaBanSauGiam.Name = "GiaBanSauGiam";
            this.GiaBanSauGiam.Width = 125;
            // 
            // TenMau
            // 
            this.TenMau.HeaderText = "Màu sắc";
            this.TenMau.MinimumWidth = 6;
            this.TenMau.Name = "TenMau";
            this.TenMau.Width = 125;
            // 
            // AddToCartButton
            // 
            this.AddToCartButton.HeaderText = "Add to cart";
            this.AddToCartButton.MinimumWidth = 6;
            this.AddToCartButton.Name = "AddToCartButton";
            this.AddToCartButton.Text = "Add to cart";
            this.AddToCartButton.UseColumnTextForButtonValue = true;
            this.AddToCartButton.Width = 125;
            // 
            // SearchHT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 608);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MoneyTo);
            this.Controls.Add(this.MoneyFrom);
            this.Controls.Add(this.ColorFilter);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchBar);
            this.Controls.Add(this.grdData);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SearchHT";
            this.Text = "SearchHT";
            this.Load += new System.EventHandler(this.GQForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView grdData;
        private System.Windows.Forms.TextBox SearchBar;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.ComboBox ColorFilter;
        private System.Windows.Forms.ComboBox MoneyFrom;
        private System.Windows.Forms.ComboBox MoneyTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHT;
        private System.Windows.Forms.DataGridViewTextBoxColumn YNghiaHT;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaBanSauGiam;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMau;
        private System.Windows.Forms.DataGridViewButtonColumn AddToCartButton;
    }
}