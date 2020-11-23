using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Casey Wells
 * Recursion Assignment
 * 10-18-2020
 * Based on Dogon Pot pseudo code from the book
 * African Fractals: Modern Computing and Indigenous Design by Ron Eglash
 */

namespace PotProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Example steps to draw a Dogon-like pot.";
            new Pot();
            Console.ReadKey();
        }
    }
}
