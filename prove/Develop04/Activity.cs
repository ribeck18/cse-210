using System.Diagnostics;

public class Activity
{
    //attributes
    private string _name;
    private string _description;
    private int _duration;
    private string _closingMessage;

    //Constructor 
    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }
    
    //Methods
    public string StartMessage()
    {
        return $"Let's begin the {_name} activity!\n\n{_description}";
    }
    public string GetCloseMsg()
    {
        return $"You have completed {_duration} seconds of the {_name} activity!";
    }
    public void SetDuration()
    {
        //Get duration
        Console.WriteLine("How long, in seconds, would you like for your session?");
        Console.Write(">");
        string durationStr = Console.ReadLine();
        int duration = int.Parse(durationStr);
        //Set duration
        _duration = duration;
    }
    public int GetDuration()
    {
        return _duration;
    }
    public static void CountDown(int time)
    {
        int timeLeft = time;

        // Console.Write($"{timeLeft}");

        while (timeLeft != 0)
        {
            //erase current count - checks for a double digit.
            if (timeLeft >= 9)
            {
                Console.Write("\b \b");
                Console.Write("\b \b");
            }
            else
            {
                Console.Write("\b \b");
            }

            Console.Write($"{timeLeft}");
            Thread.Sleep(1000);
            timeLeft = timeLeft - 1;
        } 
        Console.Write("\b \b");
        Console.WriteLine();

    }
    
}
