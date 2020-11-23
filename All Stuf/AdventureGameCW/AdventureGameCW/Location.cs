using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace AdventureGameCW
{
    class Location
    {
        public string Name;
        public string Description;
        List<Item> Items;

        public Location(string name, string description, List<Item> items)
        {
            Name = name;
            Description = description;
            Items = items;
        }

        public string ShowInformation()
        {
            return $"{Name}";
        }

        public Item GetItem()
        {
            int itemNumber = Utility.GetRandomNumber(Items.Count);
            return Items[itemNumber];
        }
    }
}
