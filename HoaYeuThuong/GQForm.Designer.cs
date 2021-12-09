namespace HoaYeuThuong
{
    partial class GQForm
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
            this.SearchBar = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.ColorFilter = new System.Windows.Forms.ComboBox();
            this.ThemeFilter = new System.Windows.Forms.ComboBox();
            this.MoneyFrom = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).BeginInit();
            this.SuspendLayout();
            // 
            // grdData
            // 
            this.grdData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdData.Location = new System.Drawing.Point(26, 123);
            this.grdData.Name = "grdData";
            this.grdData.RowHeadersWidth = 51;
            this.grdData.RowTemplate.Height = 24;
            this.grdData.Size = new System.Drawing.Size(1100, 449);
            this.grdData.TabIndex = 1;
            // 
            // SearchBar
            // 
            this.SearchBar.Location = new System.Drawing.Point(27, 30);
            this.SearchBar.Name = "SearchBar";
            this.SearchBar.Size = new System.Drawing.Size(975, 22);
            this.SearchBar.TabIndex = 4;
            this.SearchBar.TextChanged += new System.EventHandler(this.SearchBar_TextChanged);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(1024, 30);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 5;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // ColorFilter
            // 
            this.ColorFilter.FormattingEnabled = true;
            this.ColorFilter.Location = new System.Drawing.Point(27, 75);
            this.ColorFilter.Name = "ColorFilter";
            this.ColorFilter.Size = new System.Drawing.Size(123, 24);
            this.ColorFilter.TabIndex = 6;
            this.ColorFilter.SelectedIndexChanged += new System.EventHandler(this.ColorFilter_SelectedIndexChanged);
            // 
            // ThemeFilter
            // 
            this.ThemeFilter.FormattingEnabled = true;
            this.ThemeFilter.Location = new System.Drawing.Point(166, 75);
            this.ThemeFilter.Name = "ThemeFilter";
            this.ThemeFilter.Size = new System.Drawing.Size(121, 24);
            this.ThemeFilter.TabIndex = 7;
            this.ThemeFilter.SelectedIndexChanged += new System.EventHandler(this.ThemeFilter_SelectedIndexChanged);
            // 
            // MoneyFrom
            // 
            this.MoneyFrom.FormattingEnabled = true;
            this.MoneyFrom.Location = new System.Drawing.Point(482, 75);
            this.MoneyFrom.Name = "MoneyFrom";
            this.MoneyFrom.Size = new System.Drawing.Size(121, 24);
            this.MoneyFrom.TabIndex = 8;
            // 
            // GQForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 584);
            this.Controls.Add(this.MoneyFrom);
            this.Controls.Add(this.ThemeFilter);
            this.Controls.Add(this.ColorFilter);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchBar);
            this.Controls.Add(this.grdData);
            this.Name = "GQForm";
            this.Text = "FormGQ";
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
    }
}