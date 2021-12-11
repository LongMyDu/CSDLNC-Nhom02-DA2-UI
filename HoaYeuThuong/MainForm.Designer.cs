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
            this.SuspendLayout();
            // 
            // GoToSPQT
            // 
            this.GoToSPQT.Location = new System.Drawing.Point(176, 50);
            this.GoToSPQT.Margin = new System.Windows.Forms.Padding(4);
            this.GoToSPQT.Name = "GoToSPQT";
            this.GoToSPQT.Size = new System.Drawing.Size(232, 28);
            this.GoToSPQT.TabIndex = 0;
            this.GoToSPQT.Text = "Tìm sản phẩm";
            this.GoToSPQT.UseVisualStyleBackColor = true;
            this.GoToSPQT.Click += new System.EventHandler(this.GoToSPQT_Click);
            // 
            // ViewCartButton
            // 
            this.ViewCartButton.Location = new System.Drawing.Point(200, 234);
            this.ViewCartButton.Margin = new System.Windows.Forms.Padding(4);
            this.ViewCartButton.Name = "ViewCartButton";
            this.ViewCartButton.Size = new System.Drawing.Size(185, 28);
            this.ViewCartButton.TabIndex = 1;
            this.ViewCartButton.Text = "Xem giỏ hàng";
            this.ViewCartButton.UseVisualStyleBackColor = true;
            this.ViewCartButton.Click += new System.EventHandler(this.ViewCartButton_Click);
            // 
            // GoToSPMK
            // 
            this.GoToSPMK.Location = new System.Drawing.Point(176, 101);
            this.GoToSPMK.Name = "GoToSPMK";
            this.GoToSPMK.Size = new System.Drawing.Size(232, 28);
            this.GoToSPMK.TabIndex = 2;
            this.GoToSPMK.Text = "Tìm sản phẩm mua kèm";
            this.GoToSPMK.UseVisualStyleBackColor = true;
            this.GoToSPMK.Click += new System.EventHandler(this.GoToSPMK_Click);
            // 
            // GoToHT
            // 
            this.GoToHT.Location = new System.Drawing.Point(176, 155);
            this.GoToHT.Name = "GoToHT";
            this.GoToHT.Size = new System.Drawing.Size(232, 28);
            this.GoToHT.TabIndex = 3;
            this.GoToHT.Text = "Tìm hoa tươi";
            this.GoToHT.UseVisualStyleBackColor = true;
            this.GoToHT.Click += new System.EventHandler(this.GoToHT_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.GoToHT);
            this.Controls.Add(this.GoToSPMK);
            this.Controls.Add(this.ViewCartButton);
            this.Controls.Add(this.GoToSPQT);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GoToSPQT;
        private System.Windows.Forms.Button ViewCartButton;
        private System.Windows.Forms.Button GoToSPMK;
        private System.Windows.Forms.Button GoToHT;
    }
}