using System;
using System.Collections.Generic;
using FigureLibrary;
namespace ShowCase
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle EgyptianTrianel = new Triangle(3,4,5);
            Circle OnesCircle = new Circle(1);
            List<IFigure> Figures = new List<IFigure>();
            Figures.Add(EgyptianTrianel);
            Figures.Add(OnesCircle);

            foreach (var item in Figures)
            {
                Console.WriteLine($"{item.ShowInfo()} с площадью = {item.Square()}");

            } 

        }
    }
}
