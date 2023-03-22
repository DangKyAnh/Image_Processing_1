import cv2
from PIL import Image
import numpy as np

# Khai bao duong dan 
path = r'Anh_01.jpg'
# Doc anh bang thu vien PIL
Image_Read = Image.open(path)
#Tao khung anh moi
Image_Frame = Image.new(Image_Read.mode, Image_Read.size)
# Lay kich thuoc anh
Chieu_dai = Image_Read.size[0]
Chieu_rong = Image_Read.size[1]

# Quet diem anh theo x, y 
for x in range(Chieu_dai):
    for y in range(Chieu_rong):
        # Lay gia tri R,G,B tai pixel toa do x,y
        R, G, B = Image_Read.getpixel((x,y))

        # Tinh Gray theo CT Luminance
        Gray = np.uint8(R*0.2126 + G*0.7152 + B*0.0722)

        #Dat pixel gray
        Image_Frame.putpixel((x,y), (Gray, Gray, Gray))

# Convert tu PIL sang CV2
Luminance = np.array(Image_Frame)

cv2.imshow('Anh muc xam Luminance', Luminance)

cv2.waitKey(0)