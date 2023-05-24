using System;
using System.Collections.Generic;
namespace Develop03
{
    /// <summary>
    /// Hold references and words and display when needed 
    /// </summary>

    public class Scripture
    {
        private Dictionary<string, string> myScriptures; // This is declared out here so it can be called in other methods


        public Scripture()
        {
            myScriptures = new Dictionary<string, string>(); // I am creating a Dictionary that will hold a key and value of strings
        }

        public void HoldScriptures() // This will hold they references and verses in a dictionary
        {

            myScriptures["Moses 1:39"] = "For behold, this is my work and my glory to bring to pass the immortality and eternal life of man.";
            myScriptures["Moses 7:18"] = "And the Lord called his people Zion, because they were of one heart and one mind, and dwelt in righteousness; and there was no poor among them.";
            myScriptures["Abraham 2:9-11"] = "And I will make of thee a great nation, and I will bless thee above measure, and make thy name great among all nations, and thou shalt be a blessing unto thy seed after thee, that in their hands they shall bear this ministry and Priesthood unto all nations; And I will bless them through thy name; for as many as receive this Gospel shall be called after thy name, and shall be accounted thy seed, and shall rise up and bless thee, as their father; And I will bless them that bless thee, and curse them that curse thee; and in thee (that is, in thy Priesthood) and in thy seed (that is, thy Priesthood), for I give unto thee a promise that this right shall continue in thee, and in thy seed after thee (that is to say, the literal seed, or the seed of the body) shall all the families of the earth be blessed, even with the blessings of the Gospel, which are the blessings of salvation, even of life eternal.";
            myScriptures["Abraham 3:22-23"] = "Now the Lord had shown unto me, Abraham, the intelligences that were organized before the world was; and among all these there were many of the noble and great ones; And God saw these souls that they were good, and he stood in the midst of them, and he said: These I will make my rulers; for he stood among those that were spirits, and he saw that they were good; and he said unto me: Abraham, thou art one of them; thou wast chosen before thou wast born.";

            Console.WriteLine(myScriptures);

        }

        public KeyValuePair<string, string> GetRandomScripture()
        {
            Random random = new Random();
            int randomIndex = random.Next(0, myScriptures.Count);

            int currentIndex = 0;
            foreach (KeyValuePair<string, string> scripturePair in myScriptures)
            {
                if (currentIndex == randomIndex)
                {
                    return scripturePair; // The key is the scripture reference
                }
                currentIndex++; // Current Index will increase until it matches the randomIndex. Scripture gotten will be different
            }
            return new KeyValuePair<string, string>("", "Error with KeyValuePair"); // I need this to return this or else it will get an error
        }
    }
}

