import cv2
import dlib
import numpy as np

# Load the detector and predictor
detector = dlib.get_frontal_face_detector()
predictor = dlib.shape_predictor("shape_predictor_68_face_landmarks.dat")

# Load the trained model
model = cv2.face.LBPHFaceRecognizer_create()
model.read('trained_model.xml')

# Capture the video stream from the default camera
cap = cv2.VideoCapture(0)

while True:
    # Read a frame from the video stream
    ret, frame = cap.read()

    # Convert the frame to grayscale
    gray = cv2.cvtColor(frame, cv2.COLOR_BGR2GRAY)

    # Detect faces in the grayscale image
    faces = detector(gray)

    # Loop through each detected face
    for face in faces:
        # Get the face landmarks
        landmarks = predictor(gray, face)

        # Convert the landmarks to a NumPy array
        landmarks_array = np.array([[p.x, p.y] for p in landmarks.parts()])

        # Get the region of interest (ROI) for the face
        x1, y1 = landmarks_array[0]
        x2, y2 = landmarks_array[16]
        roi = gray[y1:y2, x1:x2]

        # Resize the ROI to a fixed size
        roi = cv2.resize(roi, (100, 100))

        # Recognize the face using the trained model
        label, confidence = model.predict(roi)

        # Draw a rectangle around the face and display the label and confidence
        cv2.rectangle(frame, (face.left(), face.top()), (face.right(), face.bottom()), (0, 0, 255), 2)
        cv2.putText(frame, "Label: {}".format(label), (face.left(), face.top() - 10), cv2.FONT_HERSHEY_SIMPLEX, 0.5, (0, 0, 255), 2)
        cv2.putText(frame, "Confidence: {:.2f}".format(confidence), (face.left(), face.bottom() + 10), cv2.FONT_HERSHEY_SIMPLEX, 0.5, (0, 0, 255), 2)

    # Display the frame
    cv2.imshow("Facial Recognition", frame)

    # Exit if the user presses the 'q' key
    if cv2.waitKey(1) & 0xFF == ord('q'):
        break

# Release the video stream and close all windows
cap.release()
cv2.destroyAllWindows()
