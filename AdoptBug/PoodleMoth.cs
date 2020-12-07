using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoptBug
{
    class PoodleMoth : Bug
    {
        public string Name = "Puff";
        public string Color = "white";
        public string Pattern = "matte";
        public string Description = "A Poodle Moth. These little critters are covered in fluff from head to toe, even their wings are soft and fluffy.";

        public override string Examine()
        {
            return $"{Description}\nIt's name is {Name}, it's {Color} and has a common {Pattern} pallete.";
        }
        public override string Talk()
        {
            return $"{Name} flaps it's wings at you, and tilts it's head.";
        }

        public override string Poke()
        {
            return $"{Name} jumps and puffs out their fuzz.\nSomehow you feel they're glaring at you.";
        }
    }
}
