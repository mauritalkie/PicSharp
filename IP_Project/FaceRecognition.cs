using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.Face;
using Emgu.CV.CvEnum;
using System.Security.Policy;
using Emgu.CV.Util;
using System.Diagnostics;

namespace IP_Project
{
    public partial class FaceRecognition : Form
    {
        private VideoCapture videoCapture = null;
        private Image<Bgr, Byte> currentFrame = null;
        Mat frame = new Mat();

        private bool facesDetectionEnabled = false;
        CascadeClassifier faceCascadeClassifier = new CascadeClassifier("..\\..\\..\\haarcascade_frontalface_default.xml");

        Image<Bgr, Byte> faceResult = null;
        private List<Image<Gray, Byte>> trainedFaces = new List<Image<Gray, byte>>();
        List<int> personLabes = new List<int>();

        bool enableSaveImage = false;
        private bool isTrained = false;
        EigenFaceRecognizer recognizer;
        List<String> personNames = new List<String>();

        public FaceRecognition()
        {
            InitializeComponent();
        }

        private void btnCapture_Click(object sender, EventArgs e)
        {
            videoCapture = new VideoCapture();
            videoCapture.ImageGrabbed += ProcessFrame;
            videoCapture.Start();
        }

        private void ProcessFrame(object? sender, EventArgs e)
        {
            videoCapture.Retrieve(frame, 0);
            currentFrame = frame.ToImage<Bgr, Byte>().Resize(pbCapture.Width, pbCapture.Height, Inter.Cubic);

            if (facesDetectionEnabled)
            {
                Mat grayImage = new Mat();
                CvInvoke.CvtColor(currentFrame, grayImage, ColorConversion.Bgr2Gray);
                CvInvoke.EqualizeHist(grayImage, grayImage);

                Rectangle[] faces = faceCascadeClassifier.DetectMultiScale(grayImage, 1.1, 3, Size.Empty, Size.Empty);
                if (faces.Length > 0)
                {
                    foreach (var face in faces)
                    {
                        CvInvoke.Rectangle(currentFrame, face, new Bgr(Color.Red).MCvScalar);

                        Image<Bgr, Byte> resultImage = currentFrame.Convert<Bgr, Byte>();
                        resultImage.ROI = face;
                        pbCaptured.SizeMode = PictureBoxSizeMode.StretchImage;
                        pbCaptured.Image = resultImage.ToBitmap();

                        if (enableSaveImage)
                        {
                            string path = Directory.GetCurrentDirectory() + @"TrainedImages";
                            if (!Directory.Exists(path))
                                Directory.CreateDirectory(path);

                            Task.Factory.StartNew(() =>
                            {
                                for (int i = 0; i < 10; i++)
                                {
                                    resultImage.Resize(200, 200, Inter.Cubic).Save(path + @"\" + txtPersonName.Text + "_" + DateTime.Now.ToString("dd-MM-yyyy-hh-mm-ss") + ".jpg");
                                    Thread.Sleep(1000);
                                }
                            });
                        }
                        enableSaveImage = false;

                        if (btnAddPerson.InvokeRequired)
                        {
                            btnAddPerson.Invoke(new ThreadStart(delegate
                            {
                                btnAddPerson.Enabled = true;
                            }));
                        }

                        if (isTrained)
                        {
                            Image<Gray, Byte> grayFaceResult = resultImage.Convert<Gray, Byte>().Resize(200, 200, Inter.Cubic);
                            CvInvoke.EqualizeHist(grayFaceResult, grayFaceResult);
                            var result = recognizer.Predict(grayFaceResult);
                            //pictureBox1.Image = grayFaceResult.ToBitmap();
                            //pictureBox2.Image = trainedFaces[result.Label].ToBitmap();
                            Debug.WriteLine(result.Label + " " + result.Distance);
                            if (result.Label != -1 && result.Distance < 2000)
                            {
                                var indexValue = result.Label;
                                CvInvoke.PutText(currentFrame, personNames[result.Label], new Point(face.X - 2, face.Y - 2), FontFace.HersheyComplex, 1.0, new Bgr(Color.Orange).MCvScalar);
                                CvInvoke.Rectangle(currentFrame, face, new Bgr(Color.Green).MCvScalar, 2);
                            }
                            else
                            {
                                CvInvoke.PutText(currentFrame, "Unknown", new Point(face.X - 2, face.Y - 2), FontFace.HersheyComplex, 1.0, new Bgr(Color.Orange).MCvScalar);
                                CvInvoke.Rectangle(currentFrame, face, new Bgr(Color.Green).MCvScalar, 2);
                            }
                        }
                    }
                }
            }

            pbCapture.Image = currentFrame.ToBitmap();
        }

        private void btnDetectFace_Click(object sender, EventArgs e)
        {
            facesDetectionEnabled = true;
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            btnAddPerson.Enabled = false;
            enableSaveImage = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
            btnAddPerson.Enabled = true;
            enableSaveImage = false;
        }

        private void btnTrainImage_Click(object sender, EventArgs e)
        {
            trainImagesFromDir();
        }

        private bool trainImagesFromDir()
        {
            int imagesCount = 0;
            double threshold = 2000;
            trainedFaces.Clear();
            personLabes.Clear();
            personNames.Clear();

            try
            {
                string path = Directory.GetCurrentDirectory() + @"TrainedImages";
                string[] files = Directory.GetFiles(path, "*.jpg", SearchOption.AllDirectories);

                foreach (var file in files)
                {
                    Image<Gray, Byte> trainedImage = new Image<Gray, Byte>(file);
                    CvInvoke.EqualizeHist(trainedImage, trainedImage);
                    trainedFaces.Add(trainedImage);
                    personLabes.Add(imagesCount);
                    string name = file.Split('\\').Last().Split('_')[0];
                    personNames.Add(name);
                    imagesCount++;
                    Debug.WriteLine(imagesCount + ". " + name);
                }

                if (trainedFaces.Count > 0)
                {
                    Image<Gray, Byte>[] faces = trainedFaces.ToArray();
                    int[] labels = personLabes.ToArray();

                    VectorOfMat vectorOfMat = new VectorOfMat();
                    VectorOfInt vectorOfInt = new VectorOfInt();

                    vectorOfMat.Push(faces);
                    vectorOfInt.Push(labels);

                    recognizer = new EigenFaceRecognizer(imagesCount, threshold);
                    recognizer.Train(vectorOfMat, vectorOfInt);

                    isTrained = true;
                    Debug.WriteLine(imagesCount);
                    Debug.WriteLine(isTrained);
                    return true;
                }
                else
                {
                    isTrained = false;
                    return false;
                }
            }
            catch (Exception ex)
            {
                isTrained = false;
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
