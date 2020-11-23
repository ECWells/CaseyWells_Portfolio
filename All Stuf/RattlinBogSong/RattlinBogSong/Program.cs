using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Casey Wells
 * Song Exercise
 * 10-18-2020
 * I used the resources provided in past modules to guide me through this process
 */
namespace RattlinBogSong
{
    class Program
    {
        private const string reason = "Now in the {0} there was a {1},";
        private static readonly string[] objects = { "bog", "tree", "branch", "limb", "nest", "bird", "wing", "egg", "feather", "egg" };

        private static readonly string[] comments =
        {
            "Hi ho, the rattlin' bog",
            "The bog down in the valley-o,",
            "And the bog down in the valley-o,",
            "And the branch on the tree,",
            "And the tree in the hole,",
            "And the hole in the bog,",
            "And the limb on the branch,",
            "And the nest on the limb,",
            "And the bird in the nest",
            "And the egg on the bird,",
            "And the bird on the egg,",
            "And the wing on the bird,",
            "And the feather on the wing,",

        };
        static void Main(string[] args)
        {
            // I could not figure out how to add there was a {1} so that it would add the object and go up the line, I kept getting an error and I have no idea how to fix it
            
            Console.Title = "Rattlin' Bog";
            int max = objects.Length;
            for (int i = 0; i < max; i++)
            {
                Console.WriteLine("Now in the {0}", objects[i]);
                //Console.WriteLine("A rare {1}, a rattlin' {1}", objects[i]); got the error about being greater than or equal to zero, but it won't let me make it greater than or equal to zero
                Console.WriteLine(comments[i]);
                for (int j = i; j > 0 && i < max - 1; j--)
                {
                    Console.WriteLine(reason, objects[j], objects[j - 1]);
                    if (j == 1)
                    {
                        Console.WriteLine(comments[j - 1]);
                    }
                }
            }

            Console.Read();
        }
    }
}
