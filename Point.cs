using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Point(double x, double y) : Shape(x, y), InterfaceShape
    {
        public override double XCenter 
        {
            get => xCenter;
            set => xCenter = value; 
        }
        public override double YCenter 
        {
            get => yCenter;
            set => yCenter = value;
        }

        public override double CalculateArea()
        {
            return 0;
        }

        public override (double xMin, double yMin, double xMax, double yMax) СalculateСoordinatesOfRectangle()
        {
            return (xCenter, yCenter, xCenter, yCenter);
        }
    }
}
