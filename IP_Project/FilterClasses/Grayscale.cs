using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IP_Project.FilterClasses
{
    internal class Grayscale : Filter
    {
        public Grayscale()
        {

        }

        public Grayscale(Bitmap image) : base(image)
        {

        }

        public override Bitmap ApplyFilter()
        {
            Bitmap finalImage = new Bitmap(image.Width, image.Height);

            for (int i = 0; i < image.Width; i++)
            {
                for (int j = 0; j < image.Height; j++)
                {
                    currentColor = image.GetPixel(i, j);
                    newColor = Color.FromArgb(currentColor.R, currentColor.R, currentColor.R);
                    finalImage.SetPixel(i, j, newColor);
                }
            }

            return finalImage;
        }
    }
}
