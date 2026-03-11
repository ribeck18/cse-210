using System.Drawing;

class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int pointValue):base(name, description, pointValue)
    {
        
    }

    public override void CompletionEvent()
    {
        _isComplete = true;
        _totalPoints += _pointValue;
    }
}