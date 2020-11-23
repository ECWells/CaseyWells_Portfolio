using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace AdventureGame
{
    public class Locations
    {
        public string Name;
        public string Description;
        List<Item> Items;

        public Locations(string name, string description, List<Item> items)
        {
            Name = name;
            Description = description;
            Items = items;
        }

        public static void ShowName()
        {
            return $"{Name}";
        }

        public static void ShowInformation()
        {
            return $"{Description}";
        }
    }


}
