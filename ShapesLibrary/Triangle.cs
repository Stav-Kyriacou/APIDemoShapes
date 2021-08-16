using System;

namespace ShapesLibrary
{
    public class Triangle
    {
        //create class
        //create unit tests
        //create controller (GET, PUT, POST, DELETE)
        public int ID { get; set;}

        public double SideBase { get; set; }
        public double SideLengthA { get; set; }
        public double SideLengthC { get; set; }
        public double Height { get; set; }

        public double Circumference => Math.Round(SideBase + SideLengthA + SideLengthC, 2);

        public double Area => Math.Round((SideBase * Height) / 2, 2);
    }
}