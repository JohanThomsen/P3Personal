using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kurse8UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kurse8UnitTesting.Tests
{
    [TestClass()]
    public class CircleTests
    {
        [TestMethod()]
        public void IsPointInCircleTestTrue()
        {
            //Arrange
            Circle c = new Circle(0, 0, 4);
            double x = 2;
            double y = 2;

            //Act
            bool result = c.IsPointInCircle(x, y);

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void IsPointInCircleTestFalse()
        {
            //Arrange
            Circle c = new Circle(0, 0, 4);
            double x = 5;
            double y = 5;

            //Act
            bool result = c.IsPointInCircle(x, y);

            //Assert
            Assert.IsFalse(result);
        }

        [TestMethod()]
        public void DoesCircleOverlapTestTrue()
        {
            //Arrange
            Circle c = new Circle(0, 0, 4);
            Circle c2 = new Circle(4, 4, 5);

            //Act
            bool result = c.DoesCircleOverlap(c2);

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void DoesCircleOverlapTestFalse()
        {
            //Arrange
            Circle c = new Circle(0, 0, 4);
            Circle c2 = new Circle(7, 7, 2);

            //Act
            bool result = c.DoesCircleOverlap(c2);

            //Assert
            Assert.IsFalse(result);
        }
    }
}