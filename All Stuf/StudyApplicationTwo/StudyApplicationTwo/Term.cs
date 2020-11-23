using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace StudyApplicationTwo
{
    class Term
    {
        string Name;
        string Definition;
        List<string> Options;

        public Term(string name, string definition, string[] possibleAnswers)
        {
            Name = name;
            Definition = definition;

            Options = new List<string>();
            Options.Add(definition);
            Options.AddRange(possibleAnswers);
        }

        public bool AskForDefinition()
        {
            WriteLine($"What does \"{Name}\" mean?");

        }
    }
}
