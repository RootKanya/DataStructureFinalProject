namespace HangmanCLI
{
    class MySet
    {
        private bool[] guessed = new bool[26];

        public bool Has(char c)
        {
            int index = c - 'a';
            return guessed[index];
        }

        public void Add(char c)
        {
            int index = c - 'a';
            guessed[index] = true;
        }
    }
}
