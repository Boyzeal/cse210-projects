using System;

class Program
{
    static void Main(string[] args)
    {
        // First job
        Job job1 = new Job();

        job1._jobTitle = "Software Engineer";
        job1._companyName = "Microsoft";
        job1._startYear = 2026;
        job1._endYear = 2028;

        // Second job
        Job job2 = new Job();

        job2._jobTitle = "Manager";
        job2._companyName = "Apple";
        job2._startYear = 2027;
        job2._endYear = 2029;

        // Create resume
        Resume myResume = new Resume();

        myResume._name = "Atoyebi Simon";

        // Add jobs to resume
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        // Display resume
        Console.WriteLine($"Name: {myResume._name}");
        Console.WriteLine("Jobs:");

        foreach (Job job in myResume._jobs)
        {
            job.Display();
        }
    }
}