
namespace _1911147_lab7
{
    partial class ThemNhomThucAn
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTennhom = new System.Windows.Forms.TextBox();
            this.txtLoai = new System.Windows.Forms.TextBox();
            this.btnAddNhom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên nhóm thức ăn:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "label1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Loại :";
            // 
            // txtTennhom
            // 
            this.txtTennhom.Location = new System.Drawing.Point(141, 32);
            this.txtTennhom.Name = "txtTennhom";
            this.txtTennhom.Size = new System.Drawing.Size(246, 22);
            this.txtTennhom.TabIndex = 1;
            // 
            // txtLoai
            // 
            this.txtLoai.Location = new System.Drawing.Point(141, 86);
            this.txtLoai.Name = "txtLoai";
            this.txtLoai.Size = new System.Drawing.Size(246, 22);
            this.txtLoai.TabIndex = 1;
            // 
            // btnAddNhom
            // 
            this.btnAddNhom.AutoSize = true;
            this.btnAddNhom.Location = new System.Drawing.Point(229, 125);
            this.btnAddNhom.Name = "btnAddNhom";
            this.btnAddNhom.Size = new System.Drawing.Size(75, 27);
            this.btnAddNhom.TabIndex = 2;
            this.btnAddNhom.Text = "Thêm";
            this.btnAddNhom.UseVisualStyleBackColor = true;
            this.btnAddNhom.Click += new System.EventHandler(this.btnAddNhom_Click);
            // 
            // ThemNhomThucAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(405, 164);
            this.Controls.Add(this.btnAddNhom);
            this.Controls.Add(this.txtLoai);
            this.Controls.Add(this.txtTennhom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "ThemNhomThucAn";
            this.Text = "Thêm nhóm thức ăn mới";
            this.Load += new System.EventHandler(this.ThemNhomThucAn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTennhom;
        private System.Windows.Forms.TextBox txtLoai;
        private System.Windows.Forms.Button btnAddNhom;
    }
}