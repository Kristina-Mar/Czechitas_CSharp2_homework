using Lesson6_OOP;
using System.Drawing;

namespace Lesson6_OOP_UnitTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(6, 5, 30, 22)]
        [InlineData(4, 4, 16, 16)]
        [InlineData(2.223, 3.856, 8.571888, 12.158)]
        [InlineData(0, 3, 3, 8)]
        [InlineData(-3.6, 2, 2, 6)]
        [InlineData(5, 0, 5, 12)]
        [InlineData(5.3, -3, 5.3, 12.6)]
        [InlineData(0, -3, 1, 4)]
        public void TestRectangleCreation(double length, double width, double area, double circumference)
        {            
            RectangleCreation rectangle = new RectangleCreation(length, width);

            if (length <= 0 && width <= 0)
            {
                Assert.Equal(1, rectangle.Length, 0.0001);
                Assert.Equal(1, rectangle.Width, 0.0001);
            }
            else if (length <= 0)
            {
                Assert.Equal(1, rectangle.Length, 0.0001);
                Assert.Equal(width, rectangle.Width, 0.0001);
            }
            else if (width <= 0)
            {
                Assert.Equal(length, rectangle.Length, 0.0001);
                Assert.Equal(1, rectangle.Width, 0.0001);
            }
            else
            {
                Assert.Equal(length, rectangle.Length, 0.0001);
                Assert.Equal(width, rectangle.Width, 0.0001);
            }
            Assert.Equal(area, rectangle.Area, 0.0001);
            Assert.Equal(circumference, rectangle.Circumference, 0.0001);
        }

        [Theory]
        [InlineData(6, 36, 24)]
        [InlineData(2.223, 4.941729, 8.892)]
        [InlineData(0, 1, 4)]
        [InlineData(-3.6, 1, 4)]
        public void TestSquareCreation(double side, double area, double circumference)
        {
            RectangleCreation rectangle = new RectangleCreation(side);

            if (side <= 0)
            {
                Assert.Equal(1, rectangle.Length, 0.0001);
                Assert.Equal(1, rectangle.Width, 0.0001);
            }
            else
            {
                Assert.Equal(side, rectangle.Length, 0.0001);
                Assert.Equal(side, rectangle.Width, 0.0001);
            }
            Assert.Equal(area, rectangle.Area, 0.0001);
            Assert.Equal(circumference, rectangle.Circumference, 0.0001);
        }

        [Theory]
        [InlineData(2, 35, 24)]
        [InlineData(2.223, 37.725729, 24.892)]
        [InlineData(0, 15, 16)]
        [InlineData(-2, 3, 8)]
        [InlineData(-5, 1, 4)]
        [InlineData(-7, 1, 4)]
        public void TestIncreaseSizeBySameValue(double increment, double area, double circumference)
        {
            double length = 5;
            double width = 3;
            RectangleCreation rectangle = new RectangleCreation(length, width);
            rectangle.ChangeSize(increment);

            if (length + increment <= 0 && width + increment <= 0)
            {
                Assert.Equal(1, rectangle.Length, 0.0001);
                Assert.Equal(1, rectangle.Width, 0.0001);
            }
            else if (length + increment <= 0)
            {
                Assert.Equal(1, rectangle.Length, 0.0001);
                Assert.Equal(width + increment, rectangle.Width, 0.0001);
            }
            // This case won't happen with current length (5) and width (3).
            /* else if (width + increment <= 0)
            {
                Assert.Equal(length + increment, rectangle.Length, 0.0001);
                Assert.Equal(1, rectangle.Width, 0.0001);
            } */
            else
            {
                Assert.Equal(length + increment, rectangle.Length, 0.0001);
                Assert.Equal(width + increment, rectangle.Width, 0.0001);
            }
            Assert.Equal(area, rectangle.Area, 0.0001);
            Assert.Equal(circumference, rectangle.Circumference, 0.0001);
        }

        [Theory]
        [InlineData(2, 8, 77, 36)]
        [InlineData(2.223, 4, 50.561, 28.446)]
        [InlineData(0, 15, 90, 46)]
        [InlineData(-2, -4, 3, 8)]
        [InlineData(-5, 1, 4, 10)]
        [InlineData(-7, -6, 1, 4)]
        
        public void TestIncreaseSize(double addLength, double addWidth, double area, double circumference)
        {
            double length = 5;
            double width = 3;
            RectangleCreation rectangle = new RectangleCreation(length, width);
            rectangle.ChangeSize(addLength, addWidth);

            if (length + addLength <= 0 && width + addWidth <= 0)
            {
                Assert.Equal(1, rectangle.Length, 0.0001);
                Assert.Equal(1, rectangle.Width, 0.0001);
            }
            else if (length + addLength <= 0)
            {
                Assert.Equal(1, rectangle.Length, 0.0001);
                Assert.Equal(width + addWidth, rectangle.Width, 0.0001);
            }
            else if (width + addWidth <= 0)
            {
                Assert.Equal(length + addLength, rectangle.Length, 0.0001);
                Assert.Equal(1, rectangle.Width, 0.0001);
            }
            else
            {
                Assert.Equal(length + addLength, rectangle.Length, 0.0001);
                Assert.Equal(width + addWidth, rectangle.Width, 0.0001);
            }
            Assert.Equal(area, rectangle.Area, 0.0001);
            Assert.Equal(circumference, rectangle.Circumference, 0.0001);
        }
    }
}