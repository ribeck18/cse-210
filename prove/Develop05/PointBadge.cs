class PointBadge : Badge
{
    private int _requiredPoints;

    public PointBadge(
        string name,
        string description,
        string displayable,
        int bonus,
        bool isEarned,
        int requirements
    )
        : base(name, description, displayable, bonus, isEarned)
    {
        _requiredPoints = requirements;
    }

    public override bool CheckRequirments(Stats stats)
    {
        if (stats.GetTotalScore() > _requiredPoints)
        {
            return true;
        }
        return false;
    }

    public override string GetRequirmentsString()
    {
        return _requiredPoints.ToString();
    }
}
