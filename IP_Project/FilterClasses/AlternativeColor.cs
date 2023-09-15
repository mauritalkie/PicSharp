using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IP_Project.FilterClasses
{
    internal class AlternativeColor : Filter
    {
        public AlternativeColor()
        {

        }

        public AlternativeColor(Bitmap image) : base(image)
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
                    newColor = Color.FromArgb(currentColor.B, currentColor.G, currentColor.R);
                    finalImage.SetPixel(i, j, newColor);
                }
            }

            return finalImage;
        }
    }
}
