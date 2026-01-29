using System.IO;
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
            entry.DisplayEntry();
        }
    }
    //Save the list to a .txt file 
    public void Save()
    {
        string filename = "JournalFile.txt";

        using (StreamWriter outputfile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                string entryString = entry.DisplayEntry(); 
                outputfile.WriteLine(entryString);
            }
        }
    }
    //Retrives previous entries from .txt file replace current list with loaded data
    public void Load()
    {
        
    }
    //append an entry to the _entries list
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }
}