using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph; 

namespace Histogram_Xam_1._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        public Chuyen_doi_anh_Xam()
        {
            String file_path = @"C:\Users\user\Desktop\Image_Processing\Week_5\C#\Anh_01.jpg";
            Bitmap anh = new Bitmap(file_path);
            Bitmap khung_1 = new Bitmap(anh.Height, anh.Width);

            int x, y;
            for (x = 0; x < anh.Height; x++)
            {
                for (y = 0; y < anh.Width; y++)
                {
                    Color Mau = anh.GetPixel(x, y);
                    byte R = Mau.R;
                    byte G = Mau.G;
                    byte B = Mau.B;

                    int Gray = (int)((R + G + B) / 3);
                    khung_1.SetPixel(x, y, Color.FromArgb(0, 0, 0));

                }
            }

        }

        public (byte, byte, byte) Color { get; private set; }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
