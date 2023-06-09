// File: Program.cs
using System;

namespace ScriptureMemorizer
{
    class Program
    {
        static void Main(string[] args)
        {
            Scripture scripture = new Scripture(new Reference("John", "3", "16"), "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");
            while (!scripture.IsAllWordsHidden())
            {
                scripture.DisplayScripture();
                Console.WriteLine("Press enter to hide a word or type 'quit' to exit.");
                string input = Console.ReadLine();
                if (input.ToLower() == "quit")
                {
                    break;
                }
                else
                {
                    scripture.HideRandomWord();
                }
            }
        }
    }
}
