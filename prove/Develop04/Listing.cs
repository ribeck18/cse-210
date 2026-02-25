public class Listing: Activity
{
    //Attributes
    List<string> _prompts;
    string _instruction;
    List<string> _answerList = new List<string>();
    int thinkTime = 15;

    //constructor
    public Listing(string name, string description, List<string> prompts) : base(name, description)
    {
        _prompts = prompts;
    }

    //methods 
    public void SetAnswers()
    {
        Console.Write(">");
        string answer = Console.ReadLine();
        _answerList.Add(answer);
    }

    public string GetPrompt()
    {
        //get a random number
        int promptCount = _prompts.Count();
        Random rng = new Random();

        //Get a random prompt
        string prompt = _prompts[rng.Next(0, promptCount)];

        return prompt;
    }
    public void ThinkTime()
    {
        CountDown(thinkTime);
    }

    public string GetListCount()
    {
        string answerCount = _answerList.Count().ToString();
        return answerCount;
        
    }
}