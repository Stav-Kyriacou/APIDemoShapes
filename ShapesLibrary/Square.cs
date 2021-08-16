using System;

namespace ShapesLibrary
{
    public class Square
    {
        public int ID { get; set;}

        public double SideLength { get; set; }

        public double Circumference => Math.Round(SideLength * 4, 2);

        public double Area => Math.Round(SideLength * SideLength, 2);
    }
}
