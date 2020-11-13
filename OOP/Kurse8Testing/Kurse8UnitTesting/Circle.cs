using System;
using System.Collections.Generic;
using System.Text;

namespace Kurse8UnitTesting
{
    public class Circle
    {
        public Circle(double centerX, double centerY, double radius)
        {
            CenterX = centerX;
            CenterY = centerY;
            Radius = radius;
        }

        public double CenterX { get; set; }
        public double CenterY { get; set; }
        public double Radius { get; set; }

        public bool IsPointInCircle(double pointX, double pointY)
        {
            double distance = Math.Sqrt(Math.Pow(pointX - CenterX, 2) + Math.Pow(pointY - CenterY, 2));
            return (distance <= Radius);
        }

        public bool DoesCircleOverlap(Circle c)
        {
            double combineRadius = Radius + c.Radius;
            double X = CenterX - c.CenterX;
            double Y = CenterY - c.CenterY;

            double distance = Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2));
            return (distance <= combineRadius);
        }

    }

}
