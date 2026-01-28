using System.Configuration.Assemblies;

public class Prompts
{
//Attributes

    //list of prompt questions
    public List<string> _questions;

//methods 

    //randomly selects a prompt from the list and returns it
    public string GetPrompt()
    {
        //Find question amount
        int questionAmount = 0;
        foreach (string q in _questions)
        {
            questionAmount ++;
        }

        //Find random number that is within question amount.
       Random range = new Random();
       int questionNum = range.Next(0, questionAmount);

        //Return correct question
       string question = _questions[questionNum];
       return question;

    }

    //add questions to the prompt list
    public void AddPrompt(string question)
    {
        _questions.Add(question);
    }

}