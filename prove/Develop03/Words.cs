using System;
using System.Linq;

namespace Develop03
{
    /// <summary>
    /// Holds a word
    /// </summary>
    public class Words
    {
        string[] word;
        bool visible;
        Check check;
        bool checkForUnderscores;

        int replacedCount;

        public Words(string words)
        {
            word = words.Split(" ");
        }

        public void SetInvisible()
        {
            Random random = new Random();

            // Put this code in a while loop to keep the code running
            while (replacedCount < word.Length) // While the verse length and '___' are not the same number...
            {
                int rnd = random.Next(0, word.Length); // This gets a random int in word

                // Get length of word to replace with number of '___'
                int invisibleNum = word[rnd].Length;
                string replaceWithUnderscores = String.Concat(Enumerable.Repeat("_", invisibleNum)); // This writes '_' as much as the words length

                // Ask for input
                Console.WriteLine("Press enter to continue");
                Console.ReadLine();

                //check = new Check(word[rnd]);
                //checkForUnderscores = check.CheckUnderscore();
                word[rnd] = replaceWithUnderscores;

                // use if statement to check
                //Console.WriteLine(!word[rnd].Contains("_")); // Returns true
                //Console.WriteLine(word[rnd]);
                //Console.WriteLine(word[rnd] = replaceWithUnderscores);
                //Console.WriteLine(word[rnd].Contains("_")); // Returns true
                //Console.WriteLine(word[rnd]);
                //// Todo: Uncomment if statement later
                //if (!word[rnd].Contains("_") == false)
                //{

                //    Console.WriteLine("runs1");
                //} else
                //{
                //    word[rnd] = replaceWithUnderscores;
                //    replacedCount++;
                //}

                // This code is not done yet. Now I have to get the whole sentence back together, but instead of the word, it needs to have ___
                //Console.WriteLine(); // Todo: add later
                //word[rnd] = replaceWithUnderscores; // Replaces word with underscores
                string joinWords = string.Join(" ", word); // This joins the words back together but with the new "_"

                // Works Perfect! Now I need to add a Console.ReadLine() That takes input. Once the input is taken, this code will keep running
                // I need to add a check however, that checks if the word has been replaced with dashes ('_') or not

                //Console.WriteLine($"1. {rnd}"); // rnd is the index of the word that is changed
                Console.WriteLine($"1. {joinWords}");
                //return joinWords;
            }
        }

        public void GetInvisible()
        {
            SetInvisible();
        }
    }
}

