using System.Runtime.InteropServices.Swift;
using Spectre.Console;

abstract class Badge
{
    protected string _name;
    protected string _description;
    protected string _displayable;
    protected int _bonus;
    protected bool _isEarned;
    protected Color[] _colorList = [Color.Blue, Color.Green, Color.Yellow, Color.Purple, Color.Red];

    public Badge(string name, string description, string displayable, int bonus, bool isEarned)
    {
        _name = name;
        _description = description;
        _displayable = displayable;
        _bonus = bonus;
        _isEarned = isEarned;
    }

    public void Animation()
    {
        string display = $"{_name} badge earned!";

        foreach (char c in display)
        {
            AnsiConsole.Markup($"[{GetRandomColor()}]{c}[/]");
            Thread.Sleep(50);
            // AnsiConsole.Write(new FigletText(c.ToString()).Centered().Color(GetRandomColor()));
        }

        AnsiConsole.WriteLine();
        AnsiConsole.Write(new FigletText(_displayable).Centered().Color(Color.Gold1));
        Console.WriteLine();
        // AnsiConsole.Write(new FigletText("HELLO").Centered().Color(Color.Green));
    }

    public void displayBadge()
    {
        //display the text
        string display = $"{_name}: {_description}";
        Console.WriteLine(display);
        //display the badge displayable.
        AnsiConsole.Write(new FigletText(_displayable).Centered().Color(Color.Gold1));
        Console.WriteLine();
    }

    public bool EarnBadge()
    {
        _isEarned = true;
        return _isEarned;
    }

    public bool GetEarnedStatus()
    {
        return _isEarned;
    }

    public Color GetRandomColor()
    {
        Random rnd = new Random();

        int colorPicker = rnd.Next(_colorList.Length);
        Color newColor = _colorList[colorPicker];

        return newColor;
    }

    public abstract bool CheckRequirments(Stats stats);
    public abstract string GetRequirmentsString();

    public string GetSaveString()
    {
        string saveString =
            $"{GetType()}|{_name}|{_description}|{_displayable}|{_bonus}|{_isEarned}|{GetRequirmentsString()}";
        return saveString;
    }
}
