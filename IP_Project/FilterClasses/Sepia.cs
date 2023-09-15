using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IP_Project.FilterClasses
{
    internal class Sepia : Filter
    {
        public Sepia()
        {

        }

        public Sepia(Bitmap image) : base(image)
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

                    finalImage.SetPixel(i, j, Color.FromArgb(alpha, red, green, blue));
                }
            }
            
            return finalImage;
        }
    }
}
