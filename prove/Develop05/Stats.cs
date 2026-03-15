class Stats
{
    int _totalScore;
    int _totalGoals;

    // 1 = done 2 = not done 3 = null
    int _isChecklistDone = 3;

    public void UpdateScore(int currentScore)
    {
        _totalScore = currentScore;
    }

    /// <summary>
    /// When a goal is completed it adds to _totalGoals
    /// </summary>
    /// <param name="goalsDone"></param>
    public void UpdateGoals(int goalsDone)
    {
        _totalGoals += goalsDone;
    }

    public void updateChecklist(bool isDone)
    {
        if (isDone == true)
        {
            _isChecklistDone = 1;
        }
        else
        {
            _isChecklistDone = 2;
        }
    }

    //Getters

    public int GetTotalScore()
    {
        return _totalScore;
    }

    public int GetTotalGoals()
    {
        return _totalGoals;
    }

    public int GetChecklist()
    {
        return _isChecklistDone;
    }
}
