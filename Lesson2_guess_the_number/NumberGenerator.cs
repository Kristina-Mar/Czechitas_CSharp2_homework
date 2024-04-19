using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_guess_the_number
{
    internal class NumberGenerator
    {
        public int GenerateNumber()
        {
            Random numberGenerator = new Random();
            return numberGenerator.Next(1, 101);
        }
    }
}
