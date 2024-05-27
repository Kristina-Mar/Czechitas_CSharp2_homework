using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7_objects
{
    internal class Rectangle : GraphicObject
    {
        public int Length { get; private set; }
        public int Width { get; private set; }

        public Rectangle(int length, int width)
        {
            Length = length;
            Width = width;
        }
        public Rectangle(int length, int width, string colour) : this (length, width)
        {
            Colour = colour;
        }
        public override void PrintToConsole()
        {
            ChangeTextColour();
            for (int i = 0; i < Width; i++)
            {
                Console.WriteLine(new String('#', Length));
            }
            ChangeTextColourBackToDefault();
        }
    }
}
