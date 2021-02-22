using System;
using System.Collections.Generic;
using System.Text;

namespace H2_Geometri
{
    class Triangle : Shape, ICalculate
    {
        private double c;

        public double C
        {
            get { return c; }
            set { c = value; }
        }

        public Triangle(double a, double b) : base(a, b)
        {
            C = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
        }

        public double GetCircumference()
        {
            return a + b + c;
        }

        public double GetArea()
        {
            return 0.5 * a * b;
        }
    }
}
