using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HSI_01
{
    public partial class Chuyen_doi_khong_gian_mau_HSI : Form
    {
        public Chuyen_doi_khong_gian_mau_HSI()
        {
            InitializeComponent();
            String file_path = @"C:\Users\user\Desktop\Image_Processing\Week_9\C#\0123.jpg";
            Bitmap anh = new Bitmap(file_path);
            List<Bitmap> Anh_01 = Function_HSI(anh);

            Pic_goc.Image = Anh_01[0];
            Pic_hue.Image = Anh_01[1];
            Pic_saturation.Image = Anh_01[2];
            Pic_V.Image = Anh_01[3];
            Pic_HSV.Image = Anh_01[4];

        }

        public List<Bitmap> Function_HSI(Bitmap Anh)
        {
            Bitmap Anh_1 = new Bitmap(Anh);
            List<Bitmap> Anh_show = new List<Bitmap>();
            Bitmap Anh_X = new Bitmap(Anh_1, Anh_1.Size);
            Bitmap Anh_Y = new Bitmap(Anh_1, Anh_1.Size);
            Bitmap Anh_Z = new Bitmap(Anh_1, Anh_1.Size);
            Bitmap Anh_XYZ = new Bitmap(Anh_1, Anh_1.Size);
            int x, y;
            for (x = 0; x < Anh_1.Width; x++)
            {
                for (y = 0; y < Anh_1.Height; y++)
                {
                    Color Mau_sac = Anh_1.GetPixel(x, y);

                    Double R = Mau_sac.R;
                    Double G = Mau_sac.G;
                    Double B = Mau_sac.B;

                    double [,] M = new double[3,3] { { 0.4124564, 0.3575761, 0.1804375 }, { 0.2126729, 0.7151522, 0.0721750 }, { 0.0193339, 0.1191920, 0.9503041 } };
                    double[,] N = new double[3, 1] { { R }, { G }, { B } };

                    double[,] P = new double[3, 1];

                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 1; j++)
                        {
                            double sum = 0;
                            for (int k = 0; k < 3; k++)
                            {
                                sum = sum + M[i, k] + N[k, j];
                            }
                            P[i, j] = sum;
                        }
                    }

                    double X_ = P[0, 0];
                    double Y_ = P[1, 0];
                    double Z_ = P[2, 0];

                    Anh_X.SetPixel(x, y, Color.FromArgb((Byte)X_, (Byte)X_, (Byte)X_ ));
                    Anh_Y.SetPixel(x, y, Color.FromArgb((Byte)Y_, (Byte)Y_, (Byte)Y_));
                    Anh_Z.SetPixel(x, y, Color.FromArgb((Byte)Z_, (Byte)Z_, (Byte)Z_));
                    Anh_XYZ.SetPixel(x, y, Color.FromArgb((Byte)X_, (Byte)Y_, (Byte)Z_));
                    

                }
            }

            Anh_show.Add(Anh_1);
            Anh_show.Add(Anh_X);
            Anh_show.Add(Anh_Y);
            Anh_show.Add(Anh_Z);
            Anh_show.Add(Anh_XYZ);

            return Anh_show;
        }
    }
}
