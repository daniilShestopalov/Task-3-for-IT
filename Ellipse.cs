using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Ellipse : Shape, InterfaceShape
    {
        public double RadiusX { get; private set; }
        public double RadiusY { get; private set; }

        public Ellipse(Point center, double radiusX, double radiusY)
            : base(center.XCenter, center.YCenter)
        {
            RadiusX = radiusX;
            RadiusY = radiusY;
        }

        public override double XCenter
        {
            get => xCenter;
            set
            {

            }
            // Здесь сеттер не нужен, так как центр эллипса не меняется.
        }

        public override double YCenter
        {
            get => yCenter;
            set
            {

            }
            // Здесь сеттер не нужен, так как центр эллипса не меняется.
        }

        public override double CalculateArea()
        {
            return Math.PI * RadiusX * RadiusY;
        }

        public override (double xMin, double yMin, double xMax, double yMax) СalculateСoordinatesOfRectangle()
        {
            return (xCenter - RadiusX, yCenter - RadiusY, xCenter + RadiusX, yCenter + RadiusY);
        }
    }
}
