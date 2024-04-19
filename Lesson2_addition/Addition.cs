using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_addition
{
    internal class Addition
    {
        double Sum;
        public void AddAndWriteResult(double number1, double number2)
        {
            Sum = number1 + number2;
            Console.WriteLine($"{number1} + {number2} = {Sum}");
        }
    }
}
