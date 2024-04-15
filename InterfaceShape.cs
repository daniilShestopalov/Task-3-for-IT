using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal interface InterfaceShape
    {
        public double CalculateArea();
        public (double xMin, double yMin, double xMax, double yMax) СalculateСoordinatesOfRectangle()
    }
}
