using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace AdventureGameCW
{
    class NPC
    {
        public string Name;
        public string Description;
        public Item Gift;

        public NPC(string name, string description, Item gift)
        {
            Name = name;
            Description = description;
            Gift = gift;
        }
    }
}
