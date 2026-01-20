public class Jobs
{
//Attributes
public string _company;
public string _jobTitle = "";
public int _startYear = 0;
public int _endYear = 0;

//Methods
public void Display()
    {
      Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");  
    }
}

