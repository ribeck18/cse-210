class Reflection : Activity
{
    //Attributes
    private List<string> _prompts;
    private static List<string> _questions;
    private int _questionTime = 9;

    //Constructor
    public Reflection(string name, string description, List<string> prompts, List<string> questions):base(name, description)
    {
        _prompts = prompts;
        _questions = questions;
    }

    //Methods
    public string GetPrompt()
    {
        //Get a random number.
        int promptCount = _prompts.Count();
        Random rng = new Random();

        //Get a random prompt
        string prompt = _prompts[rng.Next(0, promptCount)];

        return prompt;
    }
    public static string GetQuestion()
    {
        int quesionCount = _questions.Count();
        Random rng = new Random();

        string question = _questions[rng.Next(0, quesionCount)];

        return question;
    }

    public void AskQuestion()
    {
        Console.WriteLine(GetQuestion());
        CountDown(_questionTime);
    }

}