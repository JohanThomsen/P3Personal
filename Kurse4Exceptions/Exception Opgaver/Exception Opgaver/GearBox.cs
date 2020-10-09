using System;
using System.Collections.Generic;
using System.Text;

namespace Exception_Opgaver
{
    class GearBox
    {

        private int _currentGear = 1;

        public void ChangeGear(int nextGear)
        {
            bool error = false;
            try
            {
                if (nextGear > 5 ||nextGear < -1)
                {
                    error = true;
                    throw new IllegalArgumentException("This gear does not exist");
                }

                if (nextGear == -1 && _currentGear != 1)
                {
                    error = true;
                    throw new IllegalGearChangeException("You can not go to reverse if you not are currently in first gear");
                }

                if (nextGear != _currentGear + 1 && nextGear != _currentGear - 1)
                {
                    error = true;
                    throw new IllegalGearChangeException("You are not allowed to skip gears");
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }

            if (error == false)
            {
                _currentGear = nextGear;
                Console.WriteLine($"Current Gear is {_currentGear}");
            }
        }
    }
}
