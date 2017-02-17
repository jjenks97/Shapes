using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Square: Rectangle
    {
        public double Side
        {
            get
            {
                return len;
            }
        }


        public Square(double side, int x = 0, int y = 0)
        {
            double Side = side;
        }
    }
}
