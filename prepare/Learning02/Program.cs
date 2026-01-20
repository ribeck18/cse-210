using System;

class Program
{
    static void Main(string[] args)
    {
        Jobs firstJob = new Jobs();
        firstJob._company = "Microsoft";
        firstJob._jobTitle = "Software Engineer";
        firstJob._startYear = 2015;
        firstJob._endYear = 2022;
        

        Jobs secondJob = new Jobs();
        secondJob._company = "Apple";
        secondJob._jobTitle = "Manager";
        secondJob._startYear = 2022;
        secondJob._startYear = 2025;

        Resume firstResume = new Resume();
        firstResume._name = "Jimmy";
        firstResume._jobs.Add(firstJob);
        firstResume._jobs.Add(secondJob);

        
        firstResume.DisplayResume();

    }
}