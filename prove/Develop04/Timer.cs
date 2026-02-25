class Timer
{
    //Methods
    int _duration;

    //Methods
    public DateTime StartTimer(int duration)
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(duration);

        return futureTime;
    }
    //Note: Animation takes about 4 seconds.
    public void PlayAnimation()
    {
        int count = 0;

        while (count != 1)
        {
            Console.Write(">");
            Thread.Sleep(500);
            Console.Write(">");
            Thread.Sleep(500);
            Console.Write(">");
            Thread.Sleep(500);
            Console.Write(">");

            Thread.Sleep(500);

            Console.Write("\b \b");
            Console.Write("\b \b");
            Console.Write("\b \b");
            Console.Write("\b \b");

            count ++;
        }    
    }
}