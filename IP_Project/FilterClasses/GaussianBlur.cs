using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IP_Project.FilterClasses
{
    internal class GaussianBlur : Filter
    {
        public GaussianBlur()
        {

        }

        public GaussianBlur(Bitmap image) : base(image)
        {

        }

        public override Bitmap ApplyFilter()
        {
            return ApplyCovolutionFilter(GenerateGaussianKernel(5, 7));
        }

        private Bitmap ApplyCovolutionFilter(double[,] kernel)
        {
            Bitmap outputImage = new Bitmap(image.Width, image.Height);

            int kernelSize = kernel.GetLength(0);
            int radius = kernelSize / 2;

            for (int y = radius; y < image.Height - radius; y++)
            {
                for (int x = radius; x < image.Width - radius; x++)
                {
                    double sumR = 0, sumG = 0, sumB = 0;

                    for (int ky = 0; ky < kernelSize; ky++)
                    {
                        for (int kx = 0; kx < kernelSize; kx++)
                        {
                            Color pixel = image.GetPixel(x + kx - radius, y + ky - radius);
                            double weight = kernel[ky, kx];

                            sumR += pixel.R * weight;
                            sumG += pixel.G * weight;
                            sumB += pixel.B * weight;
                        }
                    }

                    sumR = Math.Min(Math.Max(sumR, 0), 255);
                    sumG = Math.Min(Math.Max(sumG, 0), 255);
                    sumB = Math.Min(Math.Max(sumB, 0), 255);

                    outputImage.SetPixel(x, y, Color.FromArgb((int)sumR, (int)sumG, (int)sumB));
                }
            }

            return outputImage;
        }

        private double[,] GenerateGaussianKernel(int size, double sigma)
        {
            double[,] kernel = new double[size, size];
            double sum = 0;

            for (int y = 0; y < size; y++)
            {
                for (int x = 0; x < size; x++)
                {
                    kernel[y, x] = Math.Exp(-((x * x + y * y) / (2 * sigma * sigma))) / (2 * Math.PI * sigma * sigma);
                    sum += kernel[y, x];
                }
            }

            for (int y = 0; y < size; y++)
            {
                for (int x = 0; x < size; x++)
                {
                    kernel[y, x] /= sum;
                }
            }

            return kernel;
        }
    }
}
