using System;
using System.Linq;

namespace Develop03
{
    public class Check
    {
        string word;
        int wordLength;
        string underscoreLength;
        string newWord;

        public Check(string word) // This will check if the word is equal to itself in underscores (if it's been hidden)
        {
            wordLength = word.Length;
            underscoreLength = String.Concat(Enumerable.Repeat("_", wordLength));
            newWord = underscoreLength;

            Console.WriteLine(word);
            Console.WriteLine(newWord);
        }

        public bool CheckUnderscore()
        {
            if (newWord == word)
            {
                Console.WriteLine("###");
                Console.WriteLine("Words are not underscored");
                Console.WriteLine(word);
                Console.WriteLine(newWord);
                Console.WriteLine("###");
                return true;
            }
            else
            {
                Console.WriteLine("###");
                Console.WriteLine("Words are underscored");
                Console.WriteLine(word);
                Console.WriteLine(newWord);
                Console.WriteLine("###");
                return false;
            }
        }
    }
}

