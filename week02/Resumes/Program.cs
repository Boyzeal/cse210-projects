using System;

class Program
{
    static void Main(string[] args)
    {
        // Create first job
        Job job1 = new Job();

        // Set member variables using dot notation
        job1._jobTitle = "Software Engineer";
        job1._companyName = "Google";
        job1._salary = 120000;
        job1._location = "California";
        job1._jobDescription = "Develop software applications.";

        // Display the company name
        Console.WriteLine(job1._companyName);

        // Create second job
        Job job2 = new Job();

        // Set member variables
        job2._jobTitle = "Data Analyst";
        job2._companyName = "Microsoft";
        job2._salary = 95000;
        job2._location = "Washington";
        job2._jobDescription = "Analyze company data.";

        // Display the company name
        Console.WriteLine(job2._companyName);
    }
}