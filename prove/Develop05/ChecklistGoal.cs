class ChecklistGoal : Goal
{

    private int _completionCount;
    private int _requiredCompletions;
    private int _bonusValue;
    public ChecklistGoal(string name, string description, int pointValue, int requiredCompletes, int bonusValue):base(name, description, pointValue)
    {
        _bonusValue = bonusValue;
        _requiredCompletions = requiredCompletes;
    }

    public override void CompletionEvent()
    {
        _completionCount += 1;
        _totalPoints += _pointValue;
    }
    public bool CheckComplete()
    {
        if (_completionCount == _requiredCompletions)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public void AwardBonus()
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

}