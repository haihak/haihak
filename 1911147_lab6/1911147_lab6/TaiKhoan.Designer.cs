﻿
namespace _1911147_lab6
{
    partial class TaiKhoan
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
            this.components = new System.ComponentModel.Container();
            this.dgvTK = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtHovaTen = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.dtpTGDK = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.rbtnBoss = new System.Windows.Forms.RadioButton();
            this.rbtnNV = new System.Windows.Forms.RadioButton();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnReSet = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.xóaTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xemDanhSáchVaiTròToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTK)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTK
            // 
            this.dgvTK.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTK.BackgroundColor = System.Drawing.Color.White;
            this.dgvTK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTK.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvTK.Location = new System.Drawing.Point(1, 147);
            this.dgvTK.Name = "dgvTK";
            this.dgvTK.RowHeadersWidth = 51;
            this.dgvTK.RowTemplate.Height = 24;
            this.dgvTK.Size = new System.Drawing.Size(643, 304);
            this.dgvTK.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tài Khoản:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Họ và Tên:";
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Location = new System.Drawing.Point(95, 6);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(157, 22);
            this.txtTaiKhoan.TabIndex = 2;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(95, 41);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(157, 22);
            this.txtMatKhau.TabIndex = 2;
            this.txtMatKhau.UseSystemPasswordChar = true;
            // 
            // txtHovaTen
            // 
            this.txtHovaTen.Location = new System.Drawing.Point(96, 75);
            this.txtHovaTen.Name = "txtHovaTen";
            this.txtHovaTen.Size = new System.Drawing.Size(156, 22);
            this.txtHovaTen.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(258, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(258, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Thời gian đăng ký:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(347, 41);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(288, 22);
            this.txtEmail.TabIndex = 2;
            // 
            // dtpTGDK
            // 
            this.dtpTGDK.CustomFormat = "dd/MM/yyy";
            this.dtpTGDK.Location = new System.Drawing.Point(389, 78);
            this.dtpTGDK.Name = "dtpTGDK";
            this.dtpTGDK.Size = new System.Drawing.Size(244, 22);
            this.dtpTGDK.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(258, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Trạng Thái :";
            // 
            // rbtnBoss
            // 
            this.rbtnBoss.AutoSize = true;
            this.rbtnBoss.Location = new System.Drawing.Point(350, 11);
            this.rbtnBoss.Name = "rbtnBoss";
            this.rbtnBoss.Size = new System.Drawing.Size(60, 21);
            this.rbtnBoss.TabIndex = 4;
            this.rbtnBoss.TabStop = true;
            this.rbtnBoss.Text = "Boss";
            this.rbtnBoss.UseVisualStyleBackColor = true;
            // 
            // rbtnNV
            // 
            this.rbtnNV.AutoSize = true;
            this.rbtnNV.Location = new System.Drawing.Point(466, 12);
            this.rbtnNV.Name = "rbtnNV";
            this.rbtnNV.Size = new System.Drawing.Size(95, 21);
            this.rbtnNV.TabIndex = 4;
            this.rbtnNV.TabStop = true;
            this.rbtnNV.Text = "Nhân Viên";
            this.rbtnNV.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThem.AutoSize = true;
            this.btnThem.BackColor = System.Drawing.Color.Gainsboro;
            this.btnThem.Location = new System.Drawing.Point(479, 114);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 27);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            // 
            // btnReSet
            // 
            this.btnReSet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReSet.AutoSize = true;
            this.btnReSet.BackColor = System.Drawing.Color.Gainsboro;
            this.btnReSet.Location = new System.Drawing.Point(560, 114);
            this.btnReSet.Name = "btnReSet";
            this.btnReSet.Size = new System.Drawing.Size(75, 27);
            this.btnReSet.TabIndex = 5;
            this.btnReSet.Text = "Reset";
            this.btnReSet.UseVisualStyleBackColor = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xóaTàiKhoảnToolStripMenuItem,
            this.xemDanhSáchVaiTròToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(232, 52);
            // 
            // xóaTàiKhoảnToolStripMenuItem
            // 
            this.xóaTàiKhoảnToolStripMenuItem.Name = "xóaTàiKhoảnToolStripMenuItem";
            this.xóaTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(231, 24);
            this.xóaTàiKhoảnToolStripMenuItem.Text = "Xóa Tài Khoản";
            // 
            // xemDanhSáchVaiTròToolStripMenuItem
            // 
            this.xemDanhSáchVaiTròToolStripMenuItem.Name = "xemDanhSáchVaiTròToolStripMenuItem";
            this.xemDanhSáchVaiTròToolStripMenuItem.Size = new System.Drawing.Size(231, 24);
            this.xemDanhSáchVaiTròToolStripMenuItem.Text = "Xem Danh Sách Vai Trò";
            // 
            // TaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(645, 450);
            this.Controls.Add(this.btnReSet);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.rbtnNV);
            this.Controls.Add(this.rbtnBoss);
            this.Controls.Add(this.dtpTGDK);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtHovaTen);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtTaiKhoan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvTK);
            this.Name = "TaiKhoan";
            this.Text = "TaiKhoan";
            this.Load += new System.EventHandler(this.TaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTK)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtHovaTen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.DateTimePicker dtpTGDK;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rbtnBoss;
        private System.Windows.Forms.RadioButton rbtnNV;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnReSet;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem xóaTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xemDanhSáchVaiTròToolStripMenuItem;
    }
}