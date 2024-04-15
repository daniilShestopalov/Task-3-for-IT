using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{

    internal class Line : Shape, InterfaceShape
    {
        private Point start;
        private Point end;

        public Line(Point start, Point end)
            : base((start.XCenter + end.XCenter) / 2, (start.YCenter + end.YCenter) / 2)
        {
            this.start = start;
            this.end = end;
        }

        public override double XCenter
        {
            get => (start.XCenter + end.XCenter) / 2;
            set => throw new NotImplementedException();
        }

        public override double YCenter
        {
            get => (start.YCenter + end.YCenter) / 2;
            set => throw new NotImplementedException();
        }

        public override double CalculateArea()
        {
            return 0;
        }

        public override (double xMin, double yMin, double xMax, double yMax) СalculateСoordinatesOfRectangle()
        {
            double xMin = Math.Min(start.XCenter, end.XCenter);
            double yMin = Math.Min(start.YCenter, end.YCenter);
            double xMax = Math.Max(start.XCenter, end.XCenter);
            double yMax = Math.Max(start.YCenter, end.YCenter);

            return (xMin, yMin, xMax, yMax);
        }
    }
}
