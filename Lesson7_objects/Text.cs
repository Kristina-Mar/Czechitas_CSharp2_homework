using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7_objects
{
    internal class Text : GraphicObject
    {
        public string TextProperty { get; private set; }

        public Text(string text)
        {
            TextProperty = text;
        }
        public Text(string text, string colour) : this (text)
        {
            Colour = colour;
        }
        public override void PrintToConsole()
        {
            ChangeTextColour();
            Console.WriteLine(TextProperty);
            ChangeTextColourBackToDefault();
        }
    }
}
