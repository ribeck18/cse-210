using System;
using System.Data;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {

        //Library of scriptures
        string fileName = "library.txt";
        string[] lines = System.IO.File.ReadAllLines(fileName);
        List<Dictionary<string, string>> library = new List<Dictionary<string, string>>();

        //Split the text file into dictionaries, then append them to a list.
        foreach (string line in lines)
        {
            Dictionary<string, string> newScripture = new Dictionary<string, string>();

            string[] pairs = line.Split("|");

            //Break down into a dictionary
            foreach (string pair in pairs)
            {
                string[] keyAndValue = pair.Split("=");

                if (keyAndValue.Length == 2)
                {
                    newScripture[keyAndValue[0]] = keyAndValue[1];
                }
            }
            library.Add(newScripture);
        }
 
        //Select a random scripture: 
        Random rndm = new Random();
        int libraryCount = library.Count;
        int randomNumber = rndm.Next(1, libraryCount);
        Dictionary<string, string> selectedScripture = library[randomNumber];

        //initalize variables - verse, book, chapter, firstVerse, lastVerse(only if there is 5 items in the dict)
        //uses the appropriate constructor based on if a last verse exists or not.
        string verse = selectedScripture["verse"];
        string book = selectedScripture["book"];
        string chapterString = selectedScripture["chapter"];
        int chapter = int.Parse(chapterString);
        string firstVerseString = selectedScripture["firstVerse"];
        int firstVerse = int.Parse(firstVerseString);
        int lastVerse = new int();
        Reference reference;
        if (selectedScripture.ContainsKey("lastVerse"))
        {
            string lastVerseString = selectedScripture["lastVerse"];
            lastVerse = int.Parse(lastVerseString);
            reference = new Reference(book, chapter, firstVerse, lastVerse);
        }
        else
        {
            reference = new Reference(book, chapter, firstVerse);
        }


        //declare a scripture object using a reference and a verse
        Scripture scripture = new Scripture(reference, verse);
        bool isQuit = false;

        
        //Console program 
        Console.WriteLine("How many words would you like to hide each time?");
        Console.Write(">");
        string input = Console.ReadLine();
        int hideCount = int.Parse(input);

        while (isQuit != true)
        {
            Console.WriteLine(scripture.DisplayVerse());
            Console.WriteLine("Enter to hide words, 'quit' to quit");
            string userChoice = Console.ReadLine();
            if (userChoice == "quit")
            {
                Console.WriteLine("Goodbye.");
                isQuit = true;
                break;
            }
            Console.Clear();
            scripture.HideWords(hideCount);

            if (scripture.IsAllHidden() == true)
            {
                break;
            }
        }
    }
}