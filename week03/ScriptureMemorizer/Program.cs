using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        /*
        CREATIVITY:
        1. Library of Scriptures: The program loads a list and picks one at random.
        2. The program prevents re-hiding already hidden words.
        3. The program handles punctuation so underscores match only letters.
        */

        List<Scripture> library = new List<Scripture>
        {
            new Scripture(
                new Reference("John", 3, 16),
                "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."
            ),

            new Scripture(
                new Reference("Proverbs", 3, 5, 6),
                "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths."
            ),

            new Scripture(
                new Reference("Matthew", 5, 9),
                "Blessed are the peacemakers: for they shall be called the children of God."
            )
        };

        Random random = new Random();
        Scripture scripture = library[random.Next(library.Count)];

        string userInput = "";

        while (userInput.ToLower() != "quit" && !scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("Press Enter to continue or type 'quit' to finish:");

            userInput = Console.ReadLine();

            if (userInput.ToLower() != "quit")
            {
                scripture.HideRandomWords(3);
            }
        }

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("\nAll words have been hidden. Good job memorizing!");
    }
}