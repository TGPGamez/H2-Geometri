using System;
using System.Collections.Generic;
using System.Text;

namespace H2_Geometri
{
    class Parallelogram : Shape, ICalculate
    {
        private double angle;
        public double Angle
        {
            get { return angle; }
            set { angle = value; }
        }

        public Parallelogram(double a, double b, double angle) : base(a, b) 
        {
            Angle = angle;
        }

        public double GetCircumference()
        {
            return (a * 2) + (b * 2);
        }

        public double GetArea()
        {
            return a * b * Math.Sin(angle * 3.1415 / 180);
        }
    }
}
