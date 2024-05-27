using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7_objects
{
    internal class GraphicObject
    {
        public string Colour { get; set; } = "White";

        public void ChangeTextColourBackToDefault()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        public void ChangeTextColour()
        {
            Console.ForegroundColor = Enum.TryParse<ConsoleColor>(Colour, out ConsoleColor parsedColour) ? parsedColour : ConsoleColor.Gray;
        }
        public virtual void PrintToConsole()
        {
            Console.WriteLine("X");
        }
    }
}
