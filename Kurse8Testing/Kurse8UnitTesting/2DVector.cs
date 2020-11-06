using System;
using System.Collections.Generic;
using System.Text;

namespace Kurse8UnitTesting
{
    public class _2DVector
    {
        public _2DVector(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double X { get; set; }
        public double Y { get; set; }

        public _2DVector Add(_2DVector v)
        {
            return new _2DVector(X + v.X, Y + v.Y);
        }

        public _2DVector Subtract(_2DVector v)
        {
            return new _2DVector(X - v.X, Y - v.Y);
        }

        public double Scalar(_2DVector v)
        {
            return (X * v.X) + (Y * v.Y);
        }

        public double CrossProduct(_2DVector v)
        {
            return (X * v.Y) - (Y * v.X);
        }
    }
}
