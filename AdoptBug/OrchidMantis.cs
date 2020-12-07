using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoptBug
{
    class OrchidMantis : Bug
    {
        public string Name = "Gardner";
        public string Color = "pink and white";
        public string Pattern = "shiny";
        public string Description = "An Orchid Mantis, with flashy eyestalks and beautiful colors.";

        public override string Examine()
        {
            return $"{Description}\nIt's name is {Name}, it's {Color} and wow!! It's {Pattern}!.";
        }
        public override string Talk()
        {
            return $"{Name} waves its dagger hands at you, tilting from side to side.";
        }

        public override string Poke()
        {
            return $"You really shouldn't do that. {Name} might bite.";
        }
    }
}
