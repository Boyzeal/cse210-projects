using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>
        {
            new Running(new DateTime(2026, 06, 16), 30, 3.0),
            new Cycling(new DateTime(2026, 06,16), 45, 12.0),
            new Swimming(new DateTime(2026, 06, 16), 40, 40)
        };

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}