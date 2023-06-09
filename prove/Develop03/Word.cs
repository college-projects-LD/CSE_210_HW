// File: Word.cs
namespace ScriptureMemorizer
{
    class Word
    {
        private string text;
        private bool isHidden;

        public Word(string text)
        {
            this.text = text;
            this.isHidden = false;
        }

        public void HideWord()
        {
            this.isHidden = true;
        }

        public bool IsHidden()
        {
            return this.isHidden;
        }

        public void DisplayWord()
        {
            if (this.isHidden)
            {
                Console.Write("____");
            }
            else
            {
                Console.Write(this.text);
            }
        }
    }
}
