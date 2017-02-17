using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Rectangle: Quadrilateral
    {
        public double len { get; set; }
        public double wid { get; set; }
        public override double Area
        {
            get
            {
                double a = len * wid;
                return a;
            }
        }

        public override double Perimeter
        {
            get
            {
                return (len * 2) + (wid * 2);
            }
        }

        public Rectangle(double length, double width, int x = 0, int y = 0) 
            :base (x,y)
        {
            double len = length;
            double wid = width;
        }

        public override string ToString()
        {
            return $"Length: {len}; Width: {wid} ; Center: {Center}";
        }
    }
}
