using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IP_Project.FilterClasses
{
    internal class ChromaticAberration : Filter
    {
        public ChromaticAberration()
        {

        }

        public ChromaticAberration(Bitmap image) : base(image)
        {

        }

        public override Bitmap ApplyFilter()
        {
            int aberrationSize = 5;
            int red = 0;
            int green = 0;
            int blue = 0;
            Bitmap finalImage = new Bitmap(image.Width, image.Height);

            for (int i = 0; i < image.Width; i++)
            {
                for (int j = 0; j < image.Height; j++)
                {
                    green = image.GetPixel(i, j).G;

                    if (i + aberrationSize < image.Width)
                        red = image.GetPixel(i + aberrationSize, j).R;
                    else
                        red = 0;

                    if (i - aberrationSize >= 0)
                        blue = image.GetPixel(i - aberrationSize, j).B;

                    finalImage.SetPixel(i, j, Color.FromArgb(red, green, blue));
                }
            }

            return finalImage;
        }
    }
}
