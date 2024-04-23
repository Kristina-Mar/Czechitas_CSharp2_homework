using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_archer
{
    internal class Archer
    {
        private int RemainingArrows = 10;
        public bool IsOutOfArrows = false;
        public void ShootArrow()
        {
            if (RemainingArrows > 0)
            {
                RemainingArrows--;
                if (RemainingArrows == 0)
                {
                    IsOutOfArrows = true;
                }
            }
        }
        public bool IsLastShot()
        {
            return RemainingArrows == 1;
        }
    }
}
