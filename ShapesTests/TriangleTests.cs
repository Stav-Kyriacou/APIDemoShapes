using System;
using Xunit;
using ShapesLibrary;

namespace ShapesTests
{
    public class TriangleTests
    {
        [Theory]
        [InlineData(1, 1, 1, 1, 1)]
        [InlineData(3, 5, 7, 2, 87)]
        [InlineData(3213, 432, 6754, 312, 854327)]
        [InlineData(543, 4532, 8976, 432, 4312)]
        public void Constructor(int id, double sideBase, double lengthA, double lengthC, double height)
        {
            Triangle t = new Triangle(){ID = id, SideBase = sideBase, SideLengthA = lengthA, SideLengthC = lengthC, Height = height};

            Assert.Equal(t.ID, id);
            Assert.Equal(t.SideBase, sideBase);
            Assert.Equal(t.SideLengthA, lengthA);
            Assert.Equal(t.SideLengthC, lengthC);
            Assert.Equal(t.Height, height);
        }

        [Theory]
        [InlineData(12, 13, 78)]
        [InlineData(3.5, 6.2, 10.85)]
        [InlineData(10, 32.3, 161.5)]
        public void Area(double lengthBase, double height, double expected)
        {
            Triangle t = new Triangle(){ID = 1, SideBase = lengthBase, Height = height};

            Assert.Equal(expected, t.Area);
        }

        [Theory]
        [InlineData(12, 13, 78, 103)]
        [InlineData(3.5, 6.2, 10.85, 20.55)]
        [InlineData(10, 32.3, 161.5, 203.8)]
        public void Circumference(double lengthBase, double sideLengthA, double sideLengthC, double expected)
        {
            Triangle t = new Triangle(){ID = 1, SideBase = lengthBase, SideLengthA = sideLengthA, SideLengthC = sideLengthC};

            Assert.Equal(expected, t.Circumference);
        }
    }
}