
namespace RadioButton
{
    partial class buttonss
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
            this.rbFlat = new System.Windows.Forms.RadioButton();
            this.ckbMauChu = new System.Windows.Forms.CheckBox();
            this.btnButton = new System.Windows.Forms.Button();
            this.btnButtonFlat = new System.Windows.Forms.Button();
            this.ckbMauNen = new System.Windows.Forms.CheckBox();
            this.rdPopup = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // rbFlat
            // 
            this.rbFlat.AutoSize = true;
            this.rbFlat.Location = new System.Drawing.Point(214, 128);
            this.rbFlat.Name = "rbFlat";
            this.rbFlat.Size = new System.Drawing.Size(87, 24);
            this.rbFlat.TabIndex = 0;
            this.rbFlat.Text = "Kiểu Flat";
            this.rbFlat.UseVisualStyleBackColor = true;
            this.rbFlat.Visible = false;
            this.rbFlat.CheckedChanged += new System.EventHandler(this.rbFlat_CheckedChanged);
            // 
            // ckbMauChu
            // 
            this.ckbMauChu.AutoSize = true;
            this.ckbMauChu.Location = new System.Drawing.Point(214, 27);
            this.ckbMauChu.Name = "ckbMauChu";
            this.ckbMauChu.Size = new System.Drawing.Size(146, 24);
            this.ckbMauChu.TabIndex = 1;
            this.ckbMauChu.Text = "thay đổi màu chữ";
            this.ckbMauChu.UseVisualStyleBackColor = true;
            this.ckbMauChu.CheckedChanged += new System.EventHandler(this.ckbMauChu_CheckedChanged);
            // 
            // btnButton
            // 
            this.btnButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnButton.Location = new System.Drawing.Point(50, 58);
            this.btnButton.Name = "btnButton";
            this.btnButton.Size = new System.Drawing.Size(94, 29);
            this.btnButton.TabIndex = 2;
            this.btnButton.Text = "Button";
            this.btnButton.UseVisualStyleBackColor = true;
            // 
            // btnButtonFlat
            // 
            this.btnButtonFlat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnButtonFlat.Location = new System.Drawing.Point(50, 161);
            this.btnButtonFlat.Name = "btnButtonFlat";
            this.btnButtonFlat.Size = new System.Drawing.Size(94, 29);
            this.btnButtonFlat.TabIndex = 3;
            this.btnButtonFlat.Text = "Button Flat";
            this.btnButtonFlat.UseVisualStyleBackColor = true;
            this.btnButtonFlat.Click += new System.EventHandler(this.btnButtonFlat_Click);
            // 
            // ckbMauNen
            // 
            this.ckbMauNen.AutoSize = true;
            this.ckbMauNen.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ckbMauNen.Location = new System.Drawing.Point(214, 63);
            this.ckbMauNen.Name = "ckbMauNen";
            this.ckbMauNen.Size = new System.Drawing.Size(146, 24);
            this.ckbMauNen.TabIndex = 4;
            this.ckbMauNen.Text = "thay đổi màu nền";
            this.ckbMauNen.UseVisualStyleBackColor = true;
            this.ckbMauNen.CheckedChanged += new System.EventHandler(this.ckbMauNen_CheckedChanged);
            // 
            // rdPopup
            // 
            this.rdPopup.AutoSize = true;
            this.rdPopup.Location = new System.Drawing.Point(214, 163);
            this.rdPopup.Name = "rdPopup";
            this.rdPopup.Size = new System.Drawing.Size(105, 24);
            this.rdPopup.TabIndex = 5;
            this.rdPopup.Text = "Kiểu Popup";
            this.rdPopup.UseVisualStyleBackColor = true;
            // 
            // buttonss
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 227);
            this.Controls.Add(this.rdPopup);
            this.Controls.Add(this.ckbMauNen);
            this.Controls.Add(this.btnButtonFlat);
            this.Controls.Add(this.btnButton);
            this.Controls.Add(this.ckbMauChu);
            this.Controls.Add(this.rbFlat);
            this.Name = "buttonss";
            this.Text = "buttons";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbFlat;
        private System.Windows.Forms.CheckBox ckbMauChu;
        private System.Windows.Forms.Button btnButton;
        private System.Windows.Forms.Button btnButtonFlat;
        private System.Windows.Forms.CheckBox ckbMauNen;
        private System.Windows.Forms.RadioButton rdPopup;
    }
}

