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
        private Mat frame = new Mat();

        private CascadeClassifier faceCascadeClassifier = new CascadeClassifier("..\\..\\..\\haarcascade_frontalface_default.xml");

        private List<Image<Gray, Byte>> trainedFaces = new List<Image<Gray, byte>>();
        private List<int> personLabels = new List<int>();

        private bool enableSaveImage = false;
        private bool isTrained = false;
        private EigenFaceRecognizer recognizer;
        private List<String> personNames = new List<String>();

        public FaceRecognition()
        {
            InitializeComponent();
        }

        private void ProcessFrame(object? sender, EventArgs e)
        {
            videoCapture.Retrieve(frame, 0);
            currentFrame = frame.ToImage<Bgr, Byte>().Resize(pbCapture.Width, pbCapture.Height, Inter.Cubic);

            if (cbDetectFace.Checked)
            {
                Mat grayImage = new Mat();
                CvInvoke.CvtColor(currentFrame, grayImage, ColorConversion.Bgr2Gray);
                CvInvoke.EqualizeHist(grayImage, grayImage);

                Rectangle[] faces = faceCascadeClassifier.DetectMultiScale(grayImage, 1.1, 3, Size.Empty, Size.Empty);
                int faceCounter = 0;

                if (faces.Length > 0)
                {
                    foreach (var face in faces)
                    {
                        if (!isTrained)
                        {
                            CvInvoke.Rectangle(currentFrame, face, new Bgr(Color.Blue).MCvScalar, 2);
                            CvInvoke.PutText(currentFrame, (++faceCounter).ToString(), new Point(face.X - 2, face.Y - 2), FontFace.HersheyComplex, 1.0, new Bgr(Color.Black).MCvScalar, 2);
                        }

                        Image<Bgr, Byte> resultImage = currentFrame.Convert<Bgr, Byte>();
                        resultImage.ROI = face;
                        pbCaptured.SizeMode = PictureBoxSizeMode.StretchImage;
                        pbCaptured.Image = resultImage.ToBitmap();

                        if (enableSaveImage)
                        {
                            string path = "..\\..\\..\\TrainedImages";
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

                        if (isTrained)
                        {
                            Image<Gray, Byte> grayFaceResult = resultImage.Convert<Gray, Byte>().Resize(200, 200, Inter.Cubic);
                            CvInvoke.EqualizeHist(grayFaceResult, grayFaceResult);
                            var result = recognizer.Predict(grayFaceResult);
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

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            enableSaveImage = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog()
            {
                Filter = "JPEG(*.JPG)|*.JPG|BMP(*.BMP)|*.BMP"
            };

            Image saveImage = pbCapture.Image;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                saveImage.Save(saveFileDialog.FileName);
        }

        private bool trainImagesFromDir()
        {
            int imagesCount = 0;
            double threshold = 2000;
            trainedFaces.Clear();
            personLabels.Clear();
            personNames.Clear();

            try
            {
                string path = "..\\..\\..\\TrainedImages";
                string[] files = Directory.GetFiles(path, "*.jpg", SearchOption.AllDirectories);

                foreach (var file in files)
                {
                    Image<Gray, Byte> trainedImage = new Image<Gray, Byte>(file);
                    CvInvoke.EqualizeHist(trainedImage, trainedImage);
                    trainedFaces.Add(trainedImage);
                    personLabels.Add(imagesCount);
                    string name = file.Split('\\').Last().Split('_')[0];
                    personNames.Add(name);
                    imagesCount++;
                    Debug.WriteLine(imagesCount + ". " + name);
                }

                if (trainedFaces.Count > 0)
                {
                    Image<Gray, Byte>[] faces = trainedFaces.ToArray();
                    int[] labels = personLabels.ToArray();

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

        private void cbTrainImage_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTrainImage.Checked) trainImagesFromDir();
            else isTrained = false;
        }

        private void FaceRecognition_Load(object sender, EventArgs e)
        {
            disableComponents();
        }

        private void FaceRecognition_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void cbActivateCamera_CheckedChanged(object sender, EventArgs e)
        {
            if (cbActivateCamera.Checked)
            {
                videoCapture = new VideoCapture();
                videoCapture.ImageGrabbed += ProcessFrame;
                videoCapture.Start();

                cbDetectFace.Enabled = true;
                btnSave.Enabled = true;
            }
            else
            {
                videoCapture.Dispose();

                cbDetectFace.Checked = false;
                cbTrainImage.Checked = false;
                pbCapture.Image = null;
                pbCaptured.Image = null;
                txtPersonName.Text = string.Empty;

                disableComponents();
            }
        }

        private void disableComponents()
        {
            cbDetectFace.Enabled = false;
            cbTrainImage.Enabled = false;
            txtPersonName.Enabled = false;
            btnAddPerson.Enabled = false;
            btnSave.Enabled = false;
        }

        private void cbDetectFace_CheckedChanged(object sender, EventArgs e)
        {
            if (cbDetectFace.Checked)
            {
                cbTrainImage.Enabled = true;
                txtPersonName.Enabled = true;
                btnAddPerson.Enabled = true;
            }
            else
            {
                cbTrainImage.Checked = false;
                cbTrainImage.Enabled = false;
                // pbCaptured.Image = null;
            }
        }

        private void btnUserManual_Click(object sender, EventArgs e)
        {
            Program.userManual = new UserManual() { StartPosition = FormStartPosition.CenterScreen };
            Program.userManual.Show();
            if (videoCapture != null) videoCapture.Dispose();
            DestroyHandle();
        }

        private void btnImages_Click(object sender, EventArgs e)
        {
            Images images = new Images() { StartPosition = FormStartPosition.CenterScreen };
            images.Show();
            if (videoCapture != null) videoCapture.Dispose();
            DestroyHandle();
        }

        private void btnVideos_Click(object sender, EventArgs e)
        {
            Videos videos = new Videos() { StartPosition = FormStartPosition.CenterScreen };
            videos.Show();
            if (videoCapture != null) videoCapture.Dispose();
            DestroyHandle();
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            FaceCount faceCount = new FaceCount() { StartPosition = FormStartPosition.CenterScreen };
            faceCount.Show();
            if (videoCapture != null) videoCapture.Dispose();
            DestroyHandle();
        }
    }
}
