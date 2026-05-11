using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();

        job1._jobTitle = "Software Engineer";
        job1._companyName = "Google";

        Console.WriteLine(job1._companyName);

        Job job2 = new Job();

        job2._jobTitle = "Data Analyst";
        job2._companyName = "Microsoft";

        Console.WriteLine(job2._companyName);
    }
}