using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace square_library
{
    public class Circle : IFigure
    {
        public double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double CalculateSquare()
        {
            return Math.PI * Math.Pow(radius, 2);
        }        
    }
}
