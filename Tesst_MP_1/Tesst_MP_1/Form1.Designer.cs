
namespace Tesst_MP_1
{
    partial class Hien_thi
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
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Pic_01 = new System.Windows.Forms.PictureBox();
            this.Pic_Red = new System.Windows.Forms.PictureBox();
            this.Pic_Blue = new System.Windows.Forms.PictureBox();
            this.Pic_Green = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Blue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Green)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hien_thi_anh";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(446, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Red_";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 456);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Green_";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(446, 456);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Blue_";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // Pic_01
            // 
            this.Pic_01.Location = new System.Drawing.Point(15, 29);
            this.Pic_01.Name = "Pic_01";
            this.Pic_01.Size = new System.Drawing.Size(400, 400);
            this.Pic_01.TabIndex = 3;
            this.Pic_01.TabStop = false;
            // 
            // Pic_Red
            // 
            this.Pic_Red.Location = new System.Drawing.Point(449, 29);
            this.Pic_Red.Name = "Pic_Red";
            this.Pic_Red.Size = new System.Drawing.Size(400, 400);
            this.Pic_Red.TabIndex = 3;
            this.Pic_Red.TabStop = false;
            // 
            // Pic_Blue
            // 
            this.Pic_Blue.Location = new System.Drawing.Point(449, 476);
            this.Pic_Blue.Name = "Pic_Blue";
            this.Pic_Blue.Size = new System.Drawing.Size(400, 400);
            this.Pic_Blue.TabIndex = 3;
            this.Pic_Blue.TabStop = false;
            // 
            // Pic_Green
            // 
            this.Pic_Green.Location = new System.Drawing.Point(15, 476);
            this.Pic_Green.Name = "Pic_Green";
            this.Pic_Green.Size = new System.Drawing.Size(400, 400);
            this.Pic_Green.TabIndex = 3;
            this.Pic_Green.TabStop = false;
            // 
            // Hien_thi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 825);
            this.Controls.Add(this.Pic_Green);
            this.Controls.Add(this.Pic_Blue);
            this.Controls.Add(this.Pic_Red);
            this.Controls.Add(this.Pic_01);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Hien_thi";
            this.Text = "Hien_thi";
            ((System.ComponentModel.ISupportInitialize)(this.Pic_01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Blue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Green)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox Pic_01;
        private System.Windows.Forms.PictureBox Pic_Red;
        private System.Windows.Forms.PictureBox Pic_Blue;
        private System.Windows.Forms.PictureBox Pic_Green;
    }
}

