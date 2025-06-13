using System;

namespace HangmanCLI
{
    class MyArray
    {
        private char[] array;

        public MyArray(string word)
        {
            array = word.ToCharArray();
        }

        public int Length()
        {
            return array.Length;
        }

        public char Get(int index)
        {
            return array[index];
        }

        public void Set(int index, char value)
        {
            array[index] = value;
        }

        public void Display()
        {
            foreach (char c in array)
            {
                Console.Write(c + " ");
            }
            Console.WriteLine();
        }

        public bool Contains(char c)
        {
            foreach (char ch in array)
            {
                if (ch == c) return true;
            }
            return false;
        }
    }
}
