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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.PageNum = new System.Windows.Forms.Label();
            this.PreviousButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).BeginInit();
            this.SuspendLayout();
            // 
            // grdData
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grdData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSPQT,
            this.TenSPQT,
            this.ChuDe,
            this.MieuTaSPQT,
            this.GiaBan,
            this.GiaBanSauGiam,
            this.AddToCartButton});
            this.grdData.Location = new System.Drawing.Point(0, 161);
            this.grdData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grdData.Name = "grdData";
            this.grdData.RowHeadersWidth = 51;
            this.grdData.RowTemplate.Height = 24;
            this.grdData.Size = new System.Drawing.Size(1284, 406);
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
            // ThemeFilter
            // 
            this.ThemeFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThemeFilter.FormattingEnabled = true;
            this.ThemeFilter.Location = new System.Drawing.Point(273, 75);
            this.ThemeFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ThemeFilter.Name = "ThemeFilter";
            this.ThemeFilter.Size = new System.Drawing.Size(121, 25);
            this.ThemeFilter.TabIndex = 7;
            this.ThemeFilter.SelectedIndexChanged += new System.EventHandler(this.ThemeFilter_SelectedIndexChanged);
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
            // PageNum
            // 
            this.PageNum.AutoSize = true;
            this.PageNum.Location = new System.Drawing.Point(626, 576);
            this.PageNum.Name = "PageNum";
            this.PageNum.Size = new System.Drawing.Size(14, 16);
            this.PageNum.TabIndex = 16;
            this.PageNum.Text = "1";
            // 
            // PreviousButton
            // 
            this.PreviousButton.Location = new System.Drawing.Point(432, 573);
            this.PreviousButton.Name = "PreviousButton";
            this.PreviousButton.Size = new System.Drawing.Size(75, 23);
            this.PreviousButton.TabIndex = 15;
            this.PreviousButton.Text = "Previous";
            this.PreviousButton.UseVisualStyleBackColor = true;
            this.PreviousButton.Click += new System.EventHandler(this.PreviousButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(764, 573);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(75, 23);
            this.NextButton.TabIndex = 14;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // SearchSPQT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 608);
            this.Controls.Add(this.PageNum);
            this.Controls.Add(this.PreviousButton);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MoneyTo);
            this.Controls.Add(this.MoneyFrom);
            this.Controls.Add(this.ThemeFilter);
            this.Controls.Add(this.ColorFilter);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchBar);
            this.Controls.Add(this.grdData);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.Label PageNum;
        private System.Windows.Forms.Button PreviousButton;
        private System.Windows.Forms.Button NextButton;
    }
}