using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;

namespace IP_Project
{
    public partial class FaceCount : Form
    {
        private FilterInfoCollection filterInfoCollection;
        private VideoCaptureDevice videoCaptureDevice = new VideoCaptureDevice();

        public FaceCount()
        {
            InitializeComponent();
        }

        private void enableDisableComponents(bool camera, bool image)
        {
            btnCameraState.Enabled = false;
            cbDevices.Enabled = camera;
            btnLoadImage.Enabled = image;
            lblDetectedFaces.Text = string.Empty;
            pbDisplay.Image = null;
            cbDevices.SelectedIndex = -1;
            if (videoCaptureDevice.IsRunning) videoCaptureDevice.SignalToStop();
        }

        private void FaceCount_Load(object sender, EventArgs e)
        {
            enableDisableComponents(false, false);

            rbCamera.AutoCheck = false;
            rbCamera.AutoCheck = true;

            cbDevices.DropDownStyle = ComboBoxStyle.DropDownList;
            pbDisplay.SizeMode = PictureBoxSizeMode.StretchImage;

            loadDevices();
        }

        private void rbCamera_CheckedChanged(object sender, EventArgs e)
        {
            if (!rbCamera.Checked) return;
            enableDisableComponents(true, false);
        }

        private void rbImage_CheckedChanged(object sender, EventArgs e)
        {
            if (!rbImage.Checked) return;
            enableDisableComponents(false, true);
        }

        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image files (*.jpg)|*.jpg|(*.bmp)|*.bmp|(*.jpeg)|*.jpeg|(*.png)|*.png";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string path = openFileDialog.FileName;
                    Image image = Image.FromFile(path);

                    CascadeClassifier cascadeClassifier = new CascadeClassifier("..\\..\\..\\haarcascade_frontalface_default.xml");
                    Image<Bgr, byte> rectangleImage = new Image<Bgr, byte>(path);
                    Rectangle[] rectangles = cascadeClassifier.DetectMultiScale(rectangleImage);

                    foreach (Rectangle rectangle in rectangles)
                    {
                        using (Graphics graphics = Graphics.FromImage(image))
                        {
                            using (Pen pen = new Pen(Color.Blue, 5))
                            {
                                graphics.DrawRectangle(pen, rectangle);
                            }
                        }
                    }

                    pbDisplay.Image = image;
                    lblDetectedFaces.Text = "Número de personas: " + rectangles.Length;
                }
            }
        }

        private void loadDevices()
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfoCollection)
                cbDevices.Items.Add(filterInfo.Name);
        }

        private void cbDevices_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbDevices.SelectedIndex != -1) btnCameraState.Enabled = true;
        }

        private void btnCameraState_Click(object sender, EventArgs e)
        {
            if (!videoCaptureDevice.IsRunning)
            {
                videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[cbDevices.SelectedIndex].MonikerString);
                videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
                videoCaptureDevice.Start();
                btnCameraState.Text = "Apagar";
            }
            else
            {
                videoCaptureDevice.SignalToStop();
                // pbDisplay.Image = null;
                btnCameraState.Text = "Encender";
            }
        }

        private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            int faceCounter = 0;
            Font font = new Font("Arial", 20, FontStyle.Regular);
            Brush brush = new SolidBrush(Color.FromKnownColor(KnownColor.Black));

            Bitmap display = (Bitmap)eventArgs.Frame.Clone();
            CascadeClassifier cascadeClassifier = new CascadeClassifier("..\\..\\..\\haarcascade_frontalface_default.xml");
            Image<Bgr, byte> emguImg = display.ToImage<Bgr, byte>();
            Rectangle[] rectangles = cascadeClassifier.DetectMultiScale(emguImg);

            foreach (Rectangle rectangle in rectangles)
            {
                using (Graphics graphics = Graphics.FromImage(display))
                {
                    using (Pen pen = new Pen(Color.Blue, 5))
                    {
                        graphics.DrawRectangle(pen, rectangle);
                        graphics.DrawString((++faceCounter).ToString(), font, brush, rectangle);
                    }
                }
            }

            pbDisplay.Image = display;
        }

        private void btnUserManual_Click(object sender, EventArgs e)
        {
            Program.userManual = new UserManual() { StartPosition = FormStartPosition.CenterScreen };
            Program.userManual.Show();
            if (videoCaptureDevice.IsRunning) videoCaptureDevice.SignalToStop();
            DestroyHandle();
        }

        private void btnImages_Click(object sender, EventArgs e)
        {
            Images images = new Images() { StartPosition = FormStartPosition.CenterScreen };
            images.Show();
            if (videoCaptureDevice.IsRunning) videoCaptureDevice.SignalToStop();
            DestroyHandle();
        }

        private void btnVideos_Click(object sender, EventArgs e)
        {
            Videos videos = new Videos() { StartPosition = FormStartPosition.CenterScreen };
            videos.Show();
            if (videoCaptureDevice.IsRunning) videoCaptureDevice.SignalToStop();
            DestroyHandle();
        }

        private void btnRecognition_Click(object sender, EventArgs e)
        {
            FaceRecognition faceRecognition = new FaceRecognition() { StartPosition = FormStartPosition.CenterScreen };
            faceRecognition.Show();
            if (videoCaptureDevice.IsRunning) videoCaptureDevice.SignalToStop();
            DestroyHandle();
        }

        private void FaceCount_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (videoCaptureDevice.IsRunning) videoCaptureDevice.SignalToStop();
            Application.Exit();
        }
    }
}
