class Breathing : Activity
{
   //Attributes
    private string _inhaleMsg = "Breathe in...";
    private string _exhaleMsg = "Breathe out...";
    private int _inhaleTime = 5;
    private int _exhaleTime = 5;
   //Constructors
    public Breathing(string name, string description) : base(name, description)
    {
        
    }

   //Methods
    public void BreatheIn()
    {
        Console.WriteLine("Breathe in...");
        CountDown(_inhaleTime);
    }
    public void BreatheOut()
    {
        Console.WriteLine("Breathe out...");
        CountDown(_exhaleTime);
    }
}
