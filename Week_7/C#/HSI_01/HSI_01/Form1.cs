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
            String file_path = @"C:\Users\user\Desktop\Image_Processing\Week_7\C#\HSI_01\Anh_01.jpg";
            Bitmap anh = new Bitmap(file_path);
            List<Bitmap> Anh_01 = Function_HSI(anh);

            Pic_goc.Image = Anh_01[0];
            Pic_hue.Image = Anh_01[1];
            Pic_saturation.Image = Anh_01[2];
            Pic_intensity.Image = Anh_01[3];

        }

        public List<Bitmap> Function_HSI(Bitmap Anh)
        {
            Bitmap Anh_1 = new Bitmap(Anh);
            List<Bitmap> Anh_show = new List<Bitmap>();
            Bitmap Anh_H = new Bitmap(Anh_1, Anh_1.Size);
            Bitmap Anh_S = new Bitmap(Anh_1, Anh_1.Size);
            Bitmap Anh_I = new Bitmap(Anh_1, Anh_1.Size);
            int x, y;
            for (x = 0; x < Anh_1.Height; x++)
            {
                for (y = 0; y < Anh_1.Width; y++)
                {
                    Color Mau_sac = Anh_1.GetPixel(x, y);

                    Double R = Mau_sac.R;
                    Double G = Mau_sac.G;
                    Double B = Mau_sac.B;

                    // Tinh goc theta cua H trong HSI
                    double s1 = 0.5 * ((R - G) + (R - B));
                    double s2 = Math.Pow(Math.Pow((R - G), 2) + (R - B) * (G - B), (1/2));
                    double cos_1 = s1 / s2;
                    double theta_1 = Math.Acos(cos_1);
                    double theta_2 = (theta_1 / (2 * Math.PI)) * 360;
                    double H_ = 0;
                    if (B <= G)
                    {
                        H_ = theta_2;
                    }
                    else if (B > G)
                    {
                        H_ = 360 - theta_2;
                    }

                    // Tinh S trong HSI
                    double minRGB = Math.Min(R, Math.Min(G, B));
                    double S_1 = 1 - ((3 * minRGB) / (R + G + B));
                    double S_ = S_1 * 255;

                    //Tinh he so I trong HSI
                    double I_ = (R + G + B) / 3;

                    Anh_H.SetPixel(x, y, Color.FromArgb((Byte)H_, (Byte)H_, (Byte)H_ ));
                    Anh_S.SetPixel(x, y, Color.FromArgb((Byte)S_, (Byte)S_, (Byte)S_));
                    Anh_I.SetPixel(x, y, Color.FromArgb((Byte)I_, (Byte)I_, (Byte)I_));

                }
            }

            Anh_show.Add(Anh_1);
            Anh_show.Add(Anh_H);
            Anh_show.Add(Anh_S);
            Anh_show.Add(Anh_I);

            return Anh_show;
        }
    }
}
