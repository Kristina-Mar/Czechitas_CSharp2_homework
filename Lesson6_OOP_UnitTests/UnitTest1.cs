using Lesson6_OOP;

namespace Lesson6_OOP_UnitTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(6, 5, 30, 22)]
        [InlineData(4, 4, 16, 16)]
        [InlineData(2.223, 3.856, 8.571888, 12.158)]
        public void RectangleConstructorTwoParameters_WillCreateRectangleInstance_WhenTwoValidParametersAreProvided(double length, double width, double area, double circumference)
        {            
            RectangleCreation rectangle = new RectangleCreation(length, width);

            Assert.Equal(length, rectangle.Length, 0.0001);
            Assert.Equal(width, rectangle.Width, 0.0001);
            Assert.Equal(area, rectangle.Area, 0.0001);
            Assert.Equal(circumference, rectangle.Circumference, 0.0001);
        }

        [Theory]
        [InlineData(0, 3, 3, 8)]
        [InlineData(-3.6, 2, 2, 6)]
        public void RectangleConstructorTwoParameters_WillCreateRectangleInstance_WhenInvalidLengthParameterIsProvided(double length, double width, double area, double circumference)
        {
            RectangleCreation rectangle = new RectangleCreation(length, width);

            Assert.Equal(1, rectangle.Length, 0.0001);
            Assert.Equal(width, rectangle.Width, 0.0001);
            Assert.Equal(area, rectangle.Area, 0.0001);
            Assert.Equal(circumference, rectangle.Circumference, 0.0001);
        }

        [Theory]
        [InlineData(3, 0, 3, 8)]
        [InlineData(2, -3.6, 2, 6)]
        public void RectangleConstructorTwoParameters_WillCreateRectangleInstance_WhenInvalidWidthParameterIsProvided(double length, double width, double area, double circumference)
        {
            RectangleCreation rectangle = new RectangleCreation(length, width);

            Assert.Equal(length, rectangle.Length, 0.0001);
            Assert.Equal(1, rectangle.Width, 0.0001);
            Assert.Equal(area, rectangle.Area, 0.0001);
            Assert.Equal(circumference, rectangle.Circumference, 0.0001);
        }

        [Theory]
        [InlineData(6, 36, 24)]
        [InlineData(2.223, 4.941729, 8.892)]
        public void RectangleConstructorOneParameter_WillCreateRectangleInstance_WhenValidParameterIsProvided(double side, double area, double circumference)
        {
            RectangleCreation rectangle = new RectangleCreation(side);

            Assert.Equal(side, rectangle.Length, 0.0001);
            Assert.Equal(side, rectangle.Width, 0.0001);
            Assert.Equal(area, rectangle.Area, 0.0001);
            Assert.Equal(circumference, rectangle.Circumference, 0.0001);
        }

        [Theory]
        [InlineData(0, 1, 4)]
        [InlineData(-3.6, 1, 4)]
        public void RectangleConstructorOneParameter_WillCreateRectangleInstance_WhenInvalidParameterIsProvided(double side, double area, double circumference)
        {
            RectangleCreation rectangle = new RectangleCreation(side);

            Assert.Equal(1, rectangle.Length, 0.0001);
            Assert.Equal(1, rectangle.Width, 0.0001);
            Assert.Equal(area, rectangle.Area, 0.0001);
            Assert.Equal(circumference, rectangle.Circumference, 0.0001);
        }

        [Theory]
        [InlineData(2, 35, 24)]
        [InlineData(2.223, 37.725729, 24.892)]
        public void ChangeSizeOneParameter_WillChangeWidthAndLengthByGivenIncrement_WhenValidParameterIsProvided(double length, double width, double increment)
        {
            RectangleCreation rectangle = new RectangleCreation(length, width);

            double expectedLength = length + increment;
            double expectedWidth = width + increment;

            rectangle.ChangeSize(increment);

            Assert.Equal(expectedLength, rectangle.Length, 0.0001);
            Assert.Equal(expectedWidth, rectangle.Width, 0.0001);
        }

        [Theory]
        [InlineData(2, 35, -2)]
        [InlineData(2.223, 37.725729, -3.5)]
        public void ChangeSizeOneParameter_WillChangeWidthAndLengthByGivenIncrement_WhenLengthWouldBecomeInvalid(double length, double width, double increment)
        {
            // If length should mathematically drop to 0 or below.
            RectangleCreation rectangle = new RectangleCreation(length, width);

            double expectedLength = 1;
            double expectedWidth = width + increment;

            rectangle.ChangeSize(increment);

            Assert.Equal(expectedLength, rectangle.Length, 0.0001);
            Assert.Equal(expectedWidth, rectangle.Width, 0.0001);
        }

        [Theory]
        [InlineData(35, 2, -2)]
        [InlineData(37.725729, 2.223, -3.5)]
        public void ChangeSizeOneParameter_WillChangeWidthAndLengthByGivenIncrement_WhenWidthWouldBecomeInvalid(double length, double width, double increment)
        {
            // If width should mathematically drop to 0 or below.
            RectangleCreation rectangle = new RectangleCreation(length, width);

            double expectedLength = length + increment;
            double expectedWidth = 1;

            rectangle.ChangeSize(increment);

            Assert.Equal(expectedLength, rectangle.Length, 0.0001);
            Assert.Equal(expectedWidth, rectangle.Width, 0.0001);
        }

        [Theory]
        [InlineData(2, 8, 77, 36)]
        [InlineData(2.223, 4, 50.561, 28.446)]
        
        public void ChangSizeTwoParameters_WillChangeLengthAndWidthByGivenIncrements_WhenTwoValidParametersAreProvided(double length, double width, double addLength, double addWidth)
        {
            RectangleCreation rectangle = new RectangleCreation(length, width);
            double expectedLength = length + addLength;
            double expectedWidth = width + addWidth;

            rectangle.ChangeSize(addLength, addWidth);

            Assert.Equal(expectedLength, rectangle.Length, 0.0001);
            Assert.Equal(expectedWidth, rectangle.Width, 0.0001);
        }

        [Theory]
        [InlineData(2, 8, -2, 36)]
        [InlineData(2.223, 4, -50.561, 28.446)]

        public void ChangSizeTwoParameters_WillChangeLengthAndWidthByGivenIncrements_WhenInvalidLengthIncrementIsProvided(double length, double width, double addLength, double addWidth)
        {
            // If length should mathematically drop to 0 or below.
            RectangleCreation rectangle = new RectangleCreation(length, width);
            double expectedLength = 1;
            double expectedWidth = width + addWidth;

            rectangle.ChangeSize(addLength, addWidth);

            Assert.Equal(expectedLength, rectangle.Length, 0.0001);
            Assert.Equal(expectedWidth, rectangle.Width, 0.0001);
        }

        [Theory]
        [InlineData(2, 8, 77, -8)]
        [InlineData(2.223, 4, 50.561, -28.446)]

        public void ChangSizeTwoParameters_WillChangeLengthAndWidthByGivenIncrements_WhenInvalidWidthIncrementIsProvided(double length, double width, double addLength, double addWidth)
        {
            // If width should mathematically drop to 0 or below.
            RectangleCreation rectangle = new RectangleCreation(length, width);
            double expectedLength = length + addLength;
            double expectedWidth = 1;

            rectangle.ChangeSize(addLength, addWidth);

            Assert.Equal(expectedLength, rectangle.Length, 0.0001);
            Assert.Equal(expectedWidth, rectangle.Width, 0.0001);
        }

        [Theory]
        [InlineData(3, 2.5)]
        [InlineData(2, 2)]
        [InlineData(1.1115, 1.928)]
        [InlineData(86, 1.5)]

        public void IncreaseSize_WillDoubleLengthAndWidth_WhenExecuted(double length, double width)
        {         
            RectangleCreation rectangle = new RectangleCreation(length, width);
            double expectedLength = length * 2;
            double expectedWidth = width * 2;

            rectangle.IncreaseSize();

            Assert.Equal(expectedLength, rectangle.Length, 0.0001);
            Assert.Equal(expectedWidth, rectangle.Width, 0.0001);
        }
    }
}