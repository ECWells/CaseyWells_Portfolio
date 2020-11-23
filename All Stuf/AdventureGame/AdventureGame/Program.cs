using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

/*
 * Casey Wells
 * Adventure Game Progress
 * 11-8-2020
 */
namespace AdventureGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Casey Wells Adventure Game";
            Game game = new Game();
            game.Start();
        }
    }
}
