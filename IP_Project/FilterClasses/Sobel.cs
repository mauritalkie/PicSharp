using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace IP_Project.FilterClasses
{
    internal class Sobel : Filter
    {
        public Sobel()
        {

        }

        public Sobel(Bitmap image) : base(image)
        {

        }

        public override Bitmap ApplyFilter()
        {
            Grayscale grayscale = new Grayscale(image);
            Bitmap grayscaleImage = grayscale.ApplyFilter();

            Bitmap sobelImage = new Bitmap(grayscaleImage.Width, grayscaleImage.Height);

            int[,] sobelX = new int[,] { { -1, 0, 1 }, { -2, 0, 2 }, { -1, 0, 1 } };
            int[,] sobelY = new int[,] { { -1, -2, -1 }, { 0, 0, 0 }, { 1, 2, 1 } };

            for (int y = 1; y < grayscaleImage.Height - 1; y++)
            {
                for (int x = 1; x < grayscaleImage.Width - 1; x++)
                {
                    int gx = 0;
                    int gy = 0;

                    for (int j = -1; j <= 1; j++)
                    {
                        for (int i = -1; i <= 1; i++)
                        {
                            Color color = grayscaleImage.GetPixel(x + i, y + j);
                            int grayValues = color.R;
                            gx += sobelX[i + 1, j + 1] * grayValues;
                            gy += sobelY[i + 1, j + 1] * grayValues;
                        }
                    }

                    int sobelValue = (int)Math.Sqrt(gx * gx + gy * gy);
                    sobelValue = Math.Min(sobelValue, 255);
                    Color sobelColor = Color.FromArgb(sobelValue, sobelValue, sobelValue);
                    sobelImage.SetPixel(x, y, sobelColor);
                }
            }

            return sobelImage;
        }
    }
}
