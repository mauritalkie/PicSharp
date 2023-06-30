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
    public partial class UserManual : Form
    {
        private FileInfo[] images;
        private int totalImages;
        private int currentImage = 0;

        public UserManual()
        {
            InitializeComponent();
        }

        private void UserManual_Load(object sender, EventArgs e)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo("..\\..\\..\\Imagenes");
            images = directoryInfo.GetFiles("*.jpg");
            totalImages = images.Length - 1;

            pbPreview.Image = Image.FromFile("..\\..\\..\\Imagenes\\" + images[currentImage].Name);
            pbPreview.SizeMode = PictureBoxSizeMode.StretchImage;

            btnPrev.Enabled = false;
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            currentImage--;
            if (currentImage == 0) btnPrev.Enabled = false;
            pbPreview.Image = Image.FromFile("..\\..\\..\\Imagenes\\" + images[currentImage].Name);
            if (!btnNext.Enabled) btnNext.Enabled = true;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            currentImage++;
            if (currentImage == totalImages) btnNext.Enabled = false;
            pbPreview.Image = Image.FromFile("..\\..\\..\\Imagenes\\" + images[currentImage].Name);
            if (!btnPrev.Enabled) btnPrev.Enabled = true;
        }

        private void btnImages_Click(object sender, EventArgs e)
        {
            Images images = new Images() { StartPosition = FormStartPosition.CenterScreen };
            images.Show();
            Hide();
        }

        private void btnVideos_Click(object sender, EventArgs e)
        {
            Videos videos = new Videos() { StartPosition = FormStartPosition.CenterScreen };
            videos.Show();
            Hide();
        }

        private void btnRecognition_Click(object sender, EventArgs e)
        {
            FaceRecognition faceRecognition = new FaceRecognition() { StartPosition = FormStartPosition.CenterScreen };
            faceRecognition.Show();
            Hide();
        }

        private void UserManual_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
