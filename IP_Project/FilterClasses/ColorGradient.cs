using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IP_Project.FilterClasses
{
    internal class ColorGradient : Filter
    {
        public ColorGradient()
        {

        }

        public ColorGradient(Bitmap image) : base(image)
        {

        }

        public override Bitmap ApplyFilter()
        {
            Rectangle fillRectangle = new Rectangle(0, 0, image.Width, image.Height);
            Bitmap bmp = new Bitmap(image.Width, image.Height);
            Graphics g = Graphics.FromImage(bmp);
            Brush gradientBrush = new LinearGradientBrush(fillRectangle, ColorTranslator.FromHtml("#3a1c71"), ColorTranslator.FromHtml("#ffaf7b"), 180);
            g.FillRectangle(gradientBrush, fillRectangle);

            Color p;

            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    p = bmp.GetPixel(x, y);

                    int aa = p.A;
                    int rr = p.R;
                    int gg = p.G;
                    int bb = p.B;

                    bmp.SetPixel(x, y, Color.FromArgb(aa / 2, rr, gg, bb));

                }
            }

            Bitmap result = new Bitmap(Math.Max(image.Width, image.Width),
                     Math.Max(bmp.Height, bmp.Height));
            using (Graphics gr = Graphics.FromImage(result))
            {
                gr.DrawImage(image, Point.Empty);
                gr.DrawImage(bmp, Point.Empty);
            }
            return result;
        }
    }
}
