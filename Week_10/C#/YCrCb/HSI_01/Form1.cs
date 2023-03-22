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
            Bitmap Anh_Y = new Bitmap(Anh_1, Anh_1.Size);
            Bitmap Anh_Cr = new Bitmap(Anh_1, Anh_1.Size);
            Bitmap Anh_Cb = new Bitmap(Anh_1, Anh_1.Size);
            Bitmap Anh_YCrCb = new Bitmap(Anh_1, Anh_1.Size);
            int x, y;
            for (x = 0; x < Anh_1.Width; x++)
            {
                for (y = 0; y < Anh_1.Height; y++)
                {
                    Color Mau_sac = Anh_1.GetPixel(x, y);

                    Double R = Mau_sac.R;
                    Double G = Mau_sac.G;
                    Double B = Mau_sac.B;

                    Double Y_ = 16 + ((65.738 * R) + (129.057 * G) + (25.064 * B)) / 256;
                    Double Cr_ = 128 + (-(37.945 * R) - (74.494 * G) + (112.439 * B)) / 256 ;
                    Double Cb_ = 16 + ((112.439 * R) - (94.154 * G) - (18.285 * B)) / 256 ; 


                    Anh_Y.SetPixel(x, y, Color.FromArgb((Byte)Y_, (Byte)Y_, (Byte)Y_));
                    Anh_Cr.SetPixel(x, y, Color.FromArgb((Byte)Cr_, (Byte)Cr_, (Byte)Cr_));
                    Anh_Cb.SetPixel(x, y, Color.FromArgb((Byte)Cb_, (Byte)Cb_, (Byte)Cb_));
                    Anh_YCrCb.SetPixel(x, y, Color.FromArgb((Byte)Y_, (Byte)Cr_, (Byte)Cb_));
                    

                }
            }

            Anh_show.Add(Anh_1);
            Anh_show.Add(Anh_Y);
            Anh_show.Add(Anh_Cr);
            Anh_show.Add(Anh_Cb);
            Anh_show.Add(Anh_YCrCb);

            return Anh_show;
        }
    }
}
