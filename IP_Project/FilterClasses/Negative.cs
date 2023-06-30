using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IP_Project.FilterClasses
{
    internal class Negative : Filter
    {
        public Negative()
        {

        }

        public Negative(Bitmap image) : base(image)
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
                    newColor = Color.FromArgb(255 - currentColor.R, 255 - currentColor.G, 255 - currentColor.B);
                    finalImage.SetPixel(i, j, newColor);
                }
            }

            return finalImage;
        }
    }
}
