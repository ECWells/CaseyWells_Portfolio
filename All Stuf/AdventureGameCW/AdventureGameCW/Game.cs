using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
/*
 * Casey Wells
 * Intro to Programming
 * Adventure Game project
 * 11-15-2020
 * I used the resources provided in class and tutor help
 */

namespace AdventureGameCW
{
    class Game
    {
        Player Catherine = new Player();
        List<Location> Home;
        List<Location> Swamp;
        public void Start()
        {
            SetUp();
            WriteLine("Welcome to my game.\nYou'll be following Catherine through the adventure.\nHit any key to start.");
            ReadKey();
            Clear();
            WriteLine("Catherine lives in hut in the swamp with Amir. It's surrounded by deep murky water and towering trees.\nIt's early noon, Amir left earlier that day.\nHe left a note that he'd gone out to get more supplies, and that he would be back that night.");
            ReadKey();
            ShowLocations();
            //I could not get the end game sequence to run off the parameters I wanted.
            EndGame();

        }

        private void SetUp()
        {
            Home = new List<Location>()
                {
                    new Location("Bedroom", "Your bedroom, a clutterd mess of books and paper.\nJarred bugs cover the desk and shelves.\nThere's an open window, where you can see the murky waters in front of the hut.", 
                        new List<Item>
                    {
                        new Item("Staff","Your trusty quarterstaff, which you use to cast a variety of magics.\nSomething seems off about it. You're not quite sure.\nThe gnarled wood twists up to form a small tree at the top. It seems odd to you."),
                        new Item("Silver Crow Pendant","A gift from Amir. As long as you have it, you know you can always contact him.\nYou recall using it many times before, but you not to find Amir."),
                        new Item("Travel Mask","A bone mask, to keep your face hidden while traveling.\nYou use it every time when you go out with Amir. You've forgotten it the last time you went out, though."),
                        new Item("Book of Identification","It's full of animals from far and wide, you would read through a random page every night.\nYou open to a page with an animal you recognize. Odd, it's not from the swamp. ")
                    }
                    ),
                    new Location("Kitchen","A small kitchen with a counter against the back wall.\nA large cauldron hangs from the ceiling, taking up a majority of the kitchen.",
                        new List<Item>
                        {
                            new Item("Note", "A note from Amir. It reads that he's gone off to gather more supplies.\nYou read over the note a few more times, finding an odd sadness.\nYou can't help but think that you won't see him again."),
                            new Item("Packed Lunch","Your lunch, some diced fish and steamed vegetables.")
                        }
                        ),
                    new Location("Sitting Room","A cozy living area that wraps around the gnarled base of a massive tree.\nA bookshelf sits snug against the nearest wall, every shelf completely full.\nA couch and well used armchair rest on a lightly patterned rug.\nThere's an open view to the kitchen, and the front door is right beside the ladder up to your room.",
                        new List<Item>
                        {
                            new Item("Travel Bag","Your backpack, great at carrying more than it probably should.\nIt's never as much as you'd like, anything bigger than a book and you have to hand it off.")
                        }
                        ),
                    new Location("Dock","A wooden dock wraps around the hut.\nThere's a hanging tarp roof over the left side of the dock.\nFishing supplies hang from the posts, along with a few lanterns.\nIn front of the door the dock extends over the water, where a canoe is tied.",
                        new List<Item>
                        {
                            new Item("Fishing Pole","One of the many fishing poles you have. This one has decorative feathers tied to the handle.\nThere's a familiar comfort as you hold it in your hand.\nYou miss fishing."),
                            new Item("Canoe","Your canoe, useful for navigating the waterways of the swamp.\nYou've fallen off it once before, that was an embarassing and dangerous experience you'd rather not live again."),
                            new Item("Lantern","A small lantern to guide the way at night. You used to sit by the window and wait to see one glowing in the dark.\nIt always let you know that Amir was back home. It stopped you worrying about him.\nThis one isn't doing anything to stop you worrying.")
                        }
                        )
                };

            Swamp = new List<Location>()
            {
                new Location("Bucket House","A small community that recently cropped up in the swamp.\nIt's surprisingly busy, and you don't recognize many faces.", 
                    new List<Item>
                    {

                    }
                    ),
                new Location("Shallow Fishery","The busiest trading town. There are pleny of familiar faces around.",
                    new List<Item>
                    {

                    }
                    )
            };
        }

        private void ShowLocations()
        {
            int num = 1;
            int indexNumber = 0;
            foreach (Location locations in Home)
            {
                WriteLine(num + ") " + locations.ShowInformation());
                num++;
            }
            WriteLine("Where would you like to go?\nEnter the number of the place you'd like to go, or enter i to show your inventory.");
            string input = ReadLine();
            if (input.ToLower() == "i")
            {
                WriteLine(Catherine.ShowInventory());
                Utility.Pause();
                ShowLocations();
            }
            else
            {
                indexNumber = Convert.ToInt32(input);
                Travel(indexNumber - 1);
            }
        }

        private void ShowSWampLocations()
        {
            int num = 1;
            int indexNumber = 0;
            foreach (Location locations in Swamp)
            {
                WriteLine(num + ") " + locations.ShowInformation());
                num++;
            }
            WriteLine("Where would you like to go?\nEnter the number of the place you'd like to go, or enter i to show your inventory.");
            string input = ReadLine();
            if (input.ToLower() == "i")
            {
                WriteLine(Catherine.ShowInventory());
                Utility.Pause();
                ShowLocations();
            }
            else
            {
                indexNumber = Convert.ToInt32(input);
                Travel(indexNumber - 1);
            }
        }

        private void Travel(int indexNumber)
        {
            Clear();
            WriteLine("" + Home[indexNumber].Description);

            Item item = Home[indexNumber].GetItem();
            GiveItem(item);

            Utility.Pause();
            ShowLocations();
        }

        private bool GiveItem(Item item)
        {
            WriteLine("There's a " + item.Name + " )" + item.Description);
            WriteLine("Would you like to take it? Enter yes or no.");
            string input = ReadLine();
            if (input.ToLower().Contains("y"))
            {
                WriteLine(Catherine.InventoryAdd(item));
                return true;
            }
            return false;
        }

        public void EndGame()
        {
            Clear();
            WriteLine("You wake up to a particularly rough jostle of the boat. The hull is constantly creaking, and odd lullaby.\nYou look around to the full bedrolls, realizing it had just been a dream.\nWith a sigh you get up, weaving around your slumbering companions until you reach the stairs to the top deck.\nYou walk out to the boat's banister, resting against it, eyes focuesed on the dotting of trees on the horizon.\nThey were trees you recognized, trees that grew more gnarled and massive as you traversed the Warm.\nTrees that surrounded your little hut in the swamp.\nYou're almost home.");

        }
    }
}
