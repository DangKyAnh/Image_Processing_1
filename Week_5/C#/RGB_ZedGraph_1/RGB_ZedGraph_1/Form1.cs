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

namespace RGB_ZedGraph_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            String file_path = @"C:\Users\user\Desktop\Image_Processing\Week_5\C#\Anh_01.jpg";
            Bitmap Anh = new Bitmap(file_path);
            Pic_goc.Image = Anh;
            double[,] Data = Vao_mang(Anh);
            List<PointPairList> Data_doi_his = Chuyen_doi_so( Data);
            GraphPane Ve = Ve_histogram(Data_doi_his);
            Zed_1.GraphPane = Ve;
            Zed_1.Refresh();


        }
        // Hàm chuyển đổi ảnh sang ảnh xam, ở bài này không cần hàm này 
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

        // Hàm lấy dữ liệu từ ảnh gốc để lấy ra 3 gia trị màu R-G-B để lưu vào mảng A 
        public double[,] Vao_mang(Bitmap Hinh)
        {
            // Tạo ra mảng 2 chiều có 3 lớp mỗi lớp có 256 phần tử 
            double[,] his = new double[3,256];
            int x, y;
            for (x = 0; x < Hinh.Width; x++)
            {
                for (y = 0; y < Hinh.Height; y++)
                {
                    Color Mau_sac = Hinh.GetPixel(x, y);
                    Byte R = Mau_sac.R;
                    Byte G = Mau_sac.G;
                    Byte B = Mau_sac.B;

                    // Lưu từng giá trị màu vào mảng để hậu xử lí 
                    his[0, R]++;
                    his[1, G]++;
                    his[2, B]++;
                }
            }

            return his;
        }

        // Hàm xử lí mảng A để đưa về kiểu dữ liệu để vẽ biểu đồ trên thư viện ZedGraph 
        public List<PointPairList> Chuyen_doi_so(double[,] his)
        {
            // Tạo mảng đa chiều theo kiểu dữ liệu PointPairlist 
            List<PointPairList> Point = new List<PointPairList>();
            // Tạo mảng 1 chiều theo kiểu PointPairList 
            PointPairList Red_Point = new PointPairList();
            PointPairList Green_Point = new PointPairList();
            PointPairList Blue_Point = new PointPairList();

            for (int i = 0; i < 256; i++)
            {
                // Thêm dữ liệu vào biến bên kiểu ZedGraph 
                Red_Point.Add(i, his[0,i]);
                Green_Point.Add(i, his[1, i]);
                Blue_Point.Add(i, his[2, i]);
            }

            // Sau khi thêm từ mảng trên ta thêm 3 mảng trên vào Mảng đa chiều đã tạo từ ban đầu 
            Point.Add(Red_Point);
            Point.Add(Green_Point);
            Point.Add(Blue_Point);

            return Point;
        }

        public GraphPane Ve_histogram(List<PointPairList> His_2)
        {
            GraphPane gp = new GraphPane();

            gp.Title.Text = @"Bieu do Histogram";
            gp.Rect = new Rectangle(0, 0, 500, 400);
            gp.XAxis.Title.Text = @"Gia tri mau R-G-B";
            gp.XAxis.Scale.Min = 0;
            gp.XAxis.Scale.Max = 255;
            gp.XAxis.Scale.MajorStep = 5;  // bước chính, bước lớn 
            gp.XAxis.Scale.MinorStep = 1;  // bước nhỏ 

            gp.YAxis.Title.Text = @"So lan xuat hien";
            gp.YAxis.Scale.Min = 0;
            gp.YAxis.Scale.Max = 6000; // giá trị maximum tùy theo bức ảnh mà có giá trị max khác nha, ở đây chọn tùy ý là 6000 
            gp.YAxis.Scale.MajorStep = 5;
            gp.YAxis.Scale.MinorStep = 1;

            // Vẽ dữ liệu lên Biểu đồ theo dạng bar(cột chữ nhật) theo từng dãy màu 
            gp.AddBar("Histogram_Red", His_2[0], Color.Red);
            gp.AddBar("Histogram_Green", His_2[1], Color.Green);
            gp.AddBar("Histogram_Blue", His_2[2], Color.Blue); ;

            return gp;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
