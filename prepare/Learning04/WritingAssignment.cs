class WritingAssignment: Assignment
{
   //attributes
   private string _title;

    //Constructors
    public WritingAssignment(string name, string topic, string title) : base(name, topic)
    {
        _title = title;
    }

    //methods
    public string getWritingInformation()
    {
        string name = base.GetName();
        return $"{_title} by {name}";
    }
}