using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    struct Position
    {
        public int x { get; set; }
        public int y { get; set; }

        public Position(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return $"({x}, {y})";
        }
    }

    abstract class Shape
    {

        public Position Center { get; set; }

        public Shape(int x = 0, int y = 0) : this(new Position(x, y))
        {
        }

        public Shape(Position p)
        {
            Center = p;
        }

        public abstract double Area { get; }

        public abstract double Perimeter { get; }


    }
}
