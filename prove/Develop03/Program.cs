using Develop03;

class Program
{
    

    static void Main(string[] args)
    {
        //Words words = new Words("this makes no sense");
         //words.GetInvisible();

        Verse verse = new Verse();
        //verse.HoldWords();

        Scripture scripture = new Scripture();
        scripture.HoldReference();
        scripture.HoldWords();
        scripture.DisplayWords();

    }
}