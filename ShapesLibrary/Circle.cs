using System;

namespace ShapesLibrary
{
    public class Circle
    {
        public int ID { get; set;}

        public double Radius { get; set; }
        public double Diameter => Radius * 2;
        public double Area => Math.Round(Math.PI * (Radius * Radius), 2);
        public double Circumference => Math.Round(2 * Math.PI * Radius, 2);
    }
}