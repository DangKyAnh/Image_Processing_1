import cv2
import numpy as np
from PIL import Image 

file_path = r'Kien_Giang.jpg'

Anh_1 = cv2.imread(file_path, cv2.IMREAD_COLOR)
Anh_Xam = cv2.cvtColor(Anh_1, cv2.COLOR_BGR2GRAY)
Anh_Bin = np.zeros_like(Anh_Xam)

# Define a function to update the binary image based on the current threshold value
def update_binary_image(threshold_value):
    ret, Anh_Bin = cv2.threshold(Anh_Xam, threshold_value, 255, cv2.THRESH_BINARY)
    cv2.imshow('Anh nhi phan', Anh_Bin)

# Create a window for the binary image and a trackbar to adjust the threshold value
cv2.namedWindow('Anh nhi phan')
cv2.createTrackbar('Ngưỡng', 'Anh nhi phan', 0, 255, update_binary_image)

# Initialize the binary image with the current threshold value
initial_threshold_value = cv2.getTrackbarPos('Ngưỡng', 'Anh nhi phan')
update_binary_image(initial_threshold_value)

cv2.imshow('Anh goc', Anh_1)
cv2.waitKey(0)
cv2.destroyAllWindows()
