using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7_objects
{
    internal class Triangle : GraphicObject
    {
        public int Heigth {get; set;}

        public Triangle(int heigth)
        {
            Heigth = heigth;
        }
        public Triangle(int heigth, string colour) : this (heigth)
        {
            Colour = colour;
        }
        public override void PrintToConsole()
        {
            int numberOfCharacters = 1;
            int lengthOfLineIncludingSpaces = Heigth;
            ChangeTextColour();
            for (int i = 0; i < Heigth; i++)
            {
                Console.WriteLine(new String('#', numberOfCharacters).PadLeft(lengthOfLineIncludingSpaces));
                numberOfCharacters += 2;
                lengthOfLineIncludingSpaces++;
            }
            ChangeTextColourBackToDefault();
        }
    }
}
