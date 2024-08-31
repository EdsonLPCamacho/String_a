using System;

class Program
{
    static void Main()
    {
        // Prompt the user to enter a string
        Console.Write("Enter a string to check for the letter 'a': ");
        
        // Read the user input
        string input = Console.ReadLine();

        // Check for the letter 'a' and count its occurrences
        int count = CountLetterA(input);

        // Display the results
        if (count > 0)
        {
            Console.WriteLine($"The letter 'a' (both uppercase and lowercase) appears {count} times in the string.");
        }
        else
        {
            Console.WriteLine("The letter 'a' does not appear in the string.");
        }
    }

    static int CountLetterA(string str)
    {
        // Initialize the count variable
        int count = 0;

        // Loop through each character in the string
        foreach (char c in str)
        {
            // Check if the character is 'a' or 'A'
            if (c == 'a' || c == 'A')
            {
                count++;
            }
        }

        // Return the total count
        return count;
    }
}
