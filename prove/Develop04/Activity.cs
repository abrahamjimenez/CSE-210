using System;
namespace Develop04
{
    public class Activity
    {
        public Activity()
        {

        }

        public void StandardMessageBreathing()
        {
            Console.Clear();
            Console.WriteLine($"Welcome to the Breathing Activity\n\nThis activity will " +
                $"help you relax by walking your through breathing in and out slowly.\n\n");
        }

        public void StandardMessageReflection()
        {
            Console.Clear();
            Console.WriteLine($"Welcome to the Relfection Activity\n\nThis activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.\n\n");
        }

        public void StandardMessageListing()
        {
            Console.Clear();
            Console.WriteLine($"Welcome to the Listing Activity\n\nThis activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.\n\n");
        }

        public int DurationPrompt()
        {
            Console.WriteLine("How long, in seconds, would you like in your session?");
            int seconds = int.Parse(Console.ReadLine());
            return seconds;
        }

        public void DisplayPausedMessages(string randomPrompt)
        {
            for (int i = 0; i < 4; i++)
            {
                PauseAfterMessage(5);
                Console.WriteLine(randomPrompt);
                Console.WriteLine();
            }
        }

        public void PauseAfterMessage(int DurationPrompt)
        {
            int countDown = DurationPrompt;

            while (countDown != 0)
            {
                Thread.Sleep(1000);
                countDown--;
                Console.Write($"\rPonder...{countDown + 1}");
            }
            Console.WriteLine();
        }

        public string ShowCountdown()
        {
            return "";
        }

        public void ContinueUntilSecondsEnd()
        {

        }

        public void FinishMessage(int seconds, string activity)
        {
            Console.WriteLine($"Well done! You have completed {seconds} seconds of the {activity} Activity");
        }
    }
}

