using System;
using System.Collections.Generic;

namespace Develop03
{
    /// <summary>
    /// Hold references and words and display when needed
    /// </summary>
    public class Scripture
	{
		private List<Verse> verseList;
        private List<string> allVerses = new List<string>();
		public int listLength;

        public Scripture()
		{

		}

		public string HoldReference() // This will hold the references but return a random scripture
		{
			Reference reference = new Reference();
			List<string> myReferences = reference.GetReference();

			foreach (string references in myReferences)
			{
				allVerses.Add(references); // This code adds the references to the allVerses
			}

			// Code under here will get a random number
			Random random = new Random();
			listLength = random.Next(0, allVerses.Count);
			string randomScripture = allVerses[listLength];
			Console.WriteLine($"1. {listLength}"); // Checking random number generated
			Console.WriteLine(randomScripture);
            return randomScripture;
		}

		public void HoldWords() // This will hold the verse words
		{
            
        }

		public void DisplayWords() // This will get it all
		{

		}

		public int GetRandomNumber()
		{
            Console.WriteLine($"2. {listLength}"); // Checking random number generated

            return 0;
		}
	}
}

