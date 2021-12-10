namespace HoaYeuThuong
{
    partial class SearchSPQT
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
            this.grdData = new System.Windows.Forms.DataGridView();
            this.MaSPQT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSPQT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChuDe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MieuTaSPQT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaBanSauGiam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddToCartButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.SearchBar = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.ColorFilter = new System.Windows.Forms.ComboBox();
            this.ThemeFilter = new System.Windows.Forms.ComboBox();
            this.MoneyFrom = new System.Windows.Forms.ComboBox();
            this.MoneyTo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).BeginInit();
            this.SuspendLayout();
            // 
            // grdData
            // 
            this.grdData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSPQT,
            this.TenSPQT,
            this.ChuDe,
            this.MieuTaSPQT,
            this.GiaBan,
            this.GiaBanSauGiam,
            this.AddToCartButton});
            this.grdData.Location = new System.Drawing.Point(20, 100);
            this.grdData.Margin = new System.Windows.Forms.Padding(2);
            this.grdData.Name = "grdData";
            this.grdData.RowHeadersWidth = 51;
            this.grdData.RowTemplate.Height = 24;
            this.grdData.Size = new System.Drawing.Size(932, 363);
            this.grdData.TabIndex = 1;
            this.grdData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdData_CellContentClick);
            // 
            // MaSPQT
            // 
            this.MaSPQT.HeaderText = "Mã SPQT";
            this.MaSPQT.MinimumWidth = 6;
            this.MaSPQT.Name = "MaSPQT";
            this.MaSPQT.Width = 125;
            // 
            // TenSPQT
            // 
            this.TenSPQT.HeaderText = "Tên";
            this.TenSPQT.MinimumWidth = 6;
            this.TenSPQT.Name = "TenSPQT";
            this.TenSPQT.Width = 175;
            // 
            // ChuDe
            // 
            this.ChuDe.HeaderText = "Chủ đề";
            this.ChuDe.MinimumWidth = 6;
            this.ChuDe.Name = "ChuDe";
            this.ChuDe.Width = 125;
            // 
            // MieuTaSPQT
            // 
            this.MieuTaSPQT.HeaderText = "Miêu tả";
            this.MieuTaSPQT.MinimumWidth = 6;
            this.MieuTaSPQT.Name = "MieuTaSPQT";
            this.MieuTaSPQT.Width = 250;
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
            // AddToCartButton
            // 
            this.AddToCartButton.HeaderText = "Add to cart";
            this.AddToCartButton.MinimumWidth = 6;
            this.AddToCartButton.Name = "AddToCartButton";
            this.AddToCartButton.Text = "Add to cart";
            this.AddToCartButton.UseColumnTextForButtonValue = true;
            this.AddToCartButton.Width = 125;
            // 
            // SearchBar
            // 
            this.SearchBar.Location = new System.Drawing.Point(20, 24);
            this.SearchBar.Margin = new System.Windows.Forms.Padding(2);
            this.SearchBar.Name = "SearchBar";
            this.SearchBar.Size = new System.Drawing.Size(854, 20);
            this.SearchBar.TabIndex = 4;
            this.SearchBar.TextChanged += new System.EventHandler(this.SearchBar_TextChanged);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(878, 24);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(2);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(74, 19);
            this.SearchButton.TabIndex = 5;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // ColorFilter
            // 
            this.ColorFilter.FormattingEnabled = true;
            this.ColorFilter.Location = new System.Drawing.Point(96, 61);
            this.ColorFilter.Margin = new System.Windows.Forms.Padding(2);
            this.ColorFilter.Name = "ColorFilter";
            this.ColorFilter.Size = new System.Drawing.Size(93, 21);
            this.ColorFilter.TabIndex = 6;
            this.ColorFilter.SelectedIndexChanged += new System.EventHandler(this.ColorFilter_SelectedIndexChanged);
            // 
            // ThemeFilter
            // 
            this.ThemeFilter.FormattingEnabled = true;
            this.ThemeFilter.Location = new System.Drawing.Point(205, 61);
            this.ThemeFilter.Margin = new System.Windows.Forms.Padding(2);
            this.ThemeFilter.Name = "ThemeFilter";
            this.ThemeFilter.Size = new System.Drawing.Size(92, 21);
            this.ThemeFilter.TabIndex = 7;
            this.ThemeFilter.SelectedIndexChanged += new System.EventHandler(this.ThemeFilter_SelectedIndexChanged);
            // 
            // MoneyFrom
            // 
            this.MoneyFrom.FormattingEnabled = true;
            this.MoneyFrom.Location = new System.Drawing.Point(365, 61);
            this.MoneyFrom.Margin = new System.Windows.Forms.Padding(2);
            this.MoneyFrom.Name = "MoneyFrom";
            this.MoneyFrom.Size = new System.Drawing.Size(122, 21);
            this.MoneyFrom.TabIndex = 8;
            this.MoneyFrom.SelectedIndexChanged += new System.EventHandler(this.MoneyFrom_SelectedIndexChanged);
            // 
            // MoneyTo
            // 
            this.MoneyTo.FormattingEnabled = true;
            this.MoneyTo.Location = new System.Drawing.Point(491, 61);
            this.MoneyTo.Margin = new System.Windows.Forms.Padding(2);
            this.MoneyTo.Name = "MoneyTo";
            this.MoneyTo.Size = new System.Drawing.Size(122, 21);
            this.MoneyTo.TabIndex = 9;
            this.MoneyTo.SelectedIndexChanged += new System.EventHandler(this.MoneyTo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Lọc sản phẩm";
            // 
            // SearchSPQT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 474);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MoneyTo);
            this.Controls.Add(this.MoneyFrom);
            this.Controls.Add(this.ThemeFilter);
            this.Controls.Add(this.ColorFilter);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchBar);
            this.Controls.Add(this.grdData);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SearchSPQT";
            this.Text = "SearchSPQT";
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
        private System.Windows.Forms.ComboBox ThemeFilter;
        private System.Windows.Forms.ComboBox MoneyFrom;
        private System.Windows.Forms.ComboBox MoneyTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSPQT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSPQT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChuDe;
        private System.Windows.Forms.DataGridViewTextBoxColumn MieuTaSPQT;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaBanSauGiam;
        private System.Windows.Forms.DataGridViewButtonColumn AddToCartButton;
        private System.Windows.Forms.Label label1;
    }
}