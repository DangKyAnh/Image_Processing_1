using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smooth
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            String filepath = @"C:\Users\user\Desktop\Image_Processing\Week_11\C#\Anh_Art.jpg";
            Bitmap Anh_1 = new Bitmap(filepath);
            Bitmap Anh_Smth_3x3 = Smooth_aXa(Anh_1, 3);
            Bitmap Anh_Smth_5x5 = Smooth_aXa(Anh_1, 5);
            Bitmap Anh_Smth_7x7 = Smooth_aXa(Anh_1, 7);
            Bitmap Anh_Smth_NxN = Smooth_aXa(Anh_1, 21);

            Pic_Goc.Image = Anh_1;
            Pic_3x3.Image = Anh_Smth_3x3;
            Pic_5x5.Image = Anh_Smth_5x5;
            Pic_7x7.Image = Anh_Smth_7x7;
            Pic_NxN.Image = Anh_Smth_NxN;
        }

        public Bitmap Smooth_aXa(Bitmap Anh_0, int b)
        {
            Bitmap Anh_Read = new Bitmap(Anh_0);
            Bitmap Anh_Smooth = new Bitmap(Anh_Read, Anh_Read.Size);
            int a = (b - 1) / 2;
            int x, y;
            int Height = Anh_Read.Height;
            int Width = Anh_Read.Width;

            for (x = a; x < Width-a; x++)
            {
                for (y = a; y < Height-a; y++)
                {
                    double sumR = 0;
                    double sumG = 0;
                    double sumB = 0;
                    for (int i = x - a; i < x + a; i++)
                    {
                        for (int j = y - a; j < y + a; j++)
                        {
                            Color Mau_sac = Anh_Read.GetPixel(i, j);
                            double R = Mau_sac.R;
                            double G = Mau_sac.G;
                            double B = Mau_sac.B;

                            sumR = sumR + R;
                            sumG = sumG + G;
                            sumB = sumB + B;
                        }
                    }
                    sumR = sumR / (b * b);
                    sumG = sumG / (b * b);
                    sumB = sumB / (b * b);

                    Anh_Smooth.SetPixel(x, y, Color.FromArgb((int)sumR, (int)sumG, (int)sumB));
                }
            }
            return Anh_Smooth; 
        }
    }
}
