import cv2
import numpy as np
from PIL import Image 

file_path = r'Kien_Giang.jpg'

Anh_ = Image.open(file_path)


Anh_1 = cv2.imread(file_path, cv2.IMREAD_COLOR)
Anh_Xam = Image.new(Anh_.mode, Anh_.size)
Anh_Bin = Image.new(Anh_.mode, Anh_.size)
Anhbin = Image.new(Anh_.mode, Anh_.size)

chieu_dai = Anh_.size[0]
chieu_rong = Anh_.size[1]
_nguong = 120


for x in range(chieu_dai):
    for y in range(chieu_rong):
        R, G, B = Anh_.getpixel((x,y))

        Gray = np.uint8((R+G+B)/3)

        Anh_Xam.putpixel((x,y), (Gray, Gray, Gray))

        if (Gray >= _nguong):
            Anh_Bin.putpixel((x,y), (255,255,255))
        elif (Gray < _nguong):
            Anh_Bin.putpixel((x,y), (0,0,0))

Anh_Bin_ = np.array(Anh_Bin)
Anh_Xam_ = np.array(Anh_Xam)

def cap_nhat_Bin(Value_Nguong):
    Anh_Bin = Anh_Xam.point(lambda i: 255 if i >= Value_Nguong else 0)
    Anhbin = np.array(Anh_Bin)
    cv2.imshow('Anh_changed', Anhbin)


cv2.namedWindow('Anh nhi phan')
cv2.createTrackbar('Nguong_','Anh nhi phan', 0, 255, cap_nhat_Bin)

Value_ = cv2.getTrackbarPos('Nguong_', 'Anh nhi phan')
cap_nhat_Bin(Value_)

cv2.imshow('Anh goc: ', Anh_1)
cv2.imshow('Anh nhi phan: ', Anh_Bin_)


cv2.waitKey(0)
cv2.destroyAllWindows()

