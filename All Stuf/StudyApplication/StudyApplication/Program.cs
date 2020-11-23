using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

/*
 * Casey Wells
 * Intro to Programming
 * Study Application
 * 10-11-2020
 * Sources are the links provided in the assignment
 */

namespace StudyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.Start();
        }

    }

    class Game
    {
        public string Name;
        public Game()
        {
            Console.Title = "Study Application by Casey Wells";
            Console.ForegroundColor = ConsoleColor.White;
        }
        public void Start()
        {
            Console.WriteLine("Welcome to the Study Application");
            Console.WriteLine("You'll be provided a list of Terms and Defintions from the Programming subject.");
            Console.ReadKey();
            Console.WriteLine("But first we need your name. What is your name?");
            Player.Name = Console.ReadLine();
            Console.WriteLine("Let's get started " + Player.Name + ".");
            Console.ReadKey();

            Console.WriteLine("Here are a few terms and their definitions.");
            Console.ReadKey();

            Term boolterm = new Term();
            boolterm.Name = "Boolean";
            boolterm.Definition = "A true false statement.";

            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine(boolterm.Name);
            Console.WriteLine(boolterm.Definition);
            Console.ReadKey();

            Term conterm = new Term();
            conterm.Name = "Constructor";
            conterm.Definition = "The functions that are called whenever you instantiate the object from a class";

            Console.WriteLine(conterm.Name);
            Console.WriteLine(conterm.Definition);
            Console.ReadKey();

            Console.ReadLine();
            
        }
    }

    class Player
    {
        public static string Name;
        public static string Input;

        public void ChooseTerm()
        {

        }
    }

    class Term
    {
        public string Name;
        public string Definition;


        public void ShowTerm()
        { }

        public void ShowDefinition()
        { }
    }

 
}
