using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace StudyApplicationTwo
{
    class Application
    {
        // Title("Casey wells Study Application Two"); The window title isnt working

        Player CurrentPlayer;
        Term[] Terms;

        static List<string> Terms = new List<string>();
        //I can't add terms, I don't know how, and I can't figure it out. None of this makes sense
        //Terms.Add("Array");
        //Terms.Add("Instance");
        //Terms.Add("Private");
        //Terms.Add("Public");
        //Terms.Add("Funtion/Method Argument");
        //Terms.Add("Function/Method Parameter");
        //Terms.Add("Void", "A keyword that maeans a function does not return a value.", new string[] {
          //  "The name of a parameter that is passed into a funciton.",
            //"A function that returns only one value.",
            //"An infinite loop.",
//}));
        //Terms.Add("Static");
        //Terms.Add("Conditional Statement");
        //Terms.Add("Increment");
        //Terms.Add("While Loop");
        //Terms.Add("For Loop");
        //Terms.Add("Switch");
        public void Start ()
        {
            WriteLine("Welcome to the study application.");
            WriteLine("What's your name?");
            Player.Name = ReadLine();
            WriteLine("Let's get started " + Player.Name + ".");
            ReadKey();

            DisplayTerms();
            CheckAnswer();


            ReadKey();
        }

        void DisplayTerms()
        {
            //I don't understand what this does, or how it connects to other pieces of the code.
            //I'm trying to build off the code from the video, but I don't understand why he's done any of it or what any of it does.
            bool isCorrect = currentTerm.AskForDefinition();
            if (isCorrect)
                CurrentPlayer.Points++;
        }

        void CheckAnswer()
        {

        }
    }
}
