import cv2
import numpy as np
from PIL import Image 
import matplotlib.pyplot as plt
import math

file_path = r'Anh_02.jpg'

Anh = cv2.imread(file_path)
Anh_ = Image.open(file_path)
Anh_H = Image.new(Anh_.mode, Anh_.size)
Anh_S = Image.new(Anh_.mode, Anh_.size)
Anh_I = Image.new(Anh_.mode, Anh_.size)

cao = Anh_.size[0]
rong = Anh_.size[1]

for x in range(cao):
    for y in range(rong):
        R, G, B = Anh_.getpixel((x,y))

        # Tinh H
        t1 = float(R-G)+(R-B)
        t2 = float((R-G)**2 + (R-B)*(G-B))**(0.5)
        if t2 == 0:
            t3 = 0
        else:
            t3 = float(t1/t2)
        if t3 < -1:
            t3 = -1
        elif t3 > 1:
            t3 = 1

        theta_ = math.acos(t3)
        theta = (theta_/(math.pi*2))*360
        if (B <= G):
            H = theta
        elif(B > G):
            H = 360 - theta

        # Tinh S
        S = 1 - (3*(min(R,G,B)/(R+G+B)))
        if S < 0:
            S = 0

        # Tinh I
        I = (R+G+B)/3

        Anh_H.putpixel((x,y), (int(H), int(H), int(H)))
        Anh_S.putpixel((x,y), (int(S*255), int(S*255), int(S*255)))
        Anh_I.putpixel((x,y), (int(I), int(I), int(I)))


Anh_H_ = np.array(Anh_H)
Anh_S_ = np.array(Anh_S)
Anh_I_ = np.array(Anh_I)

cv2.imshow('Anh Goc', Anh)
cv2.imshow('Anh H', Anh_H_)
cv2.imshow('Anh S', Anh_S_)
cv2.imshow('Anh I', Anh_I_)

cv2.waitKey(0)
