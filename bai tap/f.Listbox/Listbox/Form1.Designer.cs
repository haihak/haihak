
namespace Listbox
{
    partial class formlistbox
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
            this.lbDanhsachChon = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.lbDanhsach = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbDanhsachChon
            // 
            this.lbDanhsachChon.ForeColor = System.Drawing.Color.Red;
            this.lbDanhsachChon.FormattingEnabled = true;
            this.lbDanhsachChon.ItemHeight = 20;
            this.lbDanhsachChon.Items.AddRange(new object[] {
            "Pham Vu Ngoc Ha",
            "Pham Van Hung",
            "Le Thi Van",
            "Nguyen Thi Thu",
            "Le Van Quoc",
            "Le Van Phuoc",
            "Truong Van Dung"});
            this.lbDanhsachChon.Location = new System.Drawing.Point(12, 34);
            this.lbDanhsachChon.MultiColumn = true;
            this.lbDanhsachChon.Name = "lbDanhsachChon";
            this.lbDanhsachChon.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbDanhsachChon.Size = new System.Drawing.Size(232, 224);
            this.lbDanhsachChon.TabIndex = 0;
            this.lbDanhsachChon.SelectedIndexChanged += new System.EventHandler(this.lbDanhsachChon_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(258, 85);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 29);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Chọn";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(258, 163);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(94, 29);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // lbDanhsach
            // 
            this.lbDanhsach.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbDanhsach.FormattingEnabled = true;
            this.lbDanhsach.ItemHeight = 20;
            this.lbDanhsach.Items.AddRange(new object[] {
            "Tran The Anh",
            "Nguyen Thi Lan Huong"});
            this.lbDanhsach.Location = new System.Drawing.Point(370, 34);
            this.lbDanhsach.MultiColumn = true;
            this.lbDanhsach.Name = "lbDanhsach";
            this.lbDanhsach.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbDanhsach.Size = new System.Drawing.Size(232, 224);
            this.lbDanhsach.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Danh sách sinh viên lớp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(370, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Danh Sách sinh viên bóng đá";
            // 
            // formlistbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 374);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbDanhsach);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lbDanhsachChon);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Name = "formlistbox";
            this.Text = " lisbox";
            this.Load += new System.EventHandler(this.formlistbox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbDanhsachChon;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.ListBox lbDanhsach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

