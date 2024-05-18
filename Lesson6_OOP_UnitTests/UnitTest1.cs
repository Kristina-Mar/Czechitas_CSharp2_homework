using Lesson6_OOP;

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

            if (length <= 0)
            {
                length = 1;
            }
            if (width <= 0)
            {
                width = 1;
            }
            Assert.Equal(length, rectangle.Length, 0.0001);
            Assert.Equal(width, rectangle.Width, 0.0001);
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
                side = 1;
            }
            Assert.Equal(side, rectangle.Length, 0.0001);
            Assert.Equal(side, rectangle.Width, 0.0001);
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
        public void TestChangeSizeBySameValue(double increment, double area, double circumference)
        {
            double length = 5;
            double width = 3;
            RectangleCreation rectangle = new RectangleCreation(length, width);
            rectangle.ChangeSize(increment);
            length += increment;
            width += increment;

            if (length <= 0)
            {
                length = 1;
            }
            if (width <= 0)
            {
                width = 1;
            }
            Assert.Equal(length, rectangle.Length, 0.0001);
            Assert.Equal(width, rectangle.Width, 0.0001);
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
        
        public void TestChangeSize(double addLength, double addWidth, double area, double circumference)
        {
            double length = 5;
            double width = 3;
            RectangleCreation rectangle = new RectangleCreation(length, width);
            rectangle.ChangeSize(addLength, addWidth);

            length += addLength;
            width += addWidth;

            if (length <= 0)
            {
                length = 1;
            }
            if (width <= 0)
            {
                width = 1;
            }
            Assert.Equal(length, rectangle.Length, 0.0001);
            Assert.Equal(width, rectangle.Width, 0.0001);
            Assert.Equal(area, rectangle.Area, 0.0001);
            Assert.Equal(circumference, rectangle.Circumference, 0.0001);
        }

        [Theory]
        [InlineData(3, 2.5, 30, 22)]
        [InlineData(2, 2, 16, 16)]
        [InlineData(1.1115, 1.928, 8.571888, 12.158)]
        [InlineData(1, 1.5, 6, 10)]

        public void TestIncreaseSize(double length, double width, double area, double circumference)
        {
            RectangleCreation rectangle = new RectangleCreation(length, width);
            rectangle.IncreaseSize();

            Assert.Equal(length * 2, rectangle.Length, 0.0001);
            Assert.Equal(width * 2, rectangle.Width, 0.0001);
            Assert.Equal(area, rectangle.Area, 0.0001);
            Assert.Equal(circumference, rectangle.Circumference, 0.0001);
        }
    }
}