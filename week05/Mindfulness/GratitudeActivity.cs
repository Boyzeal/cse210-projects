using System;
using System.Collections.Generic;

public class GratitudeActivity : Activity
{
    private List<string> _prompts;
    private Random _random;

    public GratitudeActivity()
        : base(
              "Gratitude",
              "This activity helps you focus on things you are grateful for.")
    {
        _random = new Random();

        _prompts = new List<string>
        {
            "What made you smile today?",
            "Who are you thankful for today?",
            "What opportunity are you grateful for?",
            "What talent are you thankful for?"
        };
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine();
        Console.WriteLine(
            _prompts[_random.Next(_prompts.Count)]);

        Console.WriteLine();
        Console.WriteLine("Write your thoughts below:");

        DateTime endTime =
            DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
        }

        DisplayEndingMessage();
    }
}