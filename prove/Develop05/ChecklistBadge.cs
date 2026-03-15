class ChecklistBadge : Badge
{
    private bool _isChecklistDone;

    public ChecklistBadge(
        string name,
        string description,
        string displayable,
        int bonus,
        bool isEarned,
        bool requirements
    )
        : base(name, description, displayable, bonus, isEarned)
    {
        _isChecklistDone = requirements;
    }

    public override bool CheckRequirments(Stats stats)
    {
        if (stats.GetChecklist() == 1)
        {
            return true;
        }
        return false;
    }

    public override string GetRequirmentsString()
    {
        return _isChecklistDone.ToString();
    }
}
