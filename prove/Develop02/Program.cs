using System;
using System.Collections.Generic;

namespace Develop02
{
    class Program
    {
        static void Main(string[] args)
        {
            Prompts myPrompts = new Prompts();
            string prompt = myPrompts.Display();
            Console.WriteLine(prompt);
            string userInput = myPrompts.AskInput();
            Console.WriteLine("");
            // Get Date
            string currentDate = myPrompts.DisplayCurrentDate();

            Entry myEntry = new Entry();
            myEntry.Hold(prompt, userInput, currentDate);

            Journal journal = new Journal();
            journal.AddEntry(myEntry);

            List<Entry> entries = journal.GetAllEntries();
            foreach (Entry entry in entries)
            {
                string message = entry.ConvertToString();
            }

            // Save to file
            //foreach (Entry x in entries)
            //{
            //    Console.WriteLine(x);
            //}
        }
    }
}