using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
    "Who are people that you appreciate?",
    "What are personal strengths of yours?",
    "Who are people that you have helped this week?",
    "When have you felt happy this month?",
    "Who are some of your personal heroes?",
    "What are some goals you have achieved this year?",
    "What are things you are grateful for today?"
    };

    private Random _random = new Random();

    public ListingActivity() : base(
        "Listing",
        "This activity will help you reflect on the good things in your life by having you list as many things as you can.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine();
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine();
        Console.WriteLine($"--- {GetRandomPrompt()} ---");

        Console.Write("You may begin in: ");
        ShowCountDown(5);

        List<string> items = GetListFromUser();

        Console.WriteLine();
        Console.WriteLine($"You listed {items.Count} items!");

        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        return _prompts[_random.Next(_prompts.Count)];
    }

    public List<string> GetListFromUser()
    {
        List<string> items = new List<string>();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        Console.WriteLine();

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");

            string input = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(input))
            {
                items.Add(input);
            }
        }

        return items;
    }
}