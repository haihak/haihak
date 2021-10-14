
namespace OnTapkiemtrap1
{
    partial class FormQLSV
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
            this.label1 = new System.Windows.Forms.Label();
            this.tvKhoa = new System.Windows.Forms.TreeView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lvDSSV = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Khoa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ThemToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.xoaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.txtNhaptt = new System.Windows.Forms.TextBox();
            this.rdbtnMSSV = new System.Windows.Forms.RadioButton();
            this.rdbtnSDT = new System.Windows.Forms.RadioButton();
            this.rdbtnHoTen = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.nhậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lưuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.groupBox1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn lớp để hiển thị danh sách sinh viên";
            // 
            // tvKhoa
            // 
            this.tvKhoa.Location = new System.Drawing.Point(15, 53);
            this.tvKhoa.Name = "tvKhoa";
            this.tvKhoa.Size = new System.Drawing.Size(261, 385);
            this.tvKhoa.TabIndex = 2;
            this.tvKhoa.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvKhoa_AfterSelect);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lvDSSV);
            this.groupBox1.Controls.Add(this.txtNhaptt);
            this.groupBox1.Controls.Add(this.rdbtnMSSV);
            this.groupBox1.Controls.Add(this.rdbtnSDT);
            this.groupBox1.Controls.Add(this.rdbtnHoTen);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(282, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(635, 436);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm Kiếm";
            // 
            // lvDSSV
            // 
            this.lvDSSV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvDSSV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.Khoa,
            this.columnHeader9});
            this.lvDSSV.ContextMenuStrip = this.contextMenuStrip1;
            this.lvDSSV.FullRowSelect = true;
            this.lvDSSV.GridLines = true;
            this.lvDSSV.HideSelection = false;
            this.lvDSSV.Location = new System.Drawing.Point(6, 86);
            this.lvDSSV.Name = "lvDSSV";
            this.lvDSSV.Size = new System.Drawing.Size(623, 344);
            this.lvDSSV.TabIndex = 3;
            this.lvDSSV.UseCompatibleStateImageBehavior = false;
            this.lvDSSV.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "MSSV";
            this.columnHeader1.Width = 69;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Họ và tên lót";
            this.columnHeader2.Width = 138;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tên";
            this.columnHeader3.Width = 73;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Giới tính";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Ngày sinh";
            this.columnHeader5.Width = 96;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Số điện thoại";
            this.columnHeader6.Width = 104;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Lớp";
            // 
            // Khoa
            // 
            this.Khoa.Text = "Khoa";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Địa chỉ liên lạc";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ThemToolStripMenuItem1,
            this.xoaToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(116, 52);
            // 
            // ThemToolStripMenuItem1
            // 
            this.ThemToolStripMenuItem1.Name = "ThemToolStripMenuItem1";
            this.ThemToolStripMenuItem1.Size = new System.Drawing.Size(115, 24);
            this.ThemToolStripMenuItem1.Text = "Thêm";
            this.ThemToolStripMenuItem1.Click += new System.EventHandler(this.ThemToolStripMenuItem1_Click);
            // 
            // xoaToolStripMenuItem1
            // 
            this.xoaToolStripMenuItem1.Name = "xoaToolStripMenuItem1";
            this.xoaToolStripMenuItem1.Size = new System.Drawing.Size(115, 24);
            this.xoaToolStripMenuItem1.Text = "Xóa";
            this.xoaToolStripMenuItem1.Click += new System.EventHandler(this.xoaToolStripMenuItem1_Click);
            // 
            // txtNhaptt
            // 
            this.txtNhaptt.Location = new System.Drawing.Point(205, 58);
            this.txtNhaptt.Name = "txtNhaptt";
            this.txtNhaptt.Size = new System.Drawing.Size(342, 22);
            this.txtNhaptt.TabIndex = 2;
            // 
            // rdbtnMSSV
            // 
            this.rdbtnMSSV.AutoSize = true;
            this.rdbtnMSSV.Location = new System.Drawing.Point(205, 30);
            this.rdbtnMSSV.Name = "rdbtnMSSV";
            this.rdbtnMSSV.Size = new System.Drawing.Size(67, 21);
            this.rdbtnMSSV.TabIndex = 1;
            this.rdbtnMSSV.TabStop = true;
            this.rdbtnMSSV.Text = "MSSV";
            this.rdbtnMSSV.UseVisualStyleBackColor = true;
            // 
            // rdbtnSDT
            // 
            this.rdbtnSDT.AutoSize = true;
            this.rdbtnSDT.Location = new System.Drawing.Point(437, 30);
            this.rdbtnSDT.Name = "rdbtnSDT";
            this.rdbtnSDT.Size = new System.Drawing.Size(112, 21);
            this.rdbtnSDT.TabIndex = 1;
            this.rdbtnSDT.TabStop = true;
            this.rdbtnSDT.Text = "Số điện thoại";
            this.rdbtnSDT.UseVisualStyleBackColor = true;
            // 
            // rdbtnHoTen
            // 
            this.rdbtnHoTen.AutoSize = true;
            this.rdbtnHoTen.Location = new System.Drawing.Point(321, 30);
            this.rdbtnHoTen.Name = "rdbtnHoTen";
            this.rdbtnHoTen.Size = new System.Drawing.Size(71, 21);
            this.rdbtnHoTen.TabIndex = 1;
            this.rdbtnHoTen.TabStop = true;
            this.rdbtnHoTen.Text = "Họ tên";
            this.rdbtnHoTen.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tìm theo:";
            // 
            // nhậpToolStripMenuItem
            // 
            this.nhậpToolStripMenuItem.Name = "nhậpToolStripMenuItem";
            this.nhậpToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.nhậpToolStripMenuItem.Text = "Nhập";
            // 
            // lưuToolStripMenuItem
            // 
            this.lưuToolStripMenuItem.Name = "lưuToolStripMenuItem";
            this.lưuToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.lưuToolStripMenuItem.Text = "Lưu";
            // 
            // inToolStripMenuItem
            // 
            this.inToolStripMenuItem.Name = "inToolStripMenuItem";
            this.inToolStripMenuItem.Size = new System.Drawing.Size(35, 24);
            this.inToolStripMenuItem.Text = "In";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhậpToolStripMenuItem,
            this.lưuToolStripMenuItem,
            this.inToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(-7, 2);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(149, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FormQLSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tvKhoa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormQLSV";
            this.Text = "Quản Lý Sinh Vien";
            this.Load += new System.EventHandler(this.FormQLSV_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView tvKhoa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lvDSSV;
        private System.Windows.Forms.TextBox txtNhaptt;
        private System.Windows.Forms.RadioButton rdbtnMSSV;
        private System.Windows.Forms.RadioButton rdbtnSDT;
        private System.Windows.Forms.RadioButton rdbtnHoTen;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ToolStripMenuItem nhậpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lưuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ThemToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem xoaToolStripMenuItem1;
        private System.Windows.Forms.ColumnHeader Khoa;
        private System.Windows.Forms.ColumnHeader columnHeader9;
    }
}

