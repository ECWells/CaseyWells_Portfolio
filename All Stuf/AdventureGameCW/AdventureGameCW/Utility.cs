using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace AdventureGameCW
{
    class Utility
    {
        public static Random random = new Random();

        public static void Pause()
        {
            WriteLine("Press any key to continue...");
            ReadKey();
        }

        public static int GetRandomNumber(int max)
        {
            return random.Next(max);
        }

        public static void ResetApplicationColors()
        {
            Clear();
        }
    }
}
