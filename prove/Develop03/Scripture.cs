// File: Scripture.cs
// File: Scripture.cs
using System;
using System.Collections.Generic;

namespace ScriptureMemorizer
{
    public class Reference
    {
        public string Book { get; set; }
        public string Chapter { get; set; }
        public string Verse { get; set; }

        public Reference(string book, string chapter, string verse)
        {
            this.Book = book;
            this.Chapter = chapter;
            this.Verse = verse;
        }

        public override string ToString()
        {
            return $"{Book} {Chapter}:{Verse}";
        }
    }

    class Scripture
    {
        private string text;
        private Reference reference;
        private List<Word> words;
        private Random random;

        public Scripture(Reference reference, string text)
        {
            this.reference = reference;
            this.text = text;
            this.words = new List<Word>();
            this.random = new Random();
            // Split the text into words and create Word objects
            string[] textWords = text.Split(' ');
            foreach (string textWord in textWords)
            {
                this.words.Add(new Word(textWord));
            }
        }

        public void DisplayScripture()
        {
            Console.Clear();
            Console.Write(reference.ToString() + ": ");
            foreach (Word word in words)
            {
                word.DisplayWord();
                Console.Write(" ");
            }
            Console.WriteLine();
        }

        public void HideRandomWord()
        {
            int index = random.Next(words.Count);
            words[index].HideWord();
        }

        public bool IsAllWordsHidden()
        {
            foreach (Word word in words)
            {
                if (!word.IsHidden())
                {
                    return false;
                }
            }
            return true;
        }
    }
}
