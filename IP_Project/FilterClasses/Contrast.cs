using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IP_Project.FilterClasses
{
    internal class Contrast : Filter
    {
        private double contrast;

        public Contrast()
        {

        }

        public Contrast(Bitmap image, double contrast) : base(image)
        {
            this.contrast = contrast;
        }

        public override Bitmap ApplyFilter()
        {
            Bitmap adjustedImage = new Bitmap(image.Width, image.Height);

            for (int i = 0; i < image.Height; i++)
            {
                for (int j = 0; j < image.Width; j++)
                {
                    currentColor = image.GetPixel(j, i);

                    int newRed = (int)Math.Max(0, Math.Min(255, ((currentColor.R - 128) * contrast) + 128));
                    int newGreen = (int)Math.Max(0, Math.Min(255, ((currentColor.G - 128) * contrast) + 128));
                    int newBlue = (int)Math.Max(0, Math.Min(255, ((currentColor.B - 128) * contrast) + 128));

                    newColor = Color.FromArgb(newRed, newGreen, newBlue);

                    adjustedImage.SetPixel(j, i, newColor);
                }
            }

            return adjustedImage;
        }

        public void SetContrast(double contrast)
        {
            this.contrast = contrast;
            if (contrast != 0) this.contrast /= 10;
        }
    }
}
