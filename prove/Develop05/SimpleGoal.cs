using System.Drawing;
using System.Runtime.CompilerServices;

class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int pointValue):base(name, description, pointValue)
    {
        
    }
    
    //Use this constructor when rehydrating from string.
    public SimpleGoal(string name, string description, int pointValue, int total, bool isComplete):base(name, description, pointValue, total, isComplete){}

    public override void CompletionEvent()
    {
        _isComplete = true;
        _totalPoints += _pointValue;
    }
    public override Dictionary<string, string> GetDict()
    {
        Dictionary<string, string> dict = new Dictionary<string, string>
        {
            {"class", "SimpleGoal"},
            {"name", _name},
            {"description", _description},
            {"pointValue", _pointValue.ToString()},
            {"totalPoints", _totalPoints.ToString()},
            {"isComplete", _isComplete.ToString()},
        };
        return dict;
    }
    public override string GetSaveString()
    {
        string saveString = $"SimpleGoal|{_name}|{_description}|{_pointValue}|{_totalPoints}|{_isComplete}";
        return saveString;
    }
}