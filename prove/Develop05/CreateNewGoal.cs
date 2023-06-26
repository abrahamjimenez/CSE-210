using System;
namespace Develop05
{
    public class CreateNewGoal
    {
        private int input;
        private string[] goals =
            {
            "1. Simple Goal",
            "2. Eternal Goal",
            "3. Checklist Goal"
            };

        public CreateNewGoal()
        {

        }

        private void TypesOfGoals()
        {

        }

        public void SimpleGoal()
        {
            Console.WriteLine("What is the name of your goal? ");
            Console.Read();
        }

        public void DisplayTypesOfGoals()
        {
            foreach (string goal in goals)
            {
                Console.WriteLine(goal);
            }
        }

        public void RunChoice(int input)
        {
            if (input == '1')
            {
                Console.WriteLine("SIMPLE");
                SimpleGoal();
            }
            else if (input == '2')
            {
                //EternalGoal();
            }
            else if (input == '3')
            {
                //CheckListGoal();
            }
            Console.WriteLine(input); // TODO: Fix this input not running inside the if statement above
        }

        public int SelectChoice()
        {
            Console.Write("Select a choice from the menu: ");
            int input = int.Parse(Console.ReadLine());
            RunChoice(input);
            return input;
        }

        public void RunCreateNewGoal()
        {
            DisplayTypesOfGoals();
            SelectChoice();
        }
    }
}

