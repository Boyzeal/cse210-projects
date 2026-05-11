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

        // Display jobs
        job1.Display();
        job2.Display();
    }
}