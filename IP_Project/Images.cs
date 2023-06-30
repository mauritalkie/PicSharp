using Emgu.CV.Reg;
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
    public partial class Images : Form
    {
        private Bitmap originImage, filteredImage;

        private enum filterType
        {
            Grayscale,
            Negative,
            Sepia,
            Noise,
            ChromaticAberration,
            Sobel,
            ColorGradient
        }

        public Images()
        {
            InitializeComponent();
        }

        private void Images_Load(object sender, EventArgs e)
        {
            string[] filters = { "Escala de grises", "Negativo", "Sepia", "Ruido", "Abominación cromática", "Sobel", "Degradado" };
            cbFilters.Items.AddRange(filters);
            cbFilters.DropDownStyle = ComboBoxStyle.DropDownList;

            cbFilters.Enabled = false;
            btnOriginHistogram.Enabled = false;
            btnSaveImage.Enabled = false;
            btnFilteredHistogram.Enabled = false;
        }

        private void Images_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Filter = "Image files (*.jpg)|*.jpg|(*.bmp)|*.bmp|(*.jpeg)|*.jpeg|(*.png)|*.png"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pbOriginImage.Image = new Bitmap(openFileDialog.FileName);
                pbOriginImage.SizeMode = PictureBoxSizeMode.StretchImage;

                originImage = new Bitmap(pbOriginImage.Image);

                cbFilters.Enabled = true;
                btnOriginHistogram.Enabled = true;
            }

            openFileDialog.Dispose();
        }

        private void btnOriginHistogram_Click(object sender, EventArgs e)
        {
            getHistogram(originImage);
        }

        private void cbFilters_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedFilter = cbFilters.SelectedIndex;
            switch (selectedFilter)
            {
                case (int)filterType.Grayscale:
                    Grayscale grayscale = new Grayscale(originImage);
                    filteredImage = grayscale.ApplyFilter();
                    break;
                case (int)filterType.Negative:
                    Negative negative = new Negative(originImage);
                    filteredImage = negative.ApplyFilter();
                    break;
                case (int)filterType.Sepia:
                    Sepia sepia = new Sepia(originImage);
                    filteredImage = sepia.ApplyFilter();
                    break;
                case (int)filterType.Noise:
                    Noise noise = new Noise(originImage);
                    filteredImage = noise.ApplyFilter();
                    break;
                case (int)filterType.ChromaticAberration:
                    ChromaticAberration chromaticAberration = new ChromaticAberration(originImage);
                    filteredImage = chromaticAberration.ApplyFilter();
                    break;
                case (int)filterType.Sobel:
                    Sobel sobel = new Sobel(originImage);
                    filteredImage = sobel.ApplyFilter();
                    break;
                case (int)filterType.ColorGradient:
                    ColorGradient colorGradient = new ColorGradient(originImage);
                    filteredImage = colorGradient.ApplyFilter();
                    break;
            }

            pbFilteredImage.Image = filteredImage;
            pbFilteredImage.SizeMode = PictureBoxSizeMode.StretchImage;

            btnSaveImage.Enabled = true;
            btnFilteredHistogram.Enabled = true;
        }

        private void btnSaveImage_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog()
            {
                Filter = "JPEG(*.JPG)|*.JPG|BMP(*.BMP)|*.BMP"
            };

            Image saveImage = pbFilteredImage.Image;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                saveImage.Save(saveFileDialog.FileName);
        }

        private void btnFilteredHistogram_Click(object sender, EventArgs e)
        {
            getHistogram(filteredImage);
        }

        private void getHistogram(Bitmap histogramImage)
        {
            int[] red = new int[256];
            int[] green = new int[256];
            int[] blue = new int[256];
            Color color;

            for (int x = 0; x < histogramImage.Width; x++)
            {
                for (int y = 0; y < histogramImage.Height; y++)
                {
                    color = histogramImage.GetPixel(x, y);
                    red[color.R]++;
                    green[color.G]++;
                    blue[color.B]++;
                }
            }

            Histogram histogram = new Histogram()
            {
                Red = red,
                Green = green,
                Blue = blue
            };
            histogram.Show();
        }

        private void btnUserManual_Click(object sender, EventArgs e)
        {
            Program.userManual = new UserManual() { StartPosition = FormStartPosition.CenterScreen };
            Program.userManual.Show();
            DestroyHandle();
        }

        private void btnVideos_Click(object sender, EventArgs e)
        {
            Videos videos = new Videos() { StartPosition = FormStartPosition.CenterScreen };
            videos.Show();
            DestroyHandle();
        }

        private void btnRecognition_Click(object sender, EventArgs e)
        {
            FaceRecognition faceRecognition = new FaceRecognition() { StartPosition = FormStartPosition.CenterScreen };
            faceRecognition.Show();
            DestroyHandle();
        }
    }
}
