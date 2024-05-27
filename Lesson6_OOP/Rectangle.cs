using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6_OOP
{
    public class Rectangle
    {
        private double _length;
        private double _width;

        public double Length
        {
            get
            {
                return _length;
            }
            private set
            {
                //_length = value <= 0 ? 1 : value; Version without console printing.
                if (value <= 0)
                {
                    _length = 1;
                    Console.WriteLine("Cannot set zero or negative length! Length has been set to 1.");
                }
                else
                {
                    _length = value;
                }
            }
        }

        public double Width
        {
            get
            {
                return _width;
            }
            private set
            {
                if (value <= 0)
                {
                    _width = 1;
                    Console.WriteLine("Cannot set zero or negative width! Width has been set to 1.");
                }
                else
                {
                    _width = value;
                }
            }
        }

        public double Area
        {
            get
            {
                return Length * Width;
            }
        }

        public double Circumference
        {
            get
            {
                return 2 * (Length + Width);
            }
        }
        
        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }
        public Rectangle(double squareSide) : this(squareSide, squareSide) { }

        public void PrintRectangleInfo()
        {
            Console.WriteLine($"rectangle length: {Length}");
            Console.WriteLine($"rectangle width: {Width}");
            Console.WriteLine($"area: {Area}");
            Console.WriteLine($"circumference: {Circumference}");
        }

        public void IncreaseSize() // DOubles the length and width.
        {
            Length += Length;
            Width += Width;
        }
        
        public void ChangeSize(double addLength, double addWidth) // With specified length and width size change.
        {
            Length += addLength;
            Width += addWidth;
        }

        public void ChangeSize(double increment) // Changes length and with by the same increment.
        {
            Length += increment;
            Width += increment;
        }
    }
}
