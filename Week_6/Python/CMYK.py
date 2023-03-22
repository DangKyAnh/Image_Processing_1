import cv2
import numpy as np
from PIL import Image 



file_path = r'Anh_01.jpg'


def Anh_CMYK(anh):
    Anh_ = Image.open(anh)
    Anh_1 = Image.new(Anh_.mode, Anh_.size)
    Anh_Cyan = Image.new(Anh_.mode, Anh_.size)
    Anh_Magenta = Image.new(Anh_.mode, Anh_.size)
    Anh_Yellow = Image.new(Anh_.mode, Anh_.size)
    Anh_Black = Image.new(Anh_.mode, Anh_.size)

    Height = Anh_1.size[0]
    Width = Anh_1.size[1]

    for x in range(Height):
        for y in range(Width):
            R, G, B = Anh_.getpixel((x,y))
            Black = np.uint8(min(R,G,B))

            Anh_Yellow.putpixel((x,y), (0,G,B))
            Anh_Magenta.putpixel((x,y),(R,0,B))
            Anh_Cyan.putpixel((x,y),(R,G,0))
            Anh_Black.putpixel((x,y),(Black,Black,Black))

    Anh_Magenta_1 = np.array(Anh_Magenta)
    Anh_Cyan_1 = np.array(Anh_Cyan)
    Anh_Yellow_1 = np.array(Anh_Yellow)
    Anh_Black_1 = np.array(Anh_Black)

    Anh_2 = np.array([])
    Anh_2 = np.concatenate((Anh_Cyan_1, Anh_Magenta_1, Anh_Yellow_1, Anh_Black_1))
    # Anh_2 = np.concatenate([Anh_Magenta_1])
    # Anh_2 = np.append(Anh_Magenta_1, axis = 0)
    # Anh_2 = np.append(Anh_Yellow_1, axis = 0)
    # Anh_2 = np.append(Anh_Black_1, axis = 0)

    return Anh_2     

Anh_Final = Anh_CMYK(file_path)

A = cv2.imread(file_path, cv2.IMREAD_COLOR)

cv2.imshow('01: ', A)
# cv2.imshow('Anh Cyan: ', Anh_Final[0])
cv2.imshow('Cyan', Anh_Final[:Anh_Final.shape[0]//4])
cv2.imshow('Magenta', Anh_Final[Anh_Final.shape[0]//4:Anh_Final.shape[0]//2])
cv2.imshow('Yellow', Anh_Final[Anh_Final.shape[0]//2:3*Anh_Final.shape[0]//4])
cv2.imshow('Black', Anh_Final[3*Anh_Final.shape[0]//4:])

# Liet ke tu A den B ta dung dau ":"
# Boi vi do la mot mang dai nen ta phai lay tung khoang 1/4, Neu muon dung phep chia trong mang ta dung dau "//"
# Ham shape se liet ke cho kich thuoc cua mang 

# B = np.array([])
# B = [[[0,1], [1,2],[1,3]], [[2,1], [2,2],[2,3]], [1],[]]

print(Anh_Final.shape[0]//4)
# print(B[:0])

cv2.waitKey(0)

