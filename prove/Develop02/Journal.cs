using System.IO;
using System.IO.Enumeration;
using System.Runtime.CompilerServices;

class Journal
{
//Attributes

    public List <Entry> _entries = new List<Entry>();


//Methods
    //Display all user entries 
    public void DisplayJournal()
    {
        foreach (Entry entry in _entries)
        {
            Console.WriteLine(entry.DisplayEntry());
        }
    }
    //Save the list to a .txt file 
    public void Save()
    {
        //Create and name a file
        Console.WriteLine("Please enter a name for your journal.");
        Console.Write(">");
        string filename = $"{Console.ReadLine()}.txt";
        using (StreamWriter outputfile = new StreamWriter(filename, true))

        {
            foreach (Entry entry in _entries)
            {
                string entryForFile = entry.EntryToFile();
                outputfile.WriteLine(entryForFile);
            }
        }
    }
    //Retrives previous entries from .txt file replace current list with loaded data
    public void Load()
    {
        //get the file 
        Console.WriteLine("Please enter a journal to load.");
        Console.Write(">");
        string filename = $"{Console.ReadLine()}.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);

        //Create an empty list of entrys
        List<Entry> loadedEntries = new List<Entry>();
        
        foreach (string line in lines)
        {
            //Break up the txt into parts
            string[] parts = line.Split("|");
            string date = parts[0];
            string prompt = parts[1];
            string response = parts[2];

            //make an entry and append to list
            Entry entry = Entry.FileToEntry(date, prompt, response);
            loadedEntries.Add(entry);

            //Replace old list w/ new list
        }
        _entries = loadedEntries;
    }
    //append an entry to the _entries list
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }
}