namespace Lesson2_archer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Archer legolas = new Archer();
            while (!legolas.IsOutOfArrows) // Fires all the arrows.
            {
                if (legolas.IsLastShot())
                {
                    Console.WriteLine("This is my last shot.");
                }
                legolas.ShootArrow();
                Console.WriteLine("Bullseye everytime, baby!");
            }
            Console.ReadLine();
            if (legolas.IsOutOfArrows)
            {
                Console.WriteLine("I'm out of arrows!"); // The archer doesn't have any more arrows, the message will let the user know.
            }
            Console.ReadLine();
        }
    }
}
