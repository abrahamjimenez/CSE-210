using Develop03;

class Program
{
    

    static void Main(string[] args)
    {
        Verse verse = new Verse();
        //verse.HoldWords();

        Scripture scripture = new Scripture();
        //scripture.HoldReference();
        //scripture.HoldWords();
        //scripture.DisplayWords();

        Words words = new Words(scripture.HoldWords()); // This will get the words and replace with '___'
        words.GetInvisible(); // The words. needs to be the words in DisplayWords(); todo: runs code

        //Check check = new Check("for");

    }
}