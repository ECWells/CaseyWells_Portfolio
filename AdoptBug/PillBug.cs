using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoptBug
{
    class PillBug : Bug
    {
        public string Name = "Rolycoly";
        public string Color = "blueish gray";
        public string Pattern = "gem plating";
        public string Description = "A small little Pill Bug, when scared it rolls up to hide and protect itself.";

        public override string Examine()
        {
            return $"{Description}\nIt's name is {Name}, its {Color} and...Woah! It's super rare, and has a {Pattern}.";
        }
        public override string Talk()
        {
            return $"{Name} wiggles its tiny antennae.";
        }

        public override string Poke()
        {
            return $"{Name} curls up into a tiny ball.\nThey tremble for a moment, then slowly unroll.";
        }
    }
}
