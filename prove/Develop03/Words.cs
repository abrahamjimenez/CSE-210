using System;
using System.Collections.Generic;
using System.Linq;

namespace Develop03
{
    /// <summary>
    /// Holds a word 
    /// </summary>
    public class Words
    {
        private string[] words; // Private field to store the words

        public Words(string verse)
        {
            words = verse.Split(" "); // Split the verse into individual words and store them in the words array
        }

        public int GetLength()
        {
            return words.Length; // Return the length of the words array
        }

        public bool IsWordMasked(int index)
        {
            return words[index] == "___"; // Check if the word at the given index is already masked (replaced with '___')
        }

        public void MaskWord(int index)
        {
            words[index] = "___"; // Mask the word at the given index by replacing it with '___'
        }

        public override string ToString()
        {
            return string.Join(" ", words); // Return the entire verse by joining the words with spaces
        }
    }
}
