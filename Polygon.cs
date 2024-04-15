using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Polygon : Shape, InterfaceShape
    {
        private List<Point> points;

        private void CalculateCenter()
        {
            double xSum = points.Sum(p => p.XCenter);
            double ySum = points.Sum(p => p.YCenter);

            xCenter = xSum / points.Count;
            yCenter = ySum / points.Count;
        }
        public Polygon(IEnumerable<Point> points) : base(0, 0)
        {
            this.points = points.ToList();
            CalculateCenter();
        }

        public override double XCenter { get => xCenter; set => throw new NotImplementedException(); }
        public override double YCenter { get => yCenter; set => throw new NotImplementedException(); }

        public override double CalculateArea()
        {
            int numVertices = points.Count;
            double area = 0;

            for (int i = 0; i < numVertices - 1; i++)
            {
                area += points[i].XCenter * points[i + 1].YCenter;
                area -= points[i].YCenter * points[i + 1].XCenter;
            }

            
            area += points[numVertices - 1].XCenter * points[0].YCenter;
            area -= points[numVertices - 1].YCenter * points[0].XCenter;

            
            return Math.Abs(area) / 2.0;
        }

        public override (double xMin, double yMin, double xMax, double yMax) СalculateСoordinatesOfRectangle()
        {
            double xMin = points.Min(p => p.XCenter);
            double xMax = points.Max(p => p.XCenter);
            double yMin = points.Min(p => p.YCenter);
            double yMax = points.Max(p => p.YCenter);

            return (xMin, yMin, xMax, yMax);
        }
    }
}
