using System.ComponentModel.DataAnnotations;

public class Resume
{
    //Attributes 
    public string _name = "";
    public List<Jobs> _jobs = new List<Jobs>();

    //Methods
    public void DisplayResume()
    {
        Console.WriteLine(_name);
        Console.WriteLine("Jobs: ");
        foreach (Jobs job in _jobs)
        {
            job.Display();
        }
    }
}