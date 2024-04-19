namespace Lesson2_archer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Archer legolas = new Archer();
            while (legolas.NumberOfArrows > 0) // Fires all the arrows.
            {
                legolas.ShootArrow();
            }
            Console.ReadLine();
            legolas.ShootArrow(); // The archer doesn't have any more arrows, the message will let the user know.
            Console.ReadLine();
        }
    }
}
