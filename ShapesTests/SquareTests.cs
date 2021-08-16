using System;
using Xunit;
using ShapesLibrary;


namespace ShapesTests
{
    public class SquareTests
    {
        [Theory]
        [InlineData(1, 1)]
        [InlineData(45, 3.6)]
        [InlineData(230, 72.345)]
        public void Constructor(int pID, double pSideLength)
        {
            Square s = new Square(){ID = pID, SideLength = pSideLength};

            Assert.Equal(pSideLength, s.SideLength);
            Assert.Equal(pID, s.ID);
        }

        [Theory]
        [InlineData(1, 1)]
        [InlineData(3.4, 11.56)]
        [InlineData(27.1, 734.41)]
        public void Area(double pSideLength, double Expected)
        {
            Square s = new Square(){ID = 1, SideLength = pSideLength};

            Assert.Equal(Expected, s.Area);
        }

        [Theory]
        [InlineData(1, 4)]
        [InlineData(3.4, 13.6)]
        [InlineData(27.1, 108.4)]
        public void Circumference(double pSideLength, double Expected)
        {
            Square s = new Square(){ID = 1, SideLength = pSideLength};

            Assert.Equal(Expected, s.Circumference);
        }
    }
}