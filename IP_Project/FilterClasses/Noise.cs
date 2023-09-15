using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IP_Project.FilterClasses
{
    internal class Noise : Filter
    {
        public Noise()
        {

        }

        public Noise(Bitmap image) : base(image)
        {

        }

        public override Bitmap ApplyFilter()
        {
            int percentage = 150;
            int minRange = 85;
            int maxRange = 115;
            float brightness;
            Random random = new Random();
            int red, green, blue;
            Bitmap finalImage = new Bitmap(image.Width, image.Height);

            for (int i = 0; i < image.Width; i++)
            {
                for (int j = 0; j < image.Height; j++)
                {
                    if (random.Next(minRange, maxRange) <= percentage)
                    {
                        brightness = random.Next(minRange, maxRange) / 100.0f;
                        currentColor = image.GetPixel(i, j);

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
                        newColor = image.GetPixel(i, j);
                    }

                    finalImage.SetPixel(i, j, newColor);
                }
            }

            return finalImage;
        }
    }
}
