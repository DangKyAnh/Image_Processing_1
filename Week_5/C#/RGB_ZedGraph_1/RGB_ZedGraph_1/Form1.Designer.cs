
namespace RGB_ZedGraph_1
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
            this.Pic_goc = new System.Windows.Forms.PictureBox();
            this.Zed_1 = new ZedGraph.ZedGraphControl();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_goc)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Pic_goc
            // 
            this.Pic_goc.Location = new System.Drawing.Point(12, 29);
            this.Pic_goc.Name = "Pic_goc";
            this.Pic_goc.Size = new System.Drawing.Size(227, 253);
            this.Pic_goc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic_goc.TabIndex = 1;
            this.Pic_goc.TabStop = false;
            // 
            // Zed_1
            // 
            this.Zed_1.Location = new System.Drawing.Point(246, 29);
            this.Zed_1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Zed_1.Name = "Zed_1";
            this.Zed_1.ScrollGrace = 0D;
            this.Zed_1.ScrollMaxX = 0D;
            this.Zed_1.ScrollMaxY = 0D;
            this.Zed_1.ScrollMaxY2 = 0D;
            this.Zed_1.ScrollMinX = 0D;
            this.Zed_1.ScrollMinY = 0D;
            this.Zed_1.ScrollMinY2 = 0D;
            this.Zed_1.Size = new System.Drawing.Size(600, 500);
            this.Zed_1.TabIndex = 2;
            this.Zed_1.UseExtendedPrintDialog = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 594);
            this.Controls.Add(this.Zed_1);
            this.Controls.Add(this.Pic_goc);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Pic_goc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Pic_goc;
        private ZedGraph.ZedGraphControl Zed_1;
    }
}

