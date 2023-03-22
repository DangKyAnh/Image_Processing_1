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

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            String file_path = @"C:\Users\user\Desktop\Image_Processing\Week_5\C#\Anh_01.jpg";
            Bitmap anh = new Bitmap(file_path);
            pictureBox1.Image = anh;
            pictureBox2.Image = chuyen_Xam(anh);
            PointPairList a = Chuyen_doi_so(Vao_mang(anh));
            GraphPane b =  Ve_histogram(a);
            Zed_1.GraphPane = b;
            Zed_1.Refresh();
        }

        public Bitmap chuyen_Xam(Bitmap Anh)
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

        public double[] Vao_mang(Bitmap Hinh)
        {
            double[] his = new double[256];
            int x, y;
            for (x = 0; x < Hinh.Width; x++)
            {
                for (y = 0; y < Hinh.Height; y++)
                {
                    Color Mau_sac = Hinh.GetPixel(x,y);
                    Byte gray = Mau_sac.R;

                    his[gray]++;
                }
            }

            return his;
        }

        public PointPairList Chuyen_doi_so(double[] his)
        {
            PointPairList Point = new PointPairList() ;

            for (int i = 0; i < his.Length; i++)
            {
                Point.Add(i, his[i]);
            }
            return Point; 
        }

        public GraphPane Ve_histogram(PointPairList His_2)
        {
            GraphPane gp = new GraphPane();

            gp.Title.Text = @"Bieu do Histogram";
            gp.Rect = new Rectangle(0, 0, 500, 400);
            gp.XAxis.Title.Text = @"Gia tri mau Xam";
            gp.XAxis.Scale.Min = 0;
            gp.XAxis.Scale.Max = 255;
            gp.XAxis.Scale.MajorStep = 5;
            gp.XAxis.Scale.MinorStep = 1;

            gp.YAxis.Title.Text = @"So lan xuat hien";
            gp.YAxis.Scale.Min = 0;
            gp.YAxis.Scale.Max = 5000;
            gp.YAxis.Scale.MajorStep = 5;
            gp.YAxis.Scale.MinorStep = 1;

            gp.AddBar("Bieu do Histo", His_2, Color.OrangeRed);

            return gp;
        }
    }
}
