using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedC_
{
    internal struct  Point
    {

        public double X { get; set; }
        public double Y { get; set; }
        public  Point (double X, double Y)
        {
           this.X = X;
           this.Y = Y;
        }
        public override string ToString()
        {
            return $"({X},{Y})";
        }
    }
}
