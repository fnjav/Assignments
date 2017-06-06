using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleTest
{
    class Rectangle
    {
        private double _length = 1;
        private double _width = 1;

        public double Length
        {
            get
            {
                return _length;
            }
            set
            {
                if (value < 0.0 || value > 20.0)
                {
                    _length = 1.0;
                }
                else
                {
                    _length = value;
                }
            }
        }

        public double Width
        {
            get
            {
                return _width;
            }
            set
            {
                if (value < 0.0 || value > 20.0)
                {
                    _width = 1.0;
                }
                else
                {
                    _width = value;
                }
            }
        }

        public override string ToString()
        {
            return string.Format("Length: {0:0}\nWidth: {1:0}\nPerimeter: {2:0}\nArea: {3:0}\n", Length, Width, (Length + Width) * 2, Length * Width);
        }
    }
}
