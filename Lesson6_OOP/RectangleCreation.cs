using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6_OOP
{
    public class RectangleCreation
    {
        private double _length;
        private double _width;
        private double _area;
        private double _circumference;

        public double Length
        {
            get
            {
                return _length;
            }
            private set
            {
                //_length = value <= 0 ? 1 : value;
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
                _area = Length * Width;
                return _area;
            }
        }

        public double Circumference
        {
            get
            {
                _circumference = 2 * (Length + Width);
                return _circumference;
            }
        }
        
        public RectangleCreation(double length, double width)
        {
            Length = length;
            Width = width;
        }
        public RectangleCreation(double squareSide) : this(squareSide, squareSide) { }

        public void PrintRectangleInfo()
        {
            Console.WriteLine($"rectangle length: {Length}");
            Console.WriteLine($"rectangle width: {Width}");
            Console.WriteLine($"area: {Area}");
            Console.WriteLine($"circumference: {Circumference}");
        }

        public void ChangeSize(double addLength, double addWidth)
        {
            Length += addLength;
            Width += addWidth;
        }

        public void ChangeSize(double increment)
        {
            Length += increment;
            Width += increment;
        }
    }
}
