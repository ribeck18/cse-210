class AwardBadge
{
    //This is all the badges possible
    private List<Badge> _badgeList = new List<Badge>()
    {
        new GoalsBadge("Goals Badge", "Complete your first goal", "A Fresh Start", 500, false, 1),
        new GoalsBadge("Goals Badge", "Complete 10 goals.", "Goal Crusher", 500, false, 10),
        new PointBadge("Points badge", "Earn 10,000 points", "Point Leader", 500, false, 10000),
        new ChecklistBadge(
            "Checklist Badge",
            "Complete a checklist goal.",
            "Checklist Champion",
            500,
            false,
            false
        ),
    };

    private bool IsAlreadyEarned(Badge badge, BadgeSash sash)
    {
        foreach (Badge earnedBadge in sash.GetBadgesEarned())
        {
            bool sameType = earnedBadge.GetType().ToString() == badge.GetType().ToString();
            bool sameRequirment =
                earnedBadge.GetRequirmentsString() == badge.GetRequirmentsString();

            if (sameType && sameRequirment)
            {
                return true;
            }
        }

        return false;
    }

    private void Award(Badge b, BadgeSash sash)
    {
        if (IsAlreadyEarned(b, sash))
        {
            return;
        }
        else
        {
            b.Animation();
            b.EarnBadge();
            sash.AddBadge(b);
        }
    }

    public void CompleteBadges(Stats stats, BadgeSash sash)
    {
        foreach (Badge badge in _badgeList)
        {
            //Check if its already earned
            if (badge.GetEarnedStatus() == true)
            {
                continue;
            }
            //If not already earned, complet the badge.
            else
            {
                bool isEarned = badge.CheckRequirments(stats);
                if (isEarned == true)
                {
                    Award(badge, sash);
                }
            }
        }
    }
}
