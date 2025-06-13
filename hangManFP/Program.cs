using System;

namespace HangmanCLI
{
    class Program
    {
        static void Main(string[] args)
        {
            WordBank wordBank = new WordBank();
            string selectedWord = wordBank.GetRandomWord();

            HangmanGame game = new HangmanGame(selectedWord);
            game.Play();
        }
    }
}
