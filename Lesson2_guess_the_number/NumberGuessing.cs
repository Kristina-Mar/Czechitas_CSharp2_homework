using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_guess_the_number
{
    internal class NumberGuessing
    {
        private int NumberOfGuesses;
        public int IsThisYourNumber(int guessedNumber, int numberToBeGuessed)
        {
            NumberOfGuesses++;
            return guessedNumber.CompareTo(numberToBeGuessed);
        }
        public int HowManyGuesses()
        {
            return NumberOfGuesses;
        }
    }
}
