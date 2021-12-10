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
            this.SuspendLayout();
            // 
            // GoToSPQT
            // 
            this.GoToSPQT.Location = new System.Drawing.Point(132, 41);
            this.GoToSPQT.Name = "GoToSPQT";
            this.GoToSPQT.Size = new System.Drawing.Size(174, 23);
            this.GoToSPQT.TabIndex = 0;
            this.GoToSPQT.Text = "Tìm sản phẩm";
            this.GoToSPQT.UseVisualStyleBackColor = true;
            this.GoToSPQT.Click += new System.EventHandler(this.GoToSPQT_Click);
            // 
            // ViewCartButton
            // 
            this.ViewCartButton.Location = new System.Drawing.Point(144, 157);
            this.ViewCartButton.Name = "ViewCartButton";
            this.ViewCartButton.Size = new System.Drawing.Size(139, 23);
            this.ViewCartButton.TabIndex = 1;
            this.ViewCartButton.Text = "Xem giỏ hàng";
            this.ViewCartButton.UseVisualStyleBackColor = true;
            this.ViewCartButton.Click += new System.EventHandler(this.ViewCartButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ViewCartButton);
            this.Controls.Add(this.GoToSPQT);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GoToSPQT;
        private System.Windows.Forms.Button ViewCartButton;
    }
}