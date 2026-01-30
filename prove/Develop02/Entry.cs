using System.ComponentModel;

class Entry
{
//Attributes 

    //Users journal Entry 
    string _response;
    //Date of entry 
    string _date;
    //Prompt used
    string _prompt;

//Methods
    
    // retrives the prompt, date, and response and gives them to the associated attributes.
    public void NewEntry(string prompt)
    {
        //Get Date 
        DateTime currentDate = DateTime.Now;
        string dateString = currentDate.ToShortDateString();
        _date = dateString;

        //Get Response
        Console.WriteLine(prompt);
        Console.Write(">");
        string userResponse = Console.ReadLine();
        _response = userResponse;

        //Save prompt
        _prompt = prompt;
    }
    //Display the users entry 
    public string DisplayEntry()
    {
        // Console.WriteLine($"Date: {_date} - Prompt: {_prompt}\n{_response}");
        string entryDisplay = $"Date: {_date} - Prompt: {_prompt}\n{_response}";
        return entryDisplay;
    }
    
    //convert to file format
    public string EntryToFile()
    {
        return $"{_date}|{_prompt}|{_response}";
    }

    //Convert to entry format
    public static Entry FileToEntry(string date, string prompt, string response)
    {
        Entry entryFromFile = new Entry();
        entryFromFile._date = date;
        entryFromFile._prompt = prompt;
        entryFromFile._response = response;

        return entryFromFile;
    }
}
    
    