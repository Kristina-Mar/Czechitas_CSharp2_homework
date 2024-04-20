using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_guess_the_number
{
    internal class NumberGuessing
    {
        int NumberOfGuesses;
        public bool IsThisYourNumber(int guessedNumber, int numberToBeGuessed)
        {
            NumberOfGuesses++;
            if (guessedNumber > numberToBeGuessed)
            {
                Console.WriteLine("The number I'm thinking of is lower, try again!");
            }
            else if (guessedNumber < numberToBeGuessed)
            {
                Console.WriteLine("The number I'm thinking of is higher, try again!");
            }
            else
            {
                Console.WriteLine($"That's right, I was thinking of {numberToBeGuessed}. Well done! You got the right answer in {NumberOfGuesses} guesses.");
            }
            return guessedNumber == numberToBeGuessed;
        }
    }
}
