using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotProject
{
    class Pot
    {
        private int diameter = 9;
        private int minimumDiameter = 1;
        private string measurementSystem = "inches";
        private int step = 1;

        public Pot()
        {
            Console.WriteLine("Steps to draw a Dogon-like pot:");
            DrawPot();
        }

        private void DrawPot()
        {
            if (diameter<=minimumDiameter)
            {
                Console.WriteLine($"{step}. Draw the lid");
            }

            else
            {
                Console.WriteLine($"{step}. Draw a circle that is {diameter} {measurementSystem} in size");
            }

            //I'm not sure what I was asked to do. This is how I understood the instructions. I don't understand what I'm supposed to code if it's told to me in the language of code.
           if (diameter = 6)
            {
                Console.WriteLine($"{step}. Draw the base");
            }

            else
            {
                Console.WriteLine($"{step}. Draw a circle that is the {diameter} {measurementSystem} in size");
            }
           
        }

        
    }
}
