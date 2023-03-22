
namespace MP4_Binary_01
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
            this.Pic_Goc = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Pic_Xam = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Pic_nhi_phan = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Slide_nguong = new System.Windows.Forms.VScrollBar();
            this.label4 = new System.Windows.Forms.Label();
            this.Gia_tri_nguong = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Goc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Xam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_nhi_phan)).BeginInit();
            this.SuspendLayout();
            // 
            // Pic_Goc
            // 
            this.Pic_Goc.Location = new System.Drawing.Point(12, 32);
            this.Pic_Goc.Name = "Pic_Goc";
            this.Pic_Goc.Size = new System.Drawing.Size(300, 300);
            this.Pic_Goc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic_Goc.TabIndex = 0;
            this.Pic_Goc.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Anh_Goc";
            // 
            // Pic_Xam
            // 
            this.Pic_Xam.Location = new System.Drawing.Point(318, 32);
            this.Pic_Xam.Name = "Pic_Xam";
            this.Pic_Xam.Size = new System.Drawing.Size(300, 300);
            this.Pic_Xam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic_Xam.TabIndex = 0;
            this.Pic_Xam.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(318, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Anh_Xam";
            // 
            // Pic_nhi_phan
            // 
            this.Pic_nhi_phan.Location = new System.Drawing.Point(626, 32);
            this.Pic_nhi_phan.Name = "Pic_nhi_phan";
            this.Pic_nhi_phan.Size = new System.Drawing.Size(300, 300);
            this.Pic_nhi_phan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic_nhi_phan.TabIndex = 0;
            this.Pic_nhi_phan.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(626, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Anh_nhi_phan";
            // 
            // Slide_nguong
            // 
            this.Slide_nguong.LargeChange = 5;
            this.Slide_nguong.Location = new System.Drawing.Point(938, 32);
            this.Slide_nguong.Maximum = 255;
            this.Slide_nguong.Name = "Slide_nguong";
            this.Slide_nguong.Size = new System.Drawing.Size(39, 300);
            this.Slide_nguong.TabIndex = 2;
            this.Slide_nguong.ValueChanged += new System.EventHandler(this.vScrollBar1_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(938, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nguong";
            // 
            // Gia_tri_nguong
            // 
            this.Gia_tri_nguong.AutoSize = true;
            this.Gia_tri_nguong.Location = new System.Drawing.Point(997, 51);
            this.Gia_tri_nguong.Name = "Gia_tri_nguong";
            this.Gia_tri_nguong.Size = new System.Drawing.Size(0, 20);
            this.Gia_tri_nguong.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 554);
            this.Controls.Add(this.Gia_tri_nguong);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Slide_nguong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Pic_nhi_phan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Pic_Xam);
            this.Controls.Add(this.Pic_Goc);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Goc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Xam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_nhi_phan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Pic_Goc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Pic_Xam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox Pic_nhi_phan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.VScrollBar Slide_nguong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Gia_tri_nguong;
    }
}

