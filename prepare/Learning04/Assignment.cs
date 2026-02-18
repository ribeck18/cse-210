using System.Text.Json.Serialization;

class Assignment
{
    //attributes
    private string _studentName;
    private string _topic;

    //Constructor
    public Assignment(string name, string topic)
    {
        _studentName = name;
        _topic = topic;
    }

    //methods 
    public string GetSummary()
    {
        return $"Student: {_studentName}, Topic: {_topic}";
    }

    public string GetName()
    {
        return $"{_studentName}";
    }

}