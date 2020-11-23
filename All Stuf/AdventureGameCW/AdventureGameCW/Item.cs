using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace AdventureGameCW
{
    class Item
    {
        public string Name;
        public string Description;

        public Item(string name, string description)
        {
            Name = name;
            Description = description;
        }

        //public string ShowItems()
        //{
         //   return $"{Name} ){Description}";
        //}
    }
}
