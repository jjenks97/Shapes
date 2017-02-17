using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class IsoscelesTrapezoid: Quadrilateral
    {
        public double Base1 { get; set; }
        public double Base2 { get; set; }
        public double Altitude { get; set; }

        public override double Area
        {
            get
            {
                double a = (Base1 + Base2)/2 * Altitude;
                return a;
            }
        }

        

        public IsoscelesTrapezoid(double base1, double base2, double altitude, int x = 0, int y = 0)
        {
            double Base1 = base1;
            double Base2 = base2;
            double Altitude = altitude;
        }
    }
}
