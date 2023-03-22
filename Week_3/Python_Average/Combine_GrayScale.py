import cv2
import numpy as np
from PIL import Image 

# Khai bao duong dan file hinh
file_01 = r'Anh_02.jpg'

#Doc hinh anh bang thu vien PIL
Image_01 = Image.open(file_01)
Image_02 = cv2.imread(file_01, cv2.IMREAD_COLOR)

# Tao khung co kich thuoc dinh dang nhu hinh mau file_01
Image_Avg = Image.new(Image_01.mode, Image_01.size)
Image_Lig = Image.new(Image_01.mode, Image_01.size)
Image_Lum = Image.new(Image_01.mode, Image_01.size)

# Lay kich thuoc cua anh 
Chieu_dai = Image_Avg.size[0]
Chieu_rong = Image_Avg.size[1]

# Lay kich thuoc quet theo 2 chieu x vs y
for x in range(Chieu_dai):
    for y in range(Chieu_rong):
        # Lay 3 gia tri mau R,G,B
        R, G, B = Image_01.getpixel((x,y))

        # Tinh toan GrayScale theo pp Average
        Gray_Avg = np.uint8((R+G+B)/3)
        # Tinh toan GrayScale theo pp Lightless
        MAX = max(R,G,B)
        MIN = min(R,G,B)
        Gray_Lig = np.uint8((MAX+MIN)/2)
        # Tinh toan GrayScale theo pp Luminance
        Gray_Lum = np.uint8(R*0.2126 + G*0.7152 + B*0.0722)

        #Set gia tri muc xam gray vua tinh vao cac pixel tai do
        Image_Avg.putpixel((x,y), (Gray_Avg, Gray_Avg, Gray_Avg))
        Image_Lig.putpixel((x,y), (Gray_Lig, Gray_Lig, Gray_Lig))
        Image_Lum.putpixel((x,y), (Gray_Lum, Gray_Lum, Gray_Lum))

# Convert tu PIL sang OpenCV
Image_Avg_CV = np.array(Image_Avg)
Image_Lig_CV = np.array(Image_Lig)
Image_Lum_CV = np.array(Image_Lum)

print(type(Image_Avg_CV))
print(type(Image_02))
print(type(Image_Avg))

# Show anh bang OpenCV
cv2.imshow('Anh_goc', Image_02)
cv2.imshow('Average', Image_Avg_CV)
cv2.imshow('Lightless', Image_Lig_CV)
cv2.imshow('Luminance', Image_Lum_CV)
cv2.waitKey(0)
