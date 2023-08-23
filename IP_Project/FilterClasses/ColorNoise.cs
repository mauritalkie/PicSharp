﻿using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace IP_Project.FilterClasses
{
    internal class ColorNoise : Filter
    {
        public ColorNoise()
        {

        }

        public ColorNoise(Bitmap image) : base(image)
        {

        }

        public override Bitmap ApplyFilter()
        {
            //var image = img;
            int w = image.Width;
            int h = image.Height;

            BitmapData image_data = image.LockBits(
                new Rectangle(0, 0, w, h),
                ImageLockMode.ReadOnly,
                PixelFormat.Format24bppRgb);
            int bytes = image_data.Stride * image_data.Height;
            byte[] buffer = new byte[bytes];
            byte[] result = new byte[bytes];
            Marshal.Copy(image_data.Scan0, buffer, 0, bytes);
            image.UnlockBits(image_data);

            byte[] noise = new byte[bytes];
            double[] erlang = new double[256];
            double a = 5.5;
            Random rnd = new Random();
            double sum = 0;

            for (int i = 0; i < 256; i++)
            {
                double step = (double)i * 0.01;
                if (step >= 0)
                {
                    erlang[i] = (double)(a * Math.Exp(-a * step));
                }
                else
                {
                    erlang[i] = 0;
                }
                sum += erlang[i];
            }

            for (int i = 0; i < 256; i++)
            {
                erlang[i] /= sum;
                erlang[i] *= bytes;
                erlang[i] = (int)Math.Floor(erlang[i]);
            }

            int count = 0;
            for (int i = 0; i < 256; i++)
            {
                for (int j = 0; j < (int)erlang[i]; j++)
                {
                    noise[j + count] = (byte)i;
                }
                count += (int)erlang[i];
            }

            for (int i = 0; i < bytes - count; i++)
            {
                noise[count + i] = 0;
            }

            noise = noise.OrderBy(x => rnd.Next()).ToArray();

            for (int i = 0; i < bytes; i++)
            {
                result[i] = (byte)(buffer[i] + noise[i]);
            }

            Bitmap result_image = new Bitmap(w, h);
            BitmapData result_data = result_image.LockBits(
                new Rectangle(0, 0, w, h),
                ImageLockMode.WriteOnly,
                PixelFormat.Format24bppRgb);
            Marshal.Copy(result, 0, result_data.Scan0, bytes);
            result_image.UnlockBits(result_data);

            return result_image;
        }
    }
}
