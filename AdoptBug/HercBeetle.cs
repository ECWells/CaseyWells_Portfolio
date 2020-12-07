using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoptBug
{
    class HercBeetle : Bug
    {
        public string Name = "Boss";
        public string Color = "gold and black";
        public string Pattern = "candycane";
        public string Description = "It's a Hercules Beetle. A large beetle with a tough carapace and an impressive pair of horns. They're ready to joust.";

        public override string Examine()
        {
            return $"{Description}\nIt's name is {Name}, it's {Color} and...hold on, it's {Pattern} patterned?!.";
        }
        public override string Talk()
        {
            return $"{Name} swings its head at you.";
        }

        public override string Poke()
        {
            return $"{Name} pushes back into your finger.";
        }
    }
}
