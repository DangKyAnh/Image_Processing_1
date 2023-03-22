
namespace Histogram_Xam_1._0
{
    partial class Form1
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
            this.Pic_Goc = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Pic_Xam = new System.Windows.Forms.PictureBox();
            this.Bieu_do_His = new ZedGraph.ZedGraphControl();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Goc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Xam)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Anh_Goc";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Pic_Goc
            // 
            this.Pic_Goc.Location = new System.Drawing.Point(12, 33);
            this.Pic_Goc.Name = "Pic_Goc";
            this.Pic_Goc.Size = new System.Drawing.Size(290, 233);
            this.Pic_Goc.TabIndex = 1;
            this.Pic_Goc.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Anh_Xam";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // Pic_Xam
            // 
            this.Pic_Xam.Location = new System.Drawing.Point(12, 303);
            this.Pic_Xam.Name = "Pic_Xam";
            this.Pic_Xam.Size = new System.Drawing.Size(290, 233);
            this.Pic_Xam.TabIndex = 1;
            this.Pic_Xam.TabStop = false;
            // 
            // Bieu_do_His
            // 
            this.Bieu_do_His.Location = new System.Drawing.Point(319, 33);
            this.Bieu_do_His.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Bieu_do_His.Name = "Bieu_do_His";
            this.Bieu_do_His.ScrollGrace = 0D;
            this.Bieu_do_His.ScrollMaxX = 0D;
            this.Bieu_do_His.ScrollMaxY = 0D;
            this.Bieu_do_His.ScrollMaxY2 = 0D;
            this.Bieu_do_His.ScrollMinX = 0D;
            this.Bieu_do_His.ScrollMinY = 0D;
            this.Bieu_do_His.ScrollMinY2 = 0D;
            this.Bieu_do_His.Size = new System.Drawing.Size(681, 503);
            this.Bieu_do_His.TabIndex = 2;
            this.Bieu_do_His.UseExtendedPrintDialog = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 579);
            this.Controls.Add(this.Bieu_do_His);
            this.Controls.Add(this.Pic_Xam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Pic_Goc);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Goc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Xam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Pic_Goc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox Pic_Xam;
        private ZedGraph.ZedGraphControl Bieu_do_His;
    }
}

