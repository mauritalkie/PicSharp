using Emgu.CV.CvEnum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IP_Project
{
    public partial class Histogram : Form
    {
        private int[] red;
        private int[] green;
        private int[] blue;
        private int highRed = 0;
        private int highGreen = 0;
        private int highBlue = 0;

        public int[] Red
        {
            get { return red; }
            set { red = value; }
        }
        public int[] Green
        {
            get { return green; }
            set { green = value; }
        }
        public int[] Blue
        {
            get { return blue; }
            set { blue = value; }
        }

        public Histogram()
        {
            InitializeComponent();
        }

        private void Histogram_Load(object sender, EventArgs e)
        {
            for (int n = 0; n < 256; n++)
            {
                if (red[n] > highRed)
                {
                    highRed = red[n];
                }
            }
            for (int n = 0; n < 256; n++)
            {
                red[n] = (int)((float)red[n] / (float)highRed * 256.0f);
            }

            for (int n = 0; n < 256; n++)
            {
                if (green[n] > highGreen)
                {
                    highGreen = green[n];
                }
            }
            for (int n = 0; n < 256; n++)
            {
                green[n] = (int)((float)green[n] / (float)highGreen * 256.0f);
            }

            for (int n = 0; n < 256; n++)
            {
                if (blue[n] > highBlue)
                {
                    highBlue = blue[n];
                }
            }
            for (int n = 0; n < 256; n++)
            {
                blue[n] = (int)((float)blue[n] / (float)highBlue * 256.0f);
            }
        }

        private void Histogram_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Pen redPen = new Pen(Color.Red);
            Pen greenPen = new Pen(Color.Green);
            Pen bluePen = new Pen(Color.Blue);
            Pen axis = new Pen(Color.Black);

            graphics.DrawLine(axis, 19, 271, 277, 271);
            graphics.DrawLine(axis, 19, 270, 19, 14);

            for(int n = 0; n < 256; n++)
            {
                graphics.DrawLine(redPen, n + 20, 270, n + 20, 270 - red[n]);
            }
            for (int n = 0; n < 256; n++)
            {
                graphics.DrawLine(greenPen, n + 20, 270, n + 20, 270 - green[n]);
            }
            for (int n = 0; n < 256; n++)
            {
                graphics.DrawLine(bluePen, n + 20, 270, n + 20, 270 - blue[n]);
            }
        }
    }
}
