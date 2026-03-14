using System.Runtime.CompilerServices;

class ChecklistGoal : Goal
{
    private int _completionCount;
    private int _requiredCompletions;
    private int _bonusValue;

    public ChecklistGoal(
        string name,
        string description,
        int pointValue,
        int requiredCompletes,
        int bonusValue
    )
        : base(name, description, pointValue)
    {
        _bonusValue = bonusValue;
        _requiredCompletions = requiredCompletes;
    }

    //Use this constructor when rehydrating from string.
    public ChecklistGoal(
        string name,
        string description,
        int pointValue,
        int total,
        bool isComplete,
        int requiredCompletes,
        int bonusValue,
        int completionCount
    )
        : base(name, description, pointValue, total, isComplete)
    {
        _bonusValue = bonusValue;
        _requiredCompletions = requiredCompletes;
        _completionCount = completionCount;
    }

    public override void CompletionEvent()
    {
        _completionCount += 1;
        _totalPoints += _pointValue;

        bool complete = CheckComplete();
        if (complete == true)
        {
            AwardBonus();
        }
    }

    private bool CheckComplete()
    {
        if (_completionCount == _requiredCompletions)
        {
            _isComplete = true;
            return true;
        }
        else
        {
            _isComplete = false;
            return false;
        }
    }

    public int GetBonus()
    {
        return _bonusValue;
    }

    private void AwardBonus()
    {
        _totalPoints += _bonusValue;
    }

    public override string GetGoalString()
    {
        if (_isComplete == false)
        {
            return $"[ ] {_name} ({_description}) -- Currently Completed {_completionCount}/{_requiredCompletions}";
        }
        else
        {
            return $"[X] {_name} ({_description}) -- Currently Completed {_completionCount}/{_requiredCompletions}";
        }
    }

    public override Dictionary<string, string> GetDict()
    {
        Dictionary<string, string> dict = new Dictionary<string, string>
        {
            { "class", "CheckListGoal" },
            { "name", _name },
            { "description", _description },
            { "pointValue", _pointValue.ToString() },
            { "totalPoints", _totalPoints.ToString() },
            { "isComplete", _isComplete.ToString() },
            { "completionCount", _completionCount.ToString() },
            { "requiredCompletions", _requiredCompletions.ToString() },
            { "bonusValue", _bonusValue.ToString() },
        };
        return dict;
    }

    public override string GetSaveString()
    {
        string saveString =
            $"ChecklistGoal|{_name}|{_description}|{_pointValue}|{_totalPoints}|{_isComplete}|{_completionCount}|{_requiredCompletions}|{_bonusValue}";
        return saveString;
    }
}
