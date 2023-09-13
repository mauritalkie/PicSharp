using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IP_Project.FilterClasses
{
    internal class ColorTint : Filter
    {
        private double red, green, blue;

        public ColorTint()
        {

        }

        public ColorTint(Bitmap image, double red, double green, double blue) : base(image)
        {
            this.red = red;
            if (red != 0) this.red = red /= 10;

            this.green = green;
            if (green != 0) this.green = green / 10;

            this.blue = blue;
            if(blue != 0) this.blue = blue / 10;
        }

        public override Bitmap ApplyFilter()
        {
            Bitmap adjustedImage = new Bitmap(image.Width, image.Height);

            for (int i = 0; i < image.Height; i++)
            {
                for (int j = 0; j < image.Width; j++)
                {
                    currentColor = image.GetPixel(j, i);

                    int newRed = (int)Math.Min(255, currentColor.R * red);
                    int newGreen = (int)Math.Min(255, currentColor.G * green);
                    int newBlue = (int)Math.Min(255, currentColor.B * blue);

                    newColor = Color.FromArgb(newRed, newGreen, newBlue);

                    adjustedImage.SetPixel(j, i, newColor);
                }
            }

            return adjustedImage;
        }

        public void SetRed(int red)
        {
            this.red = red;
            if (red != 0) this.red /= 10;
        }

        public void SetGreen(int green)
        {
            this.green = green;
            if (green != 0) this.green /= 10;
        }

        public void SetBlue(int blue)
        {
            this.blue = blue;
            if (blue != 0) this.blue /= 10;
        }
    }
}
