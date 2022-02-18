using System;
using Xunit;
using TestProject2;

namespace TestProject2
{
    public class UnitTest1
    {
        
        
        
        [Theory]
        [InlineData(2, 2, 37.69911184307752)]
        [InlineData(3, 5, 115.32222380081598)]
        [InlineData(3, 6, 113.09733552923255)]
        [InlineData(4, 2, 93.79666719905791)]
        [InlineData(17, 5, 1177.1770972363543)]
        [InlineData(20, 5, 1459.5058189245667)]
        [InlineData(000.1, 00.2, 0.12566370614359174)]
        [InlineData(13, 2, 446.31551880720724)]
        [InlineData(7, 5, 367.4325951031408)]
        [InlineData(14, 2, 493.0900437769198)]
        [InlineData(1, 1, 9.42477796076938)]
        [InlineData(5, 5, 235.61944901923448)]
        [InlineData(3, 1, 39.92400011466094)]
        [InlineData(8, 4, 375.18666879623163)]
        [InlineData(9, 3, 359.3160010319484)]
        [InlineData(8, 0, 0)]
        [InlineData(2.5, 3, 66.36213725627486)]
        [InlineData(0, 0, 0)]
        [InlineData(1.2, 1, 12.000441436928348)]
        [InlineData(4.7, 4.5, 202.22429064222024)]
        public void Test1(double a, double b,double res)
        {
            double act = TestClass.SectorSurfaceArea(a,b);

            Assert.Equal(res, act);
        }
    }
}
