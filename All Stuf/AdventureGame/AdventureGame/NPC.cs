using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace AdventureGame
{
   public class NPC
    {
        public string Name;
        public string Description;

        public NPC(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }

}
