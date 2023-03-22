import cv2
import numpy as np
from PIL import Image 
import matplotlib.pyplot as plt
import math

file_path = r'Anh_01.jpg'

Anh = cv2.imread(file_path)
Anh_ = Image.open(file_path)
Anh_Y = Image.new(Anh_.mode, Anh_.size)
Anh_Cr = Image.new(Anh_.mode, Anh_.size)
Anh_Cb = Image.new(Anh_.mode, Anh_.size)
Anh_YCrCb = Image.new(Anh_.mode, Anh_.size)

cao = Anh_.size[0]
rong = Anh_.size[1]

for x in range(cao):
    for y in range(rong):
        R, G, B = Anh_.getpixel((x,y))
        Y = 16 + ((65.738*R) + (129.057*G) + (25.064*B))/256
        Cr = 128 + (-(37.945*R) - (74.494*G) + (112.439*B))/256
        Cb = 16 + ((112.439*R) - (94.154*G) - (18.285*B))/256

        Anh_Y.putpixel((x,y), (int(Y), int(Y), int(Y) ))
        Anh_Cr.putpixel((x,y), (int(Cr), int(Cr), int(Cr) ))
        Anh_Cb.putpixel((x,y), (int(Cb), int(Cb), int(Cb) ))
        Anh_YCrCb.putpixel((x,y), (int(Y), int(Cr), int(Cb) ))


Anh_Y_ = np.array(Anh_Y)
Anh_Cr_ = np.array(Anh_Y)
Anh_Cb_ = np.array(Anh_Cb)
Anh_YCrCb_ = np.array(Anh_YCrCb)

cv2.imshow('Anh Goc', Anh)
cv2.imshow('Anh Y', Anh_Y_)
cv2.imshow('Anh Cr', Anh_Cr_)
cv2.imshow('Anh Cb', Anh_Cb_)
cv2.imshow('Anh YCrCb', Anh_YCrCb_)


cv2.waitKey(0)
