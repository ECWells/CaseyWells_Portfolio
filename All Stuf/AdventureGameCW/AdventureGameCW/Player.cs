using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace AdventureGameCW
{
    class Player
    {
        public static string Name = "Catherine";
        public string Input;
        public List<Item> Inventory;

        public Player()
        {
            Inventory = new List<Item>();
        }

        public string InventoryAdd(Item item)
        {
            Inventory.Add(item);
            return $"You picked up {item.Name}.";
        }

        public bool SearchInventory(string word)
        {
            foreach(Item i in Inventory)
            {
                if (i.Name.ToLower().Contains(word))
                {
                    return true;
                }
            }
            return false;
        }
        public string ShowInventory()
        {
            string output = "   Inventory\n   ------\n";
            if (Inventory.Count >0)
            {
                foreach (Item i in Inventory)
                {
                    output += "     " + i.Name + "\n";
                }
            }
            else
            {
                output = "Your inventory is empty.";
            }

            return output;
        }
    }
}
