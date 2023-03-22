import cv2
import numpy as np
from PIL import Image 
import matplotlib.pyplot as plt



def Show_Pic_Xam(file_path_1):
    Anh_ = Image.open(file_path_1)
    Anh_Xam = Image.new(Anh_.mode, Anh_.size)

    chieu_dai = Anh_.size[0]
    chieu_rong = Anh_.size[1]
    for x in range(chieu_dai):
        for y in range(chieu_rong):
            R, G, B = Anh_.getpixel((x,y))
            Gray = np.uint8((R+G+B)/3)
            Anh_Xam.putpixel((x,y), (Gray, Gray, Gray))
    return Anh_Xam


def Caculate_Histogram_1(Anh_xam):
    his = np.zeros(256)
    # Lay 3 gia tri R,G,B
    chieu_dai = Anh_xam.size[0]
    chieu_rong = Anh_xam.size[1]
    for x in range(chieu_dai):
        for y in range(chieu_rong):
            gR, gG, gB = Anh_xam.getpixel((x,y))
            his[gR] += 1 # Bieu do histogram voi gia tri chi co mau xam
    return his


def Hien_thi_His(his):
    plt.figure('Bieu do His',figsize=(10,7), dpi = 100 )
    trux_X = np.zeros(256)
    truc_X = np.linspace(0,255,256)
    plt.plot(truc_X, his)
    plt.title('Bieu do Histogram')
    plt.xlabel('Gia_tri_kenh_xam')
    plt.ylabel('So lan xuat hien')
    plt.show()


file_path = r'C:\Users\user\Desktop\Image_Processing\Week_5\Python\Bieu_do_his_01\0123.jpg'
his_ = Caculate_Histogram_1(Show_Pic_Xam(file_path))
Hien_thi_His(his_)

cv2.waitKey(0)