using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using FigureLibrary;
using System.Collections.Generic;

namespace FigureLibraryTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestRectangularTriangle()
        {
            Triangle[] Triangles=  {new Triangle(3,4,5),new Triangle(8, 15, 17),new Triangle(12,5,13)};

            foreach(var v in Triangles) {
                Assert.IsTrue(v.IsRectangular(),$"{v.ShowInfo()} треугольник прямоуглоьный");
            }

            
        }
        [TestMethod]
        public void TestSimpleTriangle()
        {
            Triangle[] Triangles= {new Triangle(7,5,6),new Triangle(10 ,8, 15),new Triangle(5,5,5)};

            foreach(var v in Triangles) {
                Assert.IsFalse(v.IsRectangular(),$"{v.ShowInfo()} треугольник не прямоугольный ");
            }
        }
        [TestMethod]
        public void TestCircleSquare()
        {
           Circle[] Circles =  {new Circle(1.0),new Circle(5.0),new Circle(10.0)};
            double [] reuslt = new double [] {3.141592653589793,78.53981633974483,314.1592653589793};
            for(int i=0;i<Circles.Length;i++) {
                Assert.AreEqual(Circles[i].Square(),reuslt[i]);
            }
        }

    }
}
