using System;
using System.Runtime.InteropServices.JavaScript;

namespace Develop04
{
    /// <summary>
    /// This activity will help you reflect on the good things in your life by having you list as many
	/// things as you can in a certain area.
    /// </summary>
    public class Listing_Activity : Activity
    {
        private Random random = new Random();
        public Listing_Activity()
        {

        }

        private string[] listingPrompts = new string[]
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?",
        };

        private string SelectRandomPrompt()
        {
            int randomIndex = random.Next(listingPrompts.Length);

            return listingPrompts[randomIndex];
        }

        private void DisplayRandomPrompt()
        {
            Console.WriteLine(SelectRandomPrompt());
        }

        private string PromptKeepListingItems()
        {
            return "";
        }

        private string DisplayItemsEntered()
        {
            return "";
        }

        public void RunListingActivity()
        {
            StandardMessageListing();
            int duration = DurationPrompt();
            string randomReflection = SelectRandomPrompt();
            DisplayRandomPrompt();
            DisplayPausedMessages(randomReflection);
        }
    }
}