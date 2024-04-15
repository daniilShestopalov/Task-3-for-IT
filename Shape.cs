using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    abstract class Shape
    {
        protected double xCenter;
        protected double yCenter;
        
        public abstract double XCenter { get; set; }
        public abstract double YCenter { get; set; }

        public Shape(double x, double y) 
        {
            xCenter = x;
            yCenter = y;
        }

        public abstract double CalculateArea();
        public abstract (double xMin, double yMin, double xMax, double yMax) СalculateСoordinatesOfRectangle();
    }
}
