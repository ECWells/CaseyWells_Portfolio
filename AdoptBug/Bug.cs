using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoptBug
{
    class Bug
    {
        public string Name = "Buggy";
        public string Color = "Green";
        public string Pattern = "Mettalic";
        public string Description = "";

        public virtual string Examine()
        {
            return "";
        }

        public virtual string Talk()
        {
            return $"{Name} clicks at you.";
        }

        public virtual string Poke()
        {
            return $"{Name} hisses grumpily at you.";
        }
    }
}
