using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace AdventureGame
{
    class Game
    {
        Player player = new Player();
        List<Locations> Home;
        public void Start()
        {
            SetUp();
            WriteLine("Welcome to my game.\nYou'll be following Catherine through the adventure.\nHit any key to start. ");
            ReadKey();
            Clear();
            WriteLine("Light streams in through the window, brightening the many plants resting there.\nYou're sitting at the desk, covered in a cluttered mess of paper, jars and books.");
            ReadKey();
            WriteLine("What do you do?");

            string input = ReadLine();

            if (input.ToLower().Contains(""))
            {
               if (input.ToLower().Contains("look room"))
               {
                    WriteLine("It's your bedroom.\nThere's a window covered in bug netting, where you have potted plants.\nA chest and a wardrobe are up against the wall.\nThere's a desk attatched to the wall, and multiple shelves above it.\nBeside the desk is your bed, surrounded by mosquito netting.\nAcross from the desk in the floor, is a trap door.");
                    ReadKey();
                    return;
               }
               
               if (input.ToLower().Contains("look desk"))
               {
                    WriteLine("On the desk are multiple papers that you've been writing magical equations and notes on.\nAt the back of the desk is a stack of books, with titles ranging from the science of plants to the quantum effects of the arcane.\nYou're favorite book, Plants and Animals of the World, sits open against the wall.\nMultiple jars precariously line the edge of the desk. They each contain bugs, a variety of colors and species.");
                    ReadKey();
                    //string input = ReadLine();
                    //if (input.ToLower().Contains("Take book"))
                       // {
                           
                       // }
                    return;
               }

            }

            //WriteLine("What do you do?")

           // string input = ReadLine();



           // ShowLocations();
            ReadKey();
            ReadKey();
        }

        private void SetUp() 
        {
            Home = new List<Locations>()
            {
                new Locations("Kitchen", "A small kitchen with a counter against the back wall.\nA large cauldron hangs from the ceiling, taking up a majority of the kitchen.", 
                    new List<Item> { 
                        new Item("Note","A note from Amir", 0),
                        new Item("Pouch of Gold", "A pouch of 25 gold left by Amir", 25),
                        new Item("Packed Lunch", "Your lunch, some diced fish and steamed vegetables", 1)
                }
                ),
                new Locations("Sitting Room", "A cozy living area that wraps around the gnarled base of a massive tree.\nA bookshelf sits snug against the nearest wall, every shelf completely full.\nAn couch and well used armchair rest on a lightly patterned rug.\nThere's an open view to the kitchen, and the front door is right beside the ladder up to your room.",
                    new List<Item> {
                        new Item("Backpack","Your backpack, you'll need it to hold all your supplies.", 0)
                    }
                    ),
                new Locations("Dock", "A wooden dock wraps around the hut.\nThere's a hanging tarp roof over the left side of the dock.\nFishing supplies hang from the posts, along with a few lanterns.\nIn front of the door the dock extends over the water, where a canoe is tied.", 
                    new List<Item>
                    {
                        new Item("Fishing Pole","One of the many fishing poles you have.\nThis one has a few feathers tied to the base.", 1),
                        new Item("Net","A fishing net. This one has a few tears, but it still works", 3)
                    }
                    )
            };
        }

        private void ShowLocations()
        {
            int num = 1;
            int indexNumber = 0;
            foreach (Locations locations in Home)
            {
                WriteLine(num + ") " + locations.ShowName());
                num++;
            }
        }

    }
}
