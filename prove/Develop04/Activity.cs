using System;
namespace Develop04
{
    public class Activity
    {
        public Activity()
        {

        }

        public void StandardMessage()
        {
            Console.Clear();
            Console.WriteLine($"Welcome to the {"Breathing"} Activity\n\nThis activity will " +
                $"help you relax by walking your through breathing in and out slowly.\n\n");
        }

        public int DurationPrompt()
        {
            Console.WriteLine("How long, in seconds, would you like in your session?");
            int seconds = int.Parse(Console.ReadLine());
            return seconds;
        }

        public void PauseAfterMessage()
        {

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

