using System;

namespace HangmanCLI
{
    class WordBank
    {
        private string[] words = { "brownies", "serigala", "tebakan", "struktur", "data", "gunpla", "kai"};
        private Random rand = new Random();

        public string GetRandomWord()
        {
            int index = rand.Next(words.Length);
            return words[index];
        }
    }
}
