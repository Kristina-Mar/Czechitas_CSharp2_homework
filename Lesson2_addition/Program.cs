namespace Lesson2_addition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Addition addition1 = new Addition();
            Console.WriteLine($"Write two numbers you want to add up.");
            Console.Write($"Number 1: ");
            string input1 = Console.ReadLine();
            double number1;
            bool isInput1Number = double.TryParse(input1, out number1);
            while (!isInput1Number)
            {
                Console.Write($"Incorrect format, write number 1 again: ");
                input1 = Console.ReadLine();
                isInput1Number = double.TryParse(input1, out number1);
            }
            Console.Write($"Number 2: ");
            string input2 = Console.ReadLine();
            double number2;
            bool isInput2Number = double.TryParse(input2, out number2);
            while (!isInput2Number)
            {
                Console.Write($"Incorrect format, write number 2 again: ");
                input2 = Console.ReadLine();
                isInput2Number = double.TryParse(input2, out number2);
            }
            addition1.AddAndWriteResult(number1, number2);
            Console.ReadLine();
        }
    }
}
