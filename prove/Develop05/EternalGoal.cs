class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int pointValue):base(name, description, pointValue){}

    public override void CompletionEvent()
    {
        _totalPoints += _pointValue;
    }

}