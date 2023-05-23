using System;

namespace Develop03
///<summary>
/// This will modify the words in the verse
///</summary>
{
    public class Words
    {
        private string[] words; //Private string list to store words

        public Words(string verse)
        {
            words = verse.Split(' '); // This will split words individually and store them in a list array
        }

        public int GetLength()
        {
            return words.Length; // Return length of array
        }

        public bool isWordMasked(int index)
        {
            return words[index] == "___";// Going to check if the word is replaced with '___'
        }

        public void MaskWord(int index)
        {
            words[index] = "___"; //This will replace word with "___"
        }

        public override string ToString() // This wouldnt work without override or new, but I was suggested overrride so yeah ¯_(ツ)_/¯
        {
            return string.Join(" ", words); // This will join the '___' with the current verse
        }

    }
}

