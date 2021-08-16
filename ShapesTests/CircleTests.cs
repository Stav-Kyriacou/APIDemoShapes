using System;
using Xunit;
using ShapesLibrary;

namespace ShapesTests
{
    public class CircleTests
    {
        [Theory]
        [InlineData(1, 2)]
        [InlineData(2, 3214312)]
        public void Constructor(int id, double radius)
        {
            Circle c = new Circle(){ID = id, Radius = radius};
            Assert.Equal(c.ID, id);
            Assert.Equal(c.Radius, radius);
        }

        [Theory]
        [InlineData(2, 12.57)]
        [InlineData(4, 50.27)]
        public void Area(double radius, double expected)
        {
            Circle c = new Circle(){Radius = radius};
            Assert.Equal(c.Area, expected);
        }
        [Theory]
        [InlineData(2, 12.57)]
        [InlineData(4, 25.13)]
        public void Circumference(double radius, double expected)
        {
            Circle c = new Circle(){Radius = radius};
            Assert.Equal(c.Circumference, expected);
        }
    }
}
