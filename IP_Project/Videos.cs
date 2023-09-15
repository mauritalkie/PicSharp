using Emgu.CV;
using IP_Project.FilterClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IP_Project
{
    public partial class Videos : Form
    {
        private VideoCapture videoCapture;
        private bool isRunning = true;
        private Bitmap video;
        private Mat mat;
        private int selectedFilter = -1;

        private Negative negative = new Negative();
        private ChromaticAberration chromaticAberration = new ChromaticAberration();
        private Brightness brightness = new Brightness();
        private Contrast contrast = new Contrast();
        private Noise noise = new Noise();
        private ColorGradient colorGradient = new ColorGradient();

        private enum filterType
        {
            Negative,
            ChromaticAberration,
            Brightness,
            Contrast,
            Noise,
            ColorGradient
        }

        public Videos()
        {
            InitializeComponent();
        }

        private void Videos_Load(object sender, EventArgs e)
        {
            string[] filters = { "Negativo", "Abominación cromática", "Brillo", "Contraste", "Ruido", "Degradado", "Sin filtro" };
            cbFilters.Items.AddRange(filters);
            cbFilters.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFilters.Enabled = false;

            btnVideoState.Enabled = false;

            brightness.SetBrightness(trackbar.Value);
            contrast.SetContrast(trackbar.Value);
            trackbar.Enabled = false;
        }

        private void Videos_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnLoadVideo_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Filter = "Image files (*.mp4)|*.mp4"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                videoCapture = new VideoCapture(openFileDialog.FileName);

                cbFilters.Enabled = true;
                btnVideoState.Enabled = true;

                playVideo();
            }
        }

        private void btnVideoState_Click(object sender, EventArgs e)
        {
            if (isRunning)
            {
                isRunning = false;
                btnVideoState.Text = "Reproducir";
            }
            else
            {
                isRunning = true;
                btnVideoState.Text = "Pausar";
            }

            playVideo();
        }

        private void cbFilters_SelectedIndexChanged(object sender, EventArgs e)
        {
            trackbar.Enabled = false;
            selectedFilter = cbFilters.SelectedIndex;

            if (selectedFilter == (int)filterType.Brightness || selectedFilter == (int)filterType.Contrast)
                trackbar.Enabled = true;
        }

        private void setFilter()
        {
            switch (selectedFilter)
            {
                case (int)filterType.Negative:
                    negative.UpdateFrame(video);
                    video = negative.ApplyFilter();
                    break;
                case (int)filterType.ChromaticAberration:
                    chromaticAberration.UpdateFrame(video);
                    video = chromaticAberration.ApplyFilter();
                    break;
                case (int)filterType.Brightness:
                    brightness.UpdateFrame(video);
                    video = brightness.ApplyFilter();
                    break;
                case (int)filterType.Contrast:
                    contrast.UpdateFrame(video);
                    video = contrast.ApplyFilter();
                    break;
                case (int)filterType.Noise:
                    noise.UpdateFrame(video);
                    video = noise.ApplyFilter();
                    break;
                case (int)filterType.ColorGradient:
                    colorGradient.UpdateFrame(video);
                    video = colorGradient.ApplyFilter();
                    break;
            }
        }

        private async void playVideo()
        {
            mat = new Mat();

            while (isRunning)
            {
                videoCapture.Read(mat);
                if (!mat.IsEmpty)
                {
                    video = mat.ToBitmap();
                    setFilter();

                    pbVideo.Image = video;
                    pbVideo.SizeMode = PictureBoxSizeMode.StretchImage;

                    double fps = videoCapture.Get(Emgu.CV.CvEnum.CapProp.Fps);
                    await Task.Delay(1000 / Convert.ToInt32(fps));
                }
                else
                {
                    break;
                }
            }
        }

        private void btnUserManual_Click(object sender, EventArgs e)
        {
            Program.userManual = new UserManual() { StartPosition = FormStartPosition.CenterScreen };
            Program.userManual.Show();
            DestroyHandle();
        }

        private void btnImages_Click(object sender, EventArgs e)
        {
            Images images = new Images() { StartPosition = FormStartPosition.CenterScreen };
            images.Show();
            DestroyHandle();
        }

        private void btnRecognition_Click(object sender, EventArgs e)
        {
            FaceRecognition faceRecognition = new FaceRecognition() { StartPosition = FormStartPosition.CenterScreen };
            faceRecognition.Show();
            DestroyHandle();
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            FaceCount faceCount = new FaceCount() { StartPosition = FormStartPosition.CenterScreen };
            faceCount.Show();
            DestroyHandle();
        }

        private void trackbar_Scroll(object sender, EventArgs e)
        {
            brightness.SetBrightness(trackbar.Value);
            contrast.SetContrast(trackbar.Value);
        }
    }
}
