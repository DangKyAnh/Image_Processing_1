import cv2
import numpy as np
from PIL import Image 
import matplotlib.pyplot as plt

file_path = r'Simens.jpg'


# Tao ham de doc anh va chuyen ve anh xam 
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

    Anh_Xam_ = np.array(Anh_Xam)
    return Anh_Xam_

cv2.imshow('Anh_Xam', Show_Pic_Xam(file_path))

# Ham de lay 3 gia tri mau RGB tu anh goc <NOT anh xam>
def Caculate_Histogram_1(file_path_2):
    Anh_ = Image.open(file_path_2)
    # Tao mang voi 256 gia tri
    his_R = np.zeros(256)
    # Lay 3 gia tri R,G,B
    chieu_dai = Anh_.size[0]
    chieu_rong = Anh_.size[1]
    for x in range(chieu_dai):
        for y in range(chieu_rong):
            R, G, B = Anh_.getpixel((x,y))
            his_R[R] += 1 # Bieu do histogram voi gia tri chi co mau do
    return his_R

def Caculate_Histogram_2(file_path_2):
    Anh_ = Image.open(file_path_2)
    his_G = np.zeros(256)
    # Lay 3 gia tri R,G,B
    chieu_dai = Anh_.size[0]
    chieu_rong = Anh_.size[1]
    for x in range(chieu_dai):
        for y in range(chieu_rong):
            R, G, B = Anh_.getpixel((x,y))
            his_G[G] += 1 # Bieu do histogram voi gia tri chi co mau xanh la
    return his_G

def Caculate_Histogram_3(file_path_2):
    Anh_ = Image.open(file_path_2)
    his_B = np.zeros(256)
    # Lay 3 gia tri R,G,B
    chieu_dai = Anh_.size[0]
    chieu_rong = Anh_.size[1]
    for x in range(chieu_dai):
        for y in range(chieu_rong):
            R, G, B = Anh_.getpixel((x,y))
            his_B[B] += 1 # Bieu do histogram voi gia tri chi co mau xanh duong
    return his_B

def Hien_thi_His():
    # Tạo ra 1 biểu đồ trắng với zize(10x7) inch vs mỗi inch sẽ có độ phân giải 100
    plt.figure('Bieu do His',figsize=(10,7), dpi = 100 )
    # Tạo ra môtj mảng có 256 gia trị
    trux_X = np.zeros(256)
    # Cách đưa giá trị vào trong mảng: Từ 0 -> 255, trong khoảng đó chia ra 256 bước => Mỗi bước là 1
    truc_X = np.linspace(0,255,256)
    # Tạo ra biểu đồ với trục X vừa khai báo, GT trục y là biểu đồ Histogram của từng màu R-G-B
    plt.plot(truc_X, Caculate_Histogram_1(file_path), 'r-', label = 'Red')
    plt.plot(truc_X, Caculate_Histogram_2(file_path), 'g-', label = 'Green')
    plt.plot(truc_X, Caculate_Histogram_3(file_path), 'b-', label = 'Blue')
    # Phải khai báo legend() để chú thích có hiệu lực 
    plt.legend()
    plt.title('Bieu do Histogram')
    plt.xlabel('Gia_tri_kenh_Red-Green-Blue')
    plt.ylabel('So lan xuat hien')
    plt.show()

Hien_thi_His()


cv2.waitKey(0)