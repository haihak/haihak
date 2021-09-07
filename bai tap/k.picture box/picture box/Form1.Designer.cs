
namespace picture_box
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.pbten = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.imageList3 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbten)).BeginInit();
            this.SuspendLayout();
            // 
            // pbten
            // 
            this.pbten.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbten.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.pbten.Image = global::picture_box.Properties.Resources.Screenshot_2021_03_03_134219;
            this.pbten.Location = new System.Drawing.Point(30, 47);
            this.pbten.Name = "pbten";
            this.pbten.Size = new System.Drawing.Size(286, 281);
            this.pbten.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbten.TabIndex = 0;
            this.pbten.TabStop = false;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageList2
            // 
            this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList2.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageList3
            // 
            this.imageList3.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList3.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList3.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 393);
            this.Controls.Add(this.pbten);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbten)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbten;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.ImageList imageList3;
    }
}

