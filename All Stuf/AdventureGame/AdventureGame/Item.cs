using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{
    public class Item
    {
        public string Name;
        public string Description;
        public int Value;

        public Item(string name, string description, int value)
        {
            Name = name;
            Description = description;
            Value = value;

        }
    }
}
