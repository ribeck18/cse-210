class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int pointValue)
        : base(name, description, pointValue) { }

    //Use this constructor when rehydrating from string.
    public EternalGoal(string name, string description, int pointValue, int total, bool isComplete)
        : base(name, description, pointValue, total, isComplete) { }

    public override void CompletionEvent()
    {
        _totalPoints += _pointValue;
    }

    public override Dictionary<string, string> GetDict()
    {
        Dictionary<string, string> dict = new Dictionary<string, string>
        {
            { "class", "EternalGoal" },
            { "name", _name },
            { "description", _description },
            { "pointValue", _pointValue.ToString() },
            { "totalPoints", _totalPoints.ToString() },
            { "isComplete", _isComplete.ToString() },
        };
        return dict;
    }

    public override string GetSaveString()
    {
        string saveString =
            $"EternalGoal|{_name}|{_description}|{_pointValue}|{_totalPoints}|{_isComplete}";
        return saveString;
    }
}
