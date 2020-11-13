using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kurse8UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kurse8UnitTesting.Tests
{
    [TestClass()]
    public class _2DVectorTests
    {
        [TestMethod()]
        public void _2DVectorTest()
        {
            _2DVector v = new _2DVector(2, 3);

            Assert.AreEqual(v.X, 2);
            Assert.AreEqual(v.Y, 3);
        }

        [TestMethod()]
        public void AddTest()
        {
            _2DVector v = new _2DVector(2, 3);
            _2DVector v2 = new _2DVector(4, 5);

            _2DVector result = v.Add(v2);
            Console.WriteLine($"{result.X} {result.Y}");

            Assert.AreEqual(result.X, 6);
            Assert.AreEqual(result.Y, 8);

            //Assert.AreEqual(result, new _2DVector(6, 8));
        }

        [TestMethod()]
        public void SubtractTest()
        {
            _2DVector v = new _2DVector(4, 5);
            _2DVector v2 = new _2DVector(2, 2);

            _2DVector result = v.Subtract(v2);

            Assert.AreEqual(result.X, 2);
            Assert.AreEqual(result.Y, 3);

            //Assert.AreEqual(result, new _2DVector(2, 3));
        }

        [TestMethod()]
        public void ScalarTest()
        {
            _2DVector v = new _2DVector(3, 4);
            _2DVector v2 = new _2DVector(2, 2);

            double result = v.Scalar(v2);

            Assert.AreEqual(result, 14);
        }

        [TestMethod()]
        public void CrossProductTest()
        {
            _2DVector v = new _2DVector(3, 4);
            _2DVector v2 = new _2DVector(2, 2);

            double result = v.CrossProduct(v2);

            Assert.AreEqual(result, -2);
        }
    }
}