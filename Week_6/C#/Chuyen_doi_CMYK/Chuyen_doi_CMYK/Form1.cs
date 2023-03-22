using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chuyen_doi_CMYK
{
    public partial class Chuyen_Khong_Gian_Mau_CMYK : Form
    {
        public Chuyen_Khong_Gian_Mau_CMYK()
        {
            InitializeComponent();
            String file_path = @"C:\Users\user\Desktop\Image_Processing\Week_6\C#\Chuyen_doi_CMYK\Anh_01.jpg";
            Bitmap Anh_ = new Bitmap(file_path);
            Pic_Goc.Image = Anh_;
            List<Bitmap> Anh_CMYK_ = Function_CMYK(Anh_);

            Pic_Cyan.Image = Anh_CMYK_[0];
            Pic_Magenta.Image = Anh_CMYK_[1];
            Pic_Yellow.Image = Anh_CMYK_[2];
            Pic_Black.Image = Anh_CMYK_[3];

        }

        public List<Bitmap> Function_CMYK(Bitmap anh)
        {
            List<Bitmap> Anh_CMYK = new List<Bitmap>();
            Bitmap Anh_Cyan = new Bitmap(anh);
            Bitmap Anh_Magenta = new Bitmap(anh);
            Bitmap Anh_Yellow = new Bitmap(anh);
            Bitmap Anh_Black = new Bitmap(anh);

            int x, y;
            for (x = 0; x < anh.Width; x++)
            {
                for (y = 0; y < anh.Height; y++)
                {
                    Color Mau_sac = anh.GetPixel(x, y);

                    double R = Mau_sac.R;
                    double G = Mau_sac.G;
                    double B = Mau_sac.B;

                    double Black_ = Math.Min(R, Math.Min(G, B));

                    Anh_Cyan.SetPixel(x, y, Color.FromArgb(0, (Byte)G, (Byte)B) );
                    Anh_Magenta.SetPixel(x, y, Color.FromArgb((Byte)R, 0, (Byte)B));
                    Anh_Yellow.SetPixel(x, y, Color.FromArgb((Byte)R, (Byte)G, 0));
                    Anh_Black.SetPixel(x, y, Color.FromArgb((Byte)Black_, (Byte)Black_, (Byte)Black_));
                }

            }
            Anh_CMYK.Add(Anh_Cyan);
            Anh_CMYK.Add(Anh_Magenta);
            Anh_CMYK.Add(Anh_Yellow);
            Anh_CMYK.Add(Anh_Black);

            return Anh_CMYK;

        }


    }
}
