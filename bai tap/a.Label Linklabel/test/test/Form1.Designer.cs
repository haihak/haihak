
namespace test
{
    partial class formLinklabei
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbtren = new System.Windows.Forms.Label();
            this.lbduoi = new System.Windows.Forms.Label();
            this.Linklabei1 = new System.Windows.Forms.LinkLabel();
            this.Linklabel2 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lbtren
            // 
            this.lbtren.AutoSize = true;
            this.lbtren.ForeColor = System.Drawing.Color.Red;
            this.lbtren.Location = new System.Drawing.Point(23, 41);
            this.lbtren.Name = "lbtren";
            this.lbtren.Size = new System.Drawing.Size(103, 20);
            this.lbtren.TabIndex = 0;
            this.lbtren.Text = "Địa chỉ liên hệ";
            this.lbtren.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbduoi
            // 
            this.lbduoi.AutoSize = true;
            this.lbduoi.ForeColor = System.Drawing.Color.Red;
            this.lbduoi.Location = new System.Drawing.Point(23, 83);
            this.lbduoi.Name = "lbduoi";
            this.lbduoi.Size = new System.Drawing.Size(78, 20);
            this.lbduoi.TabIndex = 1;
            this.lbduoi.Text = "Trang web";
            this.lbduoi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Linklabei1
            // 
            this.Linklabei1.AutoSize = true;
            this.Linklabei1.Location = new System.Drawing.Point(167, 41);
            this.Linklabei1.Name = "Linklabei1";
            this.Linklabei1.Size = new System.Drawing.Size(128, 20);
            this.Linklabei1.TabIndex = 2;
            this.Linklabei1.TabStop = true;
            this.Linklabei1.Text = "ctk43@gmail.com";
            this.Linklabei1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Link1_LinkClicked);
            // 
            // Linklabel2
            // 
            this.Linklabel2.AutoSize = true;
            this.Linklabel2.Location = new System.Drawing.Point(169, 83);
            this.Linklabel2.Name = "Linklabel2";
            this.Linklabel2.Size = new System.Drawing.Size(117, 20);
            this.Linklabel2.TabIndex = 3;
            this.Linklabel2.TabStop = true;
            this.Linklabel2.Text = "www.cnttk43.net";
            this.Linklabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Link2_LinkClicked);
            // 
            // formLinklabei
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 195);
            this.Controls.Add(this.Linklabel2);
            this.Controls.Add(this.Linklabei1);
            this.Controls.Add(this.lbduoi);
            this.Controls.Add(this.lbtren);
            this.Name = "formLinklabei";
            this.Text = "link labei";
            this.Load += new System.EventHandler(this.formLinklabei_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbtren;
        private System.Windows.Forms.Label lbduoi;
        private System.Windows.Forms.LinkLabel Linklabei1;
        private System.Windows.Forms.LinkLabel Linklabel2;
    }
}

