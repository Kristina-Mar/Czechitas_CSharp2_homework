namespace Lesson2_guess_the_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NumberGenerator numberGenerator = new NumberGenerator();
            int numberToBeGuessed = numberGenerator.GenerateNumber();

            Player player = new Player();

            Console.WriteLine("I am of thinking a number from 1 to 100. Can you guess which one?");

            string input = Console.ReadLine();
            int guess = 0;
            bool IsGuessANumber = int.TryParse(input, out guess);

            while (!IsGuessANumber || guess < 1 || guess > 100)
            {
                Console.WriteLine("Incorrect, try again with a number from 1 to 100:");
                input = Console.ReadLine();
                IsGuessANumber = int.TryParse(input, out guess);
            }

            while (!player.IsThisYourNumber(guess, numberToBeGuessed)) // The player guesses until they get the answer right.
            {
                input = Console.ReadLine();
                IsGuessANumber = int.TryParse(input, out guess);
                while (!IsGuessANumber || guess < 1 || guess > 100) // The game only allows numbers from 1 to 100.
                {
                    Console.WriteLine("Incorrect, try again with a number from 1 to 100:");
                    input = Console.ReadLine();
                    IsGuessANumber = int.TryParse(input, out guess);
                }
            }
            Console.ReadLine();
        }
    }
}
