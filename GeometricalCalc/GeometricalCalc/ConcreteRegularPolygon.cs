using System;
using System.Collections.Generic;
using System.Text;

namespace GeometricalCalc
{
    public class ConcreteRegularPolygon
    {
        public int NumberOfSides { get; set; }
        public int SideLength { get; set; }

        public ConcreteRegularPolygon(int sides, int length)
        {
            NumberOfSides = sides;
            SideLength = length;
        }

        public double GetPerimiter()
        {
            return NumberOfSides * SideLength;
        }

        public virtual double GetArea()
        {
            throw new NotImplementedException();
        }
    }
}
