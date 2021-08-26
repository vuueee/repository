using System;

namespace FigureLibrary
{
    public interface IFigure
    {
        double Square();
        string ShowInfo();
    }

    public class Circle : IFigure
    {
        double radius {get;set;}

        public Circle(double radius) {
            this.radius = radius;
        }        
        public double Square() {
            return Math.PI*radius*radius;
        }
        public string ShowInfo() {
            return $"Круг с радиусом = {radius}";
        }
    }
    public class Triangle : IFigure
    {
        double a {get;set;}
        double b {get;set;}
        double c {get;set;}

        public Triangle(double a,double b, double c) {
            this.a = a;
            this.b =b;
            this.c =c;
        }        
        public double Square() {
            double p = (a + b + c)/ 2.0;
            return Math.Sqrt(p * (p-a)* (p-b)*(p-c));
        }
        public bool IsRectangular() {
            if( a*a+b*b == c*c || a*a+c*c == b*b || b*b + c*c == a*a) 
                return true;
            return false;
        }
        public string ShowInfo() {
            if(this.IsRectangular()) 
                return $"прямоугольный треугольник со сторонами ({a};{b};{c})";
            return $"треугольник со сторонами ({a};{b};{c})";
        }
    }
}