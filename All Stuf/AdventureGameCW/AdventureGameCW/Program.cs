using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace AdventureGameCW
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Casey Wells Adv. Game";
            Game game = new Game();
            game.Start();
        }
    }
}
