import cv2
import numpy as np
from PIL import Image 
import matplotlib.pyplot as plt
import math

file_path = r'Anh_01.jpg'

Anh = cv2.imread(file_path)
Anh_ = Image.open(file_path)
Anh_X = Image.new(Anh_.mode, Anh_.size)
Anh_Y = Image.new(Anh_.mode, Anh_.size)
Anh_Z = Image.new(Anh_.mode, Anh_.size)
Anh_XYZ = Image.new(Anh_.mode, Anh_.size)

cao = Anh_.size[0]
rong = Anh_.size[1]

for x in range(cao):
    for y in range(rong):
        R, G, B = Anh_.getpixel((x,y))
        M = np.array([[R], [G], [B]])
        N = np.array([[0.4124564, 0.3575761, 0.1804375], [0.2126729, 0.7151522, 0.0721750], [0.0193339, 0.1191920, 0.9503041]])
        P = np.matmul(N,M) 


        Anh_X.putpixel((x,y), (int(P[0]), int(P[0]), int(P[0]) ))
        Anh_Y.putpixel((x,y), (int(P[1]), int(P[1]), int(P[1]) ))
        Anh_Z.putpixel((x,y), (int(P[2]), int(P[2]), int(P[2]) ))
        Anh_XYZ.putpixel((x,y), (int(P[0]), int(P[1]), int(P[2]) ))


Anh_X_ = np.array(Anh_X)
Anh_Y_ = np.array(Anh_Y)
Anh_Z_ = np.array(Anh_Z)
Anh_XYZ_ = np.array(Anh_XYZ)

cv2.imshow('Anh Goc', Anh)
cv2.imshow('Anh X', Anh_X_)
cv2.imshow('Anh Y', Anh_Y_)
cv2.imshow('Anh Z', Anh_Z_)
cv2.imshow('Anh XYZ', Anh_XYZ_)

print(P)

cv2.waitKey(0)
