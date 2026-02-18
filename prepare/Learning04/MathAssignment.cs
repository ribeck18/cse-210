class MathAssignment: Assignment
{
    //attributes
    private string _textbookSextion;
    private string _problems;

    //Constructor
    public MathAssignment(string name, string topic, string textbookSection, string problems) : base(name, topic)
    {
        _textbookSextion = textbookSection;
        _problems = problems;
    }
    
    public string GetHomeworkList()
    {
        return $"Section: {_textbookSextion}, Problems: {_problems}";
    }
}