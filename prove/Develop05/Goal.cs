using System.ComponentModel;

abstract class  Goal
{
    //Attributes
    protected string _name;
    protected string _description;
    protected int _pointValue;
    protected int _totalPoints = 0;
    protected bool _isComplete = false;

    //Constructor
    public Goal(string name, string description, int value)
    {
        _name = name;
        _description = description;
        _pointValue = value;
    }

    //Methods
    public abstract void CompletionEvent();
    public virtual string GetGoalString()
    {
        if (_isComplete == false)
        {
            return $"""[ ] {_name} ({_description})""";
        }
        else
        {
            return $"""[X] {_name} ({_description})""";
        }
        
    }

    public bool SetComplete()
    {
        _isComplete = true;

        return _isComplete;
    }

    public int GetScore()
    {
        return _totalPoints;
    }
}