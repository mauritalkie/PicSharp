using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IP_Project
{
    public partial class UserManual : Form
    {
        private DirectoryInfo directoryInfo;
        private FileInfo[] images;
        private FileInfo[] texts;

        private List<Step> steps = new List<Step>();
        private int totalSteps;
        private int currentStep = 0;

        public UserManual()
        {
            InitializeComponent();
        }

        private void UserManual_Load(object sender, EventArgs e)
        {
            directoryInfo = new DirectoryInfo("..\\..\\..\\Images");
            images = directoryInfo.GetFiles("*.jpg");

            directoryInfo = new DirectoryInfo("..\\..\\..\\Texts");
            texts = directoryInfo.GetFiles("*.txt");

            totalSteps = images.Length - 1;

            for (int i = 0; i < images.Length; i++)
            {
                string content = File.ReadAllText("..\\..\\..\\Texts\\" + texts[i].Name);
                steps.Add(new Step(images[i].Name, content));
            }

            pbPreview.Image = Image.FromFile(steps[currentStep].image);
            pbPreview.SizeMode = PictureBoxSizeMode.StretchImage;

            lblInfo.Text = steps[currentStep].text;
            lblInfo.MaximumSize = new Size(927, 100);
            lblInfo.AutoSize = true;

            btnPrev.Enabled = false;
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            currentStep--;
            if (currentStep == 0) btnPrev.Enabled = false;
            pbPreview.Image = Image.FromFile(steps[currentStep].image);
            lblInfo.Text = steps[currentStep].text;
            if (!btnNext.Enabled) btnNext.Enabled = true;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            currentStep++;
            if (currentStep == totalSteps) btnNext.Enabled = false;
            pbPreview.Image = Image.FromFile(steps[currentStep].image);
            lblInfo.Text = steps[currentStep].text;
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

        private void btnCount_Click(object sender, EventArgs e)
        {
            FaceCount faceCount = new FaceCount() { StartPosition = FormStartPosition.CenterScreen };
            faceCount.Show();
            Hide();
        }
    }

    public class Step
    {
        public string image;
        public string text;

        public Step(string image, string text)
        {
            this.image = "..\\..\\..\\Images\\" + image;
            this.text = text;
        }
    }
}
