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
        private int[] red, green, blue;

        private int highestRed = 0;
        private int highestGreen = 0;
        private int highestBlue = 0;

        private Images parentWindow;
        private bool isOrigin, isFiltered;

        public int[] Red { set { red = value; } }
        public int[] Green { set { green = value; } }
        public int[] Blue { set { blue = value; } }

        public Images ParentWindow { set { parentWindow = value; } }
        public bool IsOrigin { set { isOrigin = value; } }
        public bool IsFiltered { set { isFiltered = value; } }

        public Histogram()
        {
            InitializeComponent();
        }

        private void Histogram_Load(object sender, EventArgs e)
        {
            for (int n = 0; n < 256; n++)
            {
                if (red[n] > highestRed) highestRed = red[n];
                if (green[n] > highestGreen) highestGreen = green[n];
                if (blue[n] > highestBlue) highestBlue = blue[n];
            }

            for (int n = 0; n < 256; n++)
            {
                red[n] = (int)((float)red[n] / (float)highestRed * 256.0f);
                green[n] = (int)((float)green[n] / (float)highestGreen * 256.0f);
                blue[n] = (int)((float)blue[n] / (float)highestBlue * 256.0f);
            }
        }

        private void Histogram_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Pen redPen = new Pen(Color.Red);
            Pen greenPen = new Pen(Color.Green);
            Pen bluePen = new Pen(Color.Blue);
            Pen axis = new Pen(Color.AliceBlue);

            graphics.DrawLine(axis, 19, 271, 277, 271);
            graphics.DrawLine(axis, 19, 270, 19, 14);

            for (int n = 0; n < 256; n++)
                graphics.DrawLine(redPen, n + 20, 270, n + 20, 270 - red[n]);

            for (int n = 0; n < 256; n++)
                graphics.DrawLine(greenPen, n + 20, 270, n + 20, 270 - green[n]);

            for (int n = 0; n < 256; n++)
                graphics.DrawLine(bluePen, n + 20, 270, n + 20, 270 - blue[n]);
        }

        private void Histogram_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isOrigin) parentWindow.OriginChild = null;
            if (isFiltered) parentWindow.FilteredChild = null;
        }
    }
}
