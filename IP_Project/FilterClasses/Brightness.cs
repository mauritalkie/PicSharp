using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IP_Project.FilterClasses
{
    internal class Brightness : Filter
    {
        private double brightness;

        public Brightness()
        {

        }

        public Brightness(Bitmap image, double brightness) : base(image)
        {
            this.brightness = brightness;
        }

        public override Bitmap ApplyFilter()
        {
            Bitmap adjustedImage = new Bitmap(image.Width, image.Height);

            for (int i = 0; i < image.Height; i++)
            {
                for (int j = 0; j < image.Width; j++)
                {
                    currentColor = image.GetPixel(j, i);

                    int newRed = (int)Math.Min(255, currentColor.R * brightness);
                    int newGreen = (int)Math.Min(255, currentColor.G * brightness);
                    int newBlue = (int)Math.Min(255, currentColor.B * brightness);

                    newColor = Color.FromArgb(newRed, newGreen, newBlue);

                    adjustedImage.SetPixel(j, i, newColor);
                }
            }

            return adjustedImage;
        }

        public void SetBrightness(double brightness)
        {
            this.brightness = brightness;
            if (brightness != 0) this.brightness /= 10;
        }
    }
}
