using System.Runtime.CompilerServices;

class BadgeSash
{
    private List<Badge> _badgesEarned = [];

    public void AddBadge(Badge badge)
    {
        _badgesEarned.Add(badge);
    }

    public void DisplaySash()
    {
        foreach (Badge badge in _badgesEarned)
        {
            badge.displayBadge();
        }
    }

    public void SaveBadges(string filePath)
    {
        using (StreamWriter output = new StreamWriter(filePath))
        {
            foreach (Badge badge in _badgesEarned)
            {
                output.WriteLine(badge.GetSaveString());
            }
        }
    }

    public void LoadBadges(string filename)
    {
        string[] badgesStringList = File.ReadAllLines(filename);
        List<Badge> badgeList = [];

        foreach (string badgeString in badgesStringList)
        {
            string[] parts = badgeString.Split("|");
            string type = parts[0];
            string name = parts[1];
            string description = parts[2];
            string displayable = parts[3];
            string bonus = parts[4];
            string isEarned = parts[5];
            string requirements = parts[6];

            if (type == "ChecklistBadge")
            {
                ChecklistBadge c = new ChecklistBadge(
                    name,
                    description,
                    displayable,
                    int.Parse(bonus),
                    bool.Parse(isEarned),
                    bool.Parse(requirements)
                );
                badgeList.Add(c);
            }
            else if (type == "PointBadge")
            {
                PointBadge p = new PointBadge(
                    name,
                    description,
                    displayable,
                    int.Parse(bonus),
                    bool.Parse(isEarned),
                    int.Parse(requirements)
                );
                badgeList.Add(p);
            }
            else
            {
                GoalsBadge g = new GoalsBadge(
                    name,
                    description,
                    displayable,
                    int.Parse(bonus),
                    bool.Parse(isEarned),
                    int.Parse(requirements)
                );
                badgeList.Add(g);
            }
        }
        _badgesEarned = badgeList;
    }

    public List<Badge> GetBadgesEarned()
    {
        return _badgesEarned;
    }
}
