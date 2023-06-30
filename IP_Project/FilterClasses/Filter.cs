using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IP_Project.FilterClasses
{
    internal abstract class Filter
    {
        protected Bitmap image;
        protected Color currentColor;
        protected Color newColor;

        public Filter()
        {

        }

        public Filter(Bitmap image)
        {
            this.image = image;
        }

        public abstract Bitmap ApplyFilter();

        public void UpdateFrame(Bitmap image)
        {
            this.image = image;
        }
    }
}
