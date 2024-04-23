namespace Lesson2_cycle_asterisks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many asterisks should I write?");
            string input = Console.ReadLine();
            int numberOfAsterisks;
            bool isValidInteger = int.TryParse(input, out numberOfAsterisks);
            while (!isValidInteger || numberOfAsterisks <= 0)
            {
                Console.WriteLine("I need an integer bigger than 0, try again:");
                input = Console.ReadLine();
                isValidInteger = int.TryParse(input, out numberOfAsterisks);
            }
            for (int i = 0; i < numberOfAsterisks; i++)
            {
                Console.Write("*");
            }
            Console.ReadLine();
        }
    }
}
