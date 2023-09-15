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
        private int clusters;
        private int redBar, greenBar, blueBar;
        private ClusteringSegmentation clusteringSegmentation;
        private ColorTint colorTint;
        private Histogram originChild, filteredChild;

        public Histogram OriginChild { set { originChild = value; } }
        public Histogram FilteredChild { set { filteredChild = value; } }

        private enum filterType
        {
            BoundaryExtraction,
            ClusteringSegmentation,
            Sobel,
            AlternativeColor,
            GaussianBlur,
            ColorTint
        }

        public Images()
        {
            InitializeComponent();
        }

        private void Images_Load(object sender, EventArgs e)
        {
            string[] filters = { "Extracción", "Segmentación", "Sobel", "Alternativo", "Difuminado", "Tinte" };
            cbFilters.Items.AddRange(filters);
            cbFilters.DropDownStyle = ComboBoxStyle.DropDownList;

            cbFilters.Enabled = false;
            btnOriginHistogram.Enabled = false;
            btnSaveImage.Enabled = false;
            btnFilteredHistogram.Enabled = false;

            clusters = tbClusters.Value;
            redBar = tbRed.Value;
            greenBar = tbGreen.Value;
            blueBar = tbBlue.Value;

            disableTrackbars();
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
            getHistogram(originImage, ref originChild, true, false);
        }

        private void cbFilters_SelectedIndexChanged(object sender, EventArgs e)
        {
            disableTrackbars();

            int selectedFilter = cbFilters.SelectedIndex;
            switch (selectedFilter)
            {
                case (int)filterType.BoundaryExtraction:
                    BoundaryExtraction boundaryExtraction = new BoundaryExtraction(originImage);
                    filteredImage = boundaryExtraction.ApplyFilter();
                    break;
                case (int)filterType.ClusteringSegmentation:
                    tbClusters.Enabled = true;

                    clusteringSegmentation = new ClusteringSegmentation(originImage, clusters);
                    filteredImage = clusteringSegmentation.ApplyFilter();
                    break;
                case (int)filterType.Sobel:
                    Sobel sobel = new Sobel(originImage);
                    filteredImage = sobel.ApplyFilter();
                    break;
                case (int)filterType.AlternativeColor:
                    AlternativeColor alternativeColor = new AlternativeColor(originImage);
                    filteredImage = alternativeColor.ApplyFilter();
                    break;
                case (int)filterType.GaussianBlur:
                    GaussianBlur gaussianBlur = new GaussianBlur(originImage);
                    filteredImage = gaussianBlur.ApplyFilter();
                    break;
                case (int)filterType.ColorTint:
                    tbRed.Enabled = true;
                    tbGreen.Enabled = true;
                    tbBlue.Enabled = true;

                    colorTint = new ColorTint(originImage, redBar, greenBar, blueBar);
                    filteredImage = colorTint.ApplyFilter();
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
                Filter = "(*.jpg)|*.jpg|(*.bmp)|*.bmp|(*.jpeg)|*.jpeg|(*.png)|*.png"
            };

            Image saveImage = pbFilteredImage.Image;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                saveImage.Save(saveFileDialog.FileName);
        }

        private void btnFilteredHistogram_Click(object sender, EventArgs e)
        {
            getHistogram(filteredImage, ref filteredChild, false, true);
        }

        private void getHistogram(Bitmap histogramImage, ref Histogram histogram, bool isOrigin, bool isFiltered)
        {
            if (histogram != null) return;

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

            histogram = new Histogram()
            {
                Red = red,
                Green = green,
                Blue = blue,
                ParentWindow = this,
                IsOrigin = isOrigin,
                IsFiltered = isFiltered
            };
            histogram.Show();
        }

        private void btnUserManual_Click(object sender, EventArgs e)
        {
            Program.userManual = new UserManual() { StartPosition = FormStartPosition.CenterScreen };
            Program.userManual.Show();
            closeHistogramChilds();
            DestroyHandle();
        }

        private void btnVideos_Click(object sender, EventArgs e)
        {
            Videos videos = new Videos() { StartPosition = FormStartPosition.CenterScreen };
            videos.Show();
            closeHistogramChilds();
            DestroyHandle();
        }

        private void btnRecognition_Click(object sender, EventArgs e)
        {
            FaceRecognition faceRecognition = new FaceRecognition() { StartPosition = FormStartPosition.CenterScreen };
            faceRecognition.Show();
            closeHistogramChilds();
            DestroyHandle();
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            FaceCount faceCount = new FaceCount() { StartPosition = FormStartPosition.CenterScreen };
            faceCount.Show();
            closeHistogramChilds();
            DestroyHandle();
        }

        private void tbRed_Scroll(object sender, EventArgs e)
        {
            redBar = tbRed.Value;
            colorTint.SetRed(redBar);
            filteredImage = colorTint.ApplyFilter();
            pbFilteredImage.Image = filteredImage;
        }

        private void tbGreen_Scroll(object sender, EventArgs e)
        {
            greenBar = tbGreen.Value;
            colorTint.SetGreen(greenBar);
            filteredImage = colorTint.ApplyFilter();
            pbFilteredImage.Image = filteredImage;
        }

        private void tbBlue_Scroll(object sender, EventArgs e)
        {
            blueBar = tbBlue.Value;
            colorTint.SetBlue(blueBar);
            filteredImage = colorTint.ApplyFilter();
            pbFilteredImage.Image = filteredImage;
        }

        private void tbClusters_Scroll(object sender, EventArgs e)
        {
            clusters = tbClusters.Value;
            clusteringSegmentation.SetClusters(clusters);
            filteredImage = clusteringSegmentation.ApplyFilter();
            pbFilteredImage.Image = filteredImage;
        }

        private void disableTrackbars()
        {
            tbClusters.Enabled = false;
            tbRed.Enabled = false;
            tbGreen.Enabled = false;
            tbBlue.Enabled = false;
        }

        private void closeHistogramChilds()
        {
            if (originChild != null) originChild.Close();
            if (filteredChild != null) filteredChild.Close();
        }
    }
}
