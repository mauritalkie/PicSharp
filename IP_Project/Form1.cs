using AForge.Video;
using AForge.Video.DirectShow;
using Emgu.CV;

namespace IP_Project
{
    public partial class Form1 : Form
    {
        /*for camera*/
        private FilterInfoCollection filterInfoCollection;
        private VideoCaptureDevice videoCaptureDevice;
        private bool isCameraActivated = false;

        /*for image*/
        private Bitmap bitmap;
        private Bitmap origin;
        private int width;
        private int height;
        private Color currentColor;
        private Color newColor;

        /*for video*/
        VideoCapture videoCapture;
        bool pause = false;

        private Bitmap bitmapVideo;
        private Bitmap originVideo;
        private Color currentColorVideo, newColorVideo;
        private int filter = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (isCameraActivated) return;
            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[cbCamera.SelectedIndex].MonikerString);
            videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            videoCaptureDevice.Start();
            isCameraActivated = true;
        }

        private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pbDisplay.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfoCollection)
                cbCamera.Items.Add(filterInfo.Name);
            cbCamera.SelectedIndex = 0;
            videoCaptureDevice = new VideoCaptureDevice();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (videoCaptureDevice.IsRunning == true)
            {
                videoCaptureDevice.SignalToStop();
                videoCaptureDevice = null;
                isCameraActivated = false;
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Filter = "Image files (*.jpg)|*.jpg|(*.bmp)|*.bmp|(*.jpeg)|*.jpeg|(*.png)|*.png"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pbDisplay.Image = new Bitmap(openFileDialog.FileName);
                bitmap = new Bitmap(pbDisplay.Image);
                origin = new Bitmap(pbDisplay.Image);
                width = bitmap.Width;
                height = bitmap.Height;
            }

            openFileDialog.Dispose();
        }

        private void btnGrayscale_Click(object sender, EventArgs e)
        {
            filter = 2;
            if (bitmap == null) return;
            Bitmap finalColor = new Bitmap(width, height);
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    currentColor = bitmap.GetPixel(i, j);
                    newColor = Color.FromArgb(currentColor.R, currentColor.R, currentColor.R);
                    finalColor.SetPixel(i, j, newColor);
                }
            }
            pbDisplay.Image = finalColor;
            bitmap = finalColor;
        }

        private void btnNegative_Click(object sender, EventArgs e)
        {
            filter = 1;
            if (bitmap == null) return;
            Bitmap finalColor = new Bitmap(width, height);
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    currentColor = bitmap.GetPixel(i, j);
                    newColor = Color.FromArgb(255 - currentColor.R, 255 - currentColor.G, 255 - currentColor.B);
                    finalColor.SetPixel(i, j, newColor);
                }
            }
            pbDisplay.Image = finalColor;
            bitmap = finalColor;
        }

        private void btnSepia_Click(object sender, EventArgs e)
        {
            filter = 3;
            if (bitmap == null) return;
            Bitmap finalColor = new Bitmap(width, height);
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    currentColor = bitmap.GetPixel(i, j);

                    int alpha = currentColor.A;
                    int red = currentColor.R;
                    int green = currentColor.G;
                    int blue = currentColor.B;

                    int tempRed = (int)(0.393 * red + 0.769 * green + 0.189 * blue);
                    int tempGreen = (int)(0.349 * red + 0.686 * green + 0.168 * blue);
                    int tempBlue = (int)(0.272 * red + 0.534 * green + 0.131 * blue);

                    if (tempRed > 255) red = 255;
                    else red = tempRed;

                    if (tempGreen > 255) green = 255;
                    else green = tempGreen;

                    if (tempBlue > 255) blue = 255;
                    else blue = tempBlue;

                    finalColor.SetPixel(i, j, Color.FromArgb(alpha, red, green, blue));
                }
            }
            pbDisplay.Image = finalColor;
            bitmap = finalColor;
        }

        private void btnNoise_Click(object sender, EventArgs e)
        {
            filter = 4;
            if (bitmap == null) return;
            int percentage = 150;
            int minRange = 85;
            int maxRange = 115;
            float brightness;
            Random random = new Random();
            int red, green, blue;
            Bitmap finalColor = new Bitmap(width, height);
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    if (random.Next(minRange, maxRange) <= percentage)
                    {
                        brightness = random.Next(minRange, maxRange) / 100.0f;
                        currentColor = bitmap.GetPixel(i, j);

                        red = (int)(currentColor.R * brightness);
                        green = (int)(currentColor.G * brightness);
                        blue = (int)(currentColor.B * brightness);

                        if (red > 255) red = 255;
                        else if (red < 0) red = 0;

                        if (green > 255) green = 255;
                        else if (green < 0) green = 0;

                        if (blue > 255) blue = 255;
                        else if (blue < 0) blue = 0;

                        newColor = Color.FromArgb(red, green, blue);
                    }
                    else
                    {
                        newColor = bitmap.GetPixel(i, j);
                    }
                    finalColor.SetPixel(i, j, newColor);
                }
            }
            pbDisplay.Image = finalColor;
            bitmap = finalColor;
        }

        private void btnChromatic_Click(object sender, EventArgs e)
        {
            filter = 5;
            if (bitmap == null) return;
            int aberrationSize = 5;
            int red = 0;
            int green = 0;
            int blue = 0;

            Bitmap finalColor = new Bitmap(width, height);
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    green = bitmap.GetPixel(i, j).G;

                    if (i + aberrationSize < width)
                        red = bitmap.GetPixel(i + aberrationSize, j).R;
                    else
                        red = 0;

                    if (i - aberrationSize >= 0)
                        blue = bitmap.GetPixel(i - aberrationSize, i).B;

                    finalColor.SetPixel(i, j, Color.FromArgb(red, green, blue));
                }
            }
            pbDisplay.Image = finalColor;
            bitmap = finalColor;
        }

        private async void btnUploadVideo_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Filter = "Image files (*.mp4)|*.mp4"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                videoCapture = new VideoCapture(openFileDialog.FileName);
                Mat mat = new Mat();

                Bitmap originalImage = mat.ToBitmap();
                while (!pause)
                {
                    videoCapture.Read(mat);
                    if (!mat.IsEmpty)
                    {
                        bitmapVideo = mat.ToBitmap();
                        originVideo = mat.ToBitmap();

                        switch (filter)
                        {
                            case 0:
                                bitmapVideo = mat.ToBitmap();
                                break;
                            case 1:
                                negative();
                                break;
                            case 2:
                                grayScale();
                                break;
                            case 3:
                                sepia();
                                break;
                            case 4:
                                noise();
                                break;
                            case 5:
                                chromatic();
                                break;
                        }

                        pbDisplay.Image = bitmapVideo;
                        pbDisplay.SizeMode = PictureBoxSizeMode.StretchImage;

                        double fps = videoCapture.Get(Emgu.CV.CvEnum.CapProp.Fps);
                        await Task.Delay(1000 / Convert.ToInt32(fps));
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }

        private async void btnPlay_Click(object sender, EventArgs e)
        {
            if (videoCapture == null) return;
            Mat mat = new Mat();

            pause = false;
            while (!pause)
            {
                videoCapture.Read(mat);

                if (!mat.IsEmpty)
                {
                    pbDisplay.Image = mat.ToBitmap();
                    bitmapVideo = mat.ToBitmap();
                    double fps = videoCapture.Get(Emgu.CV.CvEnum.CapProp.Fps);
                    await Task.Delay(1000 / Convert.ToInt32(fps));
                }
                else
                {
                    break;
                }
            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if (videoCapture == null) return;
            pause = true;
        }

        private void chromatic()
        {
            if (bitmapVideo == null) return;
            int aberrationSize = 5;
            int red = 0;
            int green = 0;
            int blue = 0;

            pbDisplay.Image = bitmapVideo;
            bitmapVideo = new Bitmap(originVideo.Width, originVideo.Height);

            for(int i = 0; i < originVideo.Width; i++)
            {
                for(int j = 0; j < originVideo.Height; j++)
                {
                    green = originVideo.GetPixel(i, j).G;

                    if (i + aberrationSize < originVideo.Width)
                        red = originVideo.GetPixel(i + aberrationSize, j).R;
                    else
                        red = 0;

                    if (i - aberrationSize >= 0)
                        blue = originVideo.GetPixel(i - aberrationSize, j).B;

                    bitmapVideo.SetPixel(i, j, Color.FromArgb(red, green, blue));
                }
            }
        }

        private void noise()
        {
            if (bitmapVideo == null) return;
            int percentage = 150;
            int minRange = 85;
            int maxRange = 115;
            float brightness;
            Random random = new Random();
            int red, green, blue;
            pbDisplay.Image = bitmapVideo;
            bitmapVideo = new Bitmap(originVideo.Width, originVideo.Height);

            for( int i = 0; i < originVideo.Width; i++)
            {
                for( int j = 0; j < originVideo.Height; j++)
                {
                    if(random.Next(1, 100) <= percentage)
                    {
                        brightness = random.Next(minRange, maxRange) / 100.0f;
                        currentColorVideo = originVideo.GetPixel(i, j);

                        red = (int)(currentColorVideo.R * brightness);
                        green = (int)(currentColorVideo.G * brightness);
                        blue = (int)(currentColorVideo.B * brightness);

                        if(red > 255) red = 255;
                        else if(red < 0) red = 0;

                        if(green > 255) green = 255;
                        else if(green < 0) green = 0;

                        if (blue > 255) blue = 255;
                        else if(blue < 0) blue = 0;

                        newColorVideo = Color.FromArgb(red, green, blue);
                    }
                    else
                    {
                        newColor = originVideo.GetPixel(i, j);
                    }
                    bitmapVideo.SetPixel(i, j, newColorVideo);
                }
            }
        }

        private void negative()
        {
            if (bitmapVideo == null) return;
            pbDisplay.Image = bitmapVideo;
            bitmapVideo = new Bitmap(originVideo.Width, originVideo.Height);

            for(int i = 0; i<originVideo.Width; i++)
            {
                for(int j = 0; j<originVideo.Height; j++)
                {
                    currentColorVideo = originVideo.GetPixel(i, j);
                    newColorVideo = Color.FromArgb(255 - currentColorVideo.R, 255 - currentColorVideo.G, 255 - currentColorVideo.B);
                    bitmapVideo.SetPixel(i, j, newColorVideo);
                }
            }
        }

        private void grayScale()
        {
            if(bitmapVideo == null) return;
            pbDisplay.Image = bitmapVideo;
            bitmapVideo = new Bitmap(originVideo.Width, originVideo.Height);

            for(int i = 0; i < originVideo.Width; i++)
            {
                for(int j = 0; j < originVideo.Height; j++)
                {
                    currentColor = originVideo.GetPixel(i, j);
                    newColorVideo = Color.FromArgb(currentColor.R, currentColor.R, currentColor.R);
                    bitmapVideo.SetPixel(i, j, newColorVideo);
                }
            }
        }

        private void sepia()
        {
            if (bitmapVideo == null) return;
            pbDisplay.Image = bitmapVideo;
            bitmapVideo = new Bitmap(originVideo.Width, originVideo.Height);
            for(int i = 0; i < originVideo.Width; i++)
            {
                for(int j = 0; j < originVideo.Height; j++)
                {
                    currentColorVideo = originVideo.GetPixel(i, j);

                    int alpha = currentColorVideo.A;
                    int red = currentColorVideo.R;
                    int green = currentColorVideo.G;
                    int blue = currentColorVideo.B;

                    int tempRed = (int)(0.393 * red + 0.769 * green + 0.189 * blue);
                    int tempGreen = (int)(0.349 * red + 0.686 * green + 0.168 * blue);
                    int tempBlue = (int)(0.272 * red + 0.534 * green + 0.131 * blue);

                    if (tempRed > 255) red = 255;
                    else red = tempRed;

                    if (tempGreen > 255) green = 255;
                    else green = tempGreen;

                    if (tempBlue > 255) blue = 255;
                    else blue = tempBlue;

                    bitmapVideo.SetPixel(i, j, Color.FromArgb(alpha, red, green, blue));
                }
            }
        }
    }
}