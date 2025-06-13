using System;

namespace HangmanCLI
{
    class HangmanGame
    {
        private MyArray wordArray;
        private MyArray displayArray;
        private MySet guessedLetters;
        private int remainingTries;

        public HangmanGame(string word)
        {
            wordArray = new MyArray(word);
            displayArray = new MyArray(new string('_', word.Length));
            guessedLetters = new MySet();
            remainingTries = 6;
        }

        public void Play()
        {
            Console.WriteLine("=== HANGMAN CLI GAME ===");
            while (remainingTries > 0)
            {
                displayArray.Display();
                Console.WriteLine("Remaining tries: " + remainingTries);
                Console.Write("Guess a letter: ");
                string input = Console.ReadLine().ToLower();

                if (input.Length != 1 || !char.IsLetter(input[0]))
                {
                    Console.WriteLine("Please enter a single valid letter.");
                    continue;
                }

                char guess = input[0];

                if (guessedLetters.Has(guess))
                {
                    Console.WriteLine("You already guessed that letter!");
                    continue;
                }

                guessedLetters.Add(guess);

                bool correctGuess = false;
                for (int i = 0; i < wordArray.Length(); i++)
                {
                    if (wordArray.Get(i) == guess)
                    {
                        displayArray.Set(i, guess);
                        correctGuess = true;
                    }
                }

                if (!correctGuess)
                {
                    remainingTries--;
                }

                if (IsWin())
                {
                    displayArray.Display();
                    Console.WriteLine("Congratulations! You guessed the word!");
                    return;
                }
            }

            Console.WriteLine("Game Over! The word was: ");
            for (int i = 0; i < wordArray.Length(); i++)
                Console.Write(wordArray.Get(i));
            Console.WriteLine();
        }

        private bool IsWin()
        {
            for (int i = 0; i < wordArray.Length(); i++)
            {
                if (displayArray.Get(i) != wordArray.Get(i))
                    return false;
            }
            return true;
        }
    }
}
