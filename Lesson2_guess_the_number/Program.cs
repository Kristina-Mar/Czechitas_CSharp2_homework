namespace Lesson2_guess_the_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NumberGenerator numberGenerator = new NumberGenerator();
            int numberToBeGuessed = numberGenerator.GenerateNumber();

            NumberGuessing player = new NumberGuessing();

            Console.WriteLine("I am of thinking a number from 1 to 100. Can you guess which one?");

            string input = Console.ReadLine();
            int guessedNumber = 0;
            bool IsGuessANumber = int.TryParse(input, out guessedNumber);

            while (!IsGuessANumber || guessedNumber < 1 || guessedNumber > 100)
            {
                Console.WriteLine("Incorrect, try again with a number from 1 to 100:");
                input = Console.ReadLine();
                IsGuessANumber = int.TryParse(input, out guessedNumber);
            }
            while (true) // The player guesses until they get the answer right.
            {
                int guess = player.IsThisYourNumber(guessedNumber, numberToBeGuessed);
                if (guess == 0)
                {
                    Console.WriteLine($"That's right, I was thinking of {numberToBeGuessed}. Well done! You got the right answer in {player.HowManyGuesses()} guesses.");
                    break;
                }
                if (guess > 0)
                {
                    Console.WriteLine("The number I'm thinking of is lower, try again!");
                }
                if (guess < 0)
                {
                    Console.WriteLine("The number I'm thinking of is higher, try again!");
                }
                input = Console.ReadLine();
                IsGuessANumber = int.TryParse(input, out guessedNumber);
                while (!IsGuessANumber || guessedNumber < 1 || guessedNumber > 100) // The game only allows numbers from 1 to 100.
                {
                    Console.WriteLine("Incorrect, try again with a number from 1 to 100:");
                    input = Console.ReadLine();
                    IsGuessANumber = int.TryParse(input, out guessedNumber);
                }
            }
            Console.ReadLine();
        }
    }
}
