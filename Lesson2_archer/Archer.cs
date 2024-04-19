using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_archer
{
    internal class Archer
    {
        public int NumberOfArrows = 10;
        public void ShootArrow()
        {
            if (NumberOfArrows > 0)
            {
                NumberOfArrows--;
                Console.WriteLine("Bullseye everytime, baby!");
                if (NumberOfArrows == 0)
                {
                    Console.WriteLine("This was my last shot.");
                }
            }
            else
            {
                Console.WriteLine("I'm out of arrows!");
            }
        }
    }
}
