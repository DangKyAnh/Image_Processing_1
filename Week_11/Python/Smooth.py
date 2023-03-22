import cv2
import numpy as np
from PIL import Image

filepath_1 = r'Anh_01.jpg'

Anh_cv2 = cv2.imread(filename=filepath_1)
Anh_Process = Image.open(filepath_1)

# Tao ra cac kenh
Anh_Real = Image.new(Anh_Process.mode, Anh_Process.size)
Anh_7x7 = Image.new(Anh_Process.mode, Anh_Process.size)


# Quet anh
def anh_5(filepath, a):
    b = int((a-1)/2)
    Anh_Process = Image.open(filepath)
    Anh_5x5 = Image.new(Anh_Process.mode, Anh_Process.size)
    Height = Anh_Process.size[0]
    Width = Anh_Process.size[1]
    for x in range(b, Height - b):
        for y in range(b, Width - b):
            sumR = 0
            sumG = 0
            sumB = 0
            for i in range(x - b, x + b):
                for j in range(y - b, y + b):
                    R, G, B = Anh_Process.getpixel((i,j))
                    sumR = sumR + R
                    sumG = sumG + G
                    sumB = sumB + B
            Anh_5x5.putpixel((x,y), (sumR, sumG, sumB))

            R2, G2, B2 = Anh_Process.getpixel((x,y))
            Anh_Real.putpixel((x,y), (R2,G2,B2))

    Anh_5x5_out = np.array(Anh_5x5)
    cv2.imshow('Anh Smooth', Anh_5x5_out)


anh_5(filepath = filepath_1, a=3)
Anh_Real_out = np.array(Anh_Real)
cv2.imshow('Anh Real', Anh_Real_out)

cv2.waitKey(0)