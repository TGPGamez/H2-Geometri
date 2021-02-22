using System;
using System.Collections.Generic;
using System.Text;

namespace H2_Geometri
{
    public abstract class Shape : ICalculate
    {
        protected double a;
        public double A
        {
            get { return a; }
            set { a = value; }
        }

        protected double b;
        public double B
        {
            get { return b; }
            set { b = value; }
        }

        protected Shape(double a, double b)
        {
            A = a;
            B = b;
        }

        public double GetCircumference()
        {
            return (a * 2) + (b * 2);
        }

        public double GetArea()
        {
            return a * b;
        }
    }
}
