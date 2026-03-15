using System.Runtime.CompilerServices;

class GoalsBadge : Badge
{
    private int _requiredGoals;

    public GoalsBadge(
        string name,
        string description,
        string displayable,
        int bonus,
        bool isEarned,
        int requirements
    )
        : base(name, description, displayable, bonus, isEarned)
    {
        _requiredGoals = requirements;
    }

    public override bool CheckRequirments(Stats stats)
    {
        if (stats.GetTotalGoals() > _requiredGoals)
        {
            return true;
        }
        return false;
    }

    public override string GetRequirmentsString()
    {
        return _requiredGoals.ToString();
    }
}
