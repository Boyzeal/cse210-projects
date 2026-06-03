using System;
using System.Collections.Generic;

public class ReflectionActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;
    private Random _random;

    public ReflectionActivity()
        : base(
              "Reflection",
              "This activity helps you reflect on times when you showed strength and resilience.")
    {
        _random = new Random();

        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something selfless."
        };

        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this experience special?",
            "What did you learn about yourself?",
            "How can you apply this lesson in the future?"
        };
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();

        Console.WriteLine(
            $"--- {_prompts[_random.Next(_prompts.Count)]} ---");

        Console.WriteLine();
        Console.WriteLine("Press ENTER when ready.");
        Console.ReadLine();

        DateTime endTime =
            DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            string question =
                _questions[_random.Next(_questions.Count)];

            Console.WriteLine();
            Console.WriteLine(question);

            ShowSpinner(5);
        }

        DisplayEndingMessage();
    }
}