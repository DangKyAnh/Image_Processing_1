
namespace HSI_01
{
    partial class Chuyen_doi_khong_gian_mau_HSI
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
            this.Pic_hue = new System.Windows.Forms.PictureBox();
            this.H = new System.Windows.Forms.Label();
            this.Pic_saturation = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Pic_V = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Pic_goc = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Pic_HSV = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_hue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_saturation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_V)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_goc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_HSV)).BeginInit();
            this.SuspendLayout();
            // 
            // Pic_hue
            // 
            this.Pic_hue.Location = new System.Drawing.Point(12, 29);
            this.Pic_hue.Name = "Pic_hue";
            this.Pic_hue.Size = new System.Drawing.Size(250, 250);
            this.Pic_hue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic_hue.TabIndex = 0;
            this.Pic_hue.TabStop = false;
            // 
            // H
            // 
            this.H.AutoSize = true;
            this.H.Location = new System.Drawing.Point(12, 9);
            this.H.Name = "H";
            this.H.Size = new System.Drawing.Size(17, 17);
            this.H.TabIndex = 1;
            this.H.Text = "X";
            // 
            // Pic_saturation
            // 
            this.Pic_saturation.Location = new System.Drawing.Point(346, 29);
            this.Pic_saturation.Name = "Pic_saturation";
            this.Pic_saturation.Size = new System.Drawing.Size(250, 250);
            this.Pic_saturation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic_saturation.TabIndex = 0;
            this.Pic_saturation.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(346, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Y";
            // 
            // Pic_V
            // 
            this.Pic_V.Location = new System.Drawing.Point(663, 29);
            this.Pic_V.Name = "Pic_V";
            this.Pic_V.Size = new System.Drawing.Size(250, 250);
            this.Pic_V.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic_V.TabIndex = 0;
            this.Pic_V.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(663, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Z";
            // 
            // Pic_goc
            // 
            this.Pic_goc.Location = new System.Drawing.Point(12, 330);
            this.Pic_goc.Name = "Pic_goc";
            this.Pic_goc.Size = new System.Drawing.Size(250, 250);
            this.Pic_goc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic_goc.TabIndex = 0;
            this.Pic_goc.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Hinh_Goc";
            // 
            // Pic_HSV
            // 
            this.Pic_HSV.Location = new System.Drawing.Point(663, 330);
            this.Pic_HSV.Name = "Pic_HSV";
            this.Pic_HSV.Size = new System.Drawing.Size(250, 250);
            this.Pic_HSV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic_HSV.TabIndex = 0;
            this.Pic_HSV.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(663, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Hinh_XYZ";
            // 
            // Chuyen_doi_khong_gian_mau_HSI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 638);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.H);
            this.Controls.Add(this.Pic_HSV);
            this.Controls.Add(this.Pic_goc);
            this.Controls.Add(this.Pic_V);
            this.Controls.Add(this.Pic_saturation);
            this.Controls.Add(this.Pic_hue);
            this.Name = "Chuyen_doi_khong_gian_mau_HSI";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Pic_hue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_saturation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_V)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_goc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_HSV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Pic_hue;
        private System.Windows.Forms.Label H;
        private System.Windows.Forms.PictureBox Pic_saturation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Pic_V;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox Pic_goc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox Pic_HSV;
        private System.Windows.Forms.Label label3;
    }
}

