using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MP4_Binary_01
{
    public partial class Form1 : Form
    {
        Bitmap Anh_;
        public Form1()
        {
            InitializeComponent();

            string Path_file = @"C:\Users\user\Desktop\Image_Processing\MP4_Binary_01\MP4_Binary_01\Flower.jpg";

            Anh_ = new Bitmap(Path_file);
            Pic_Goc.Image = Anh_;
            Pic_Xam.Image = Average(Anh_);
            Pic_nhi_phan.Image = Binary(Anh_ , 100);

        }
        public Bitmap Average(Bitmap Anh)
        {
            Bitmap Anh_Avg = new Bitmap(Anh.Width, Anh.Height);

            for (int x = 0; x < Anh.Width; x++)
            {
                for (int y = 0; y < Anh.Height; y++)
                {
                    Color Mau_sac = Anh.GetPixel(x, y);
                    byte R = Mau_sac.R;
                    byte G = Mau_sac.G;
                    byte B = Mau_sac.B;

                    int Gray_Avg = (R + G + B) / 3;

                    Anh_Avg.SetPixel(x, y, Color.FromArgb(Gray_Avg, Gray_Avg, Gray_Avg));
                }
            }

            return Anh_Avg;
        }

        public Bitmap Binary(Bitmap Anh, int nguong)
        {
            Bitmap Anh_Bin = new Bitmap(Anh.Width, Anh.Height);

            for (int x = 0; x < Anh.Width; x++)
            {
                for (int y = 0; y < Anh.Height; y++)
                {
                    Color Mau_sac = Anh.GetPixel(x, y);
                    byte R = Mau_sac.R;
                    byte G = Mau_sac.G;
                    byte B = Mau_sac.B;
                    
                    int Gray_Avg = (R + G + B) / 3;
                    if(Gray_Avg >= nguong)
                    {
                        Anh_Bin.SetPixel(x, y, Color.FromArgb(255, 255, 255));
                    }
                    else if (Gray_Avg < nguong)
                    {
                        Anh_Bin.SetPixel(x, y, Color.FromArgb(0, 0, 0));
                    }

                }
            }

            return Anh_Bin;
        }

        private void vScrollBar1_ValueChanged(object sender, EventArgs e)
        {
            // khai báo biến ngưỡng 

            int nguong = Slide_nguong.Value;
            // Dua gia tri hien thi len lable Gia_tri_nguong vs ep kieu ve String
            Gia_tri_nguong.Text = nguong.ToString();
            // Hien thi anh len Anh_nhi_phan
            Pic_nhi_phan.Image = Binary(Anh_, nguong);

        }
    }
}
