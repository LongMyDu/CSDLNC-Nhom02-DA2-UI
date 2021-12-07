namespace HoaYeuThuong
{
    partial class NTForm
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
            this.Save = new System.Windows.Forms.Button();
            this.SPQT = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.SPQT)).BeginInit();
            this.SuspendLayout();
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(188, 168);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 0;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // SPQT
            // 
            this.SPQT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SPQT.Location = new System.Drawing.Point(12, 12);
            this.SPQT.Name = "SPQT";
            this.SPQT.Size = new System.Drawing.Size(441, 150);
            this.SPQT.TabIndex = 1;
            // 
            // NTForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 201);
            this.Controls.Add(this.SPQT);
            this.Controls.Add(this.Save);
            this.Name = "NTForm";
            this.Text = "NTForm";
            this.Load += new System.EventHandler(this.NTForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SPQT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.DataGridView SPQT;
    }
}

