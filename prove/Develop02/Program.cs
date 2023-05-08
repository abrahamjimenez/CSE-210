using System;
using System.Collections.Generic;

namespace Develop02
{
    class Program
    {
        static void Main(string[] args)
        {
            Entry myEntry = new Entry();
            myEntry.Hold("What is your name?", "Abraham Jimenez", "8 May 2023");

            Entry yourEntry = new Entry();
            yourEntry.Hold("What is your name?", "Abraham Joe", "8 May 2023");

            Journal journal = new Journal();
            journal.AddEntry(myEntry);
            journal.AddEntry(yourEntry);

            List<Entry> entries = journal.GetAllEntries();
            foreach (Entry entry in entries)
            {
                string message = entry.ConvertToString();
                Console.WriteLine(message);
            }
        }
    }
}