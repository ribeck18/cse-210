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
    public Goal(string name, string description, int value, int total, bool isComplete)
    {
        _name = name;
        _description = description;
        _pointValue = value;
        _totalPoints = total;
        _isComplete = isComplete;
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

    public abstract Dictionary<string, string> GetDict(); //I was going to use this to save but I remembered we can't use JSON in this class.

    public abstract string GetSaveString();

    public int GetPointValue()
    {
        return _pointValue;
    }

    public int GetTotalPoints()
    {
        return _totalPoints;
    }

    public bool GetCompletion()
    {
        return _isComplete;
    }
}