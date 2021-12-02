
namespace _1911147_lab8
{
    partial class formFood
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
            this.grpleft = new System.Windows.Forms.GroupBox();
            this.cmdDelete = new System.Windows.Forms.Button();
            this.cmdUpdate = new System.Windows.Forms.Button();
            this.cmdAdd = new System.Windows.Forms.Button();
            this.cmdClear = new System.Windows.Forms.Button();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.cbbCategory = new System.Windows.Forms.ComboBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpRight = new System.Windows.Forms.GroupBox();
            this.lsvFood = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblStatistic = new System.Windows.Forms.Label();
            this.cmdExit = new System.Windows.Forms.Button();
            this.grpleft.SuspendLayout();
            this.grpRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpleft
            // 
            this.grpleft.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grpleft.Controls.Add(this.cmdDelete);
            this.grpleft.Controls.Add(this.cmdUpdate);
            this.grpleft.Controls.Add(this.cmdAdd);
            this.grpleft.Controls.Add(this.cmdClear);
            this.grpleft.Controls.Add(this.txtNotes);
            this.grpleft.Controls.Add(this.cbbCategory);
            this.grpleft.Controls.Add(this.txtPrice);
            this.grpleft.Controls.Add(this.txtUnit);
            this.grpleft.Controls.Add(this.txtName);
            this.grpleft.Controls.Add(this.label5);
            this.grpleft.Controls.Add(this.label4);
            this.grpleft.Controls.Add(this.label3);
            this.grpleft.Controls.Add(this.label2);
            this.grpleft.Controls.Add(this.label1);
            this.grpleft.Location = new System.Drawing.Point(12, 12);
            this.grpleft.Name = "grpleft";
            this.grpleft.Size = new System.Drawing.Size(368, 386);
            this.grpleft.TabIndex = 0;
            this.grpleft.TabStop = false;
            this.grpleft.Text = "Chức năng";
            // 
            // cmdDelete
            // 
            this.cmdDelete.Location = new System.Drawing.Point(284, 340);
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.Size = new System.Drawing.Size(75, 32);
            this.cmdDelete.TabIndex = 4;
            this.cmdDelete.Text = "Xóa";
            this.cmdDelete.UseVisualStyleBackColor = true;
            this.cmdDelete.Click += new System.EventHandler(this.cmdDelete_Click);
            // 
            // cmdUpdate
            // 
            this.cmdUpdate.Location = new System.Drawing.Point(191, 340);
            this.cmdUpdate.Name = "cmdUpdate";
            this.cmdUpdate.Size = new System.Drawing.Size(75, 32);
            this.cmdUpdate.TabIndex = 4;
            this.cmdUpdate.Text = "Sửa";
            this.cmdUpdate.UseVisualStyleBackColor = true;
            this.cmdUpdate.Click += new System.EventHandler(this.cmdUpdate_Click);
            // 
            // cmdAdd
            // 
            this.cmdAdd.Location = new System.Drawing.Point(100, 340);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(75, 32);
            this.cmdAdd.TabIndex = 4;
            this.cmdAdd.Text = "Thêm";
            this.cmdAdd.UseVisualStyleBackColor = true;
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
            // 
            // cmdClear
            // 
            this.cmdClear.Location = new System.Drawing.Point(9, 340);
            this.cmdClear.Name = "cmdClear";
            this.cmdClear.Size = new System.Drawing.Size(75, 32);
            this.cmdClear.TabIndex = 4;
            this.cmdClear.Text = "Nhập lại";
            this.cmdClear.UseVisualStyleBackColor = true;
            this.cmdClear.Click += new System.EventHandler(this.cmdClear_Click);
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(128, 178);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(231, 138);
            this.txtNotes.TabIndex = 3;
            // 
            // cbbCategory
            // 
            this.cbbCategory.FormattingEnabled = true;
            this.cbbCategory.Location = new System.Drawing.Point(128, 136);
            this.cbbCategory.Name = "cbbCategory";
            this.cbbCategory.Size = new System.Drawing.Size(231, 24);
            this.cbbCategory.TabIndex = 2;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(128, 103);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(231, 22);
            this.txtPrice.TabIndex = 1;
            // 
            // txtUnit
            // 
            this.txtUnit.Location = new System.Drawing.Point(128, 69);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new System.Drawing.Size(231, 22);
            this.txtUnit.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(128, 33);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(231, 22);
            this.txtName.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ghi chú";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Loại thực phẩm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Đơn giá";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Đơn vị tính";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên thực phẩm";
            // 
            // grpRight
            // 
            this.grpRight.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpRight.Controls.Add(this.lsvFood);
            this.grpRight.Location = new System.Drawing.Point(386, 24);
            this.grpRight.Name = "grpRight";
            this.grpRight.Size = new System.Drawing.Size(490, 334);
            this.grpRight.TabIndex = 1;
            this.grpRight.TabStop = false;
            this.grpRight.Text = "Danh mục thức ăn";
            // 
            // lsvFood
            // 
            this.lsvFood.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsvFood.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lsvFood.FullRowSelect = true;
            this.lsvFood.GridLines = true;
            this.lsvFood.HideSelection = false;
            this.lsvFood.Location = new System.Drawing.Point(6, 21);
            this.lsvFood.MultiSelect = false;
            this.lsvFood.Name = "lsvFood";
            this.lsvFood.Size = new System.Drawing.Size(478, 307);
            this.lsvFood.TabIndex = 0;
            this.lsvFood.UseCompatibleStateImageBehavior = false;
            this.lsvFood.View = System.Windows.Forms.View.Details;
            this.lsvFood.Click += new System.EventHandler(this.lsvFood_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "STT";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên thực phẩm";
            this.columnHeader2.Width = 109;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "ĐVT";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Giá";
            this.columnHeader4.Width = 57;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Loại thực phẩm";
            this.columnHeader5.Width = 106;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Ghi chú";
            this.columnHeader6.Width = 82;
            // 
            // lblStatistic
            // 
            this.lblStatistic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblStatistic.AutoSize = true;
            this.lblStatistic.Location = new System.Drawing.Point(389, 367);
            this.lblStatistic.Name = "lblStatistic";
            this.lblStatistic.Size = new System.Drawing.Size(64, 16);
            this.lblStatistic.TabIndex = 2;
            this.lblStatistic.Text = "Thống kê";
            // 
            // cmdExit
            // 
            this.cmdExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdExit.Location = new System.Drawing.Point(804, 364);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(75, 23);
            this.cmdExit.TabIndex = 3;
            this.cmdExit.Text = "Thoát";
            this.cmdExit.UseVisualStyleBackColor = true;
            this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
            // 
            // formFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(884, 450);
            this.Controls.Add(this.cmdExit);
            this.Controls.Add(this.lblStatistic);
            this.Controls.Add(this.grpRight);
            this.Controls.Add(this.grpleft);
            this.Name = "formFood";
            this.Text = "Thêm- Xóa - Sửa bảng thức ăn";
            this.Load += new System.EventHandler(this.formFood_Load);
            this.grpleft.ResumeLayout(false);
            this.grpleft.PerformLayout();
            this.grpRight.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpleft;
        private System.Windows.Forms.Button cmdDelete;
        private System.Windows.Forms.Button cmdUpdate;
        private System.Windows.Forms.Button cmdAdd;
        private System.Windows.Forms.Button cmdClear;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.ComboBox cbbCategory;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpRight;
        private System.Windows.Forms.ListView lsvFood;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label lblStatistic;
        private System.Windows.Forms.Button cmdExit;
    }
}

