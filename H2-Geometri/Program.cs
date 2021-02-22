using System;
using System.Collections.Generic;

namespace H2_Geometri
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>() { new Square(32), new Rectangle(24, 8), new Parallelogram(3, 5, 20), new Trapeze(10, 9, 8, 9), new Triangle(16, 32) };

            foreach (var item in shapes)
            {
                if (item is Square)
                {
                    Square s = (Square)item;
                    Console.WriteLine($"Square: A -> {s.GetArea()}");
                }
                else if (item is Trapeze)
                {
                    Trapeze s = (Trapeze)item;
                    Console.WriteLine($"Trapeze: H -> {s.GetArea()}");
                }
            }
        }
    }
}
