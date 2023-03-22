using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.UI;
using Emgu.CV.Structure;
namespace Tesst_MP_1
{
    public partial class Hien_thi : Form
    {
        public Hien_thi()
        {
            InitializeComponent();
            /*Image<Bgr, byte> Hinh = new Image<Bgr, byte> (@"C:\Users\user\Desktop\Image_Processing\Tesst_MP_1\Cat03.jpg");
            Pic_01.Image = Hinh; */

            // Lưu đường dân vào biến "pic"
            string pic = @"C:\Users\user\Desktop\Image_Processing\Tesst_MP_1\Cat03.jpg";

            // Khai báo biến Bitmap
            //Image<Bgr, byte> hinh = new Image<Bgr, byte>(pic);
            Bitmap hinh = new Bitmap(pic);

            // Hiển thị hình ảnh 
            Pic_01.Image = hinh;

            // Khai báo 3 hình R-G-B
            Bitmap Red = new Bitmap(hinh.Width, hinh.Height);
            Bitmap Green = new Bitmap(hinh.Width, hinh.Height);
            Bitmap Blue = new Bitmap(hinh.Width, hinh.Height);
            int x, y;
            for (x = 0; x < hinh.Width; x++ )
            {
                for (y = 0; y < hinh.Height; y++)
                {
                    // Khai bao de lay gia tri mau tai pixel toa do x va y
                    Color Mau_sac = hinh.GetPixel(x, y);

                    // Lay gia tri tung mau Red Green Blue va do trong suot
                    Byte R = Mau_sac.R;
                    Byte G = Mau_sac.G;
                    Byte B = Mau_sac.B;
                    Byte A = Mau_sac.A;

                    // Set hinh anh len 4 kenh chi 1 mau
                    Red.SetPixel(x, y, Color.FromArgb(A, R, 0, 0));
                    Green.SetPixel(x, y, Color.FromArgb(A, 0, G, 0));
                    Blue.SetPixel(x, y, Color.FromArgb(A, 0, 0, B));

                    // Hien thi hinh anh da set len 3 kenh
                    Pic_Red.Image = Red;
                    Pic_Green.Image = Green;
                    Pic_Blue.Image = Blue;




                }
            
            }

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
