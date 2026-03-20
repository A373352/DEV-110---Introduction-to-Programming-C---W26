/*******************************************************************************
- Course: DEV 110
- Instructor: Zak Brinlee
- Term: Winter 2026
-
- Programmer: Aatiqa Imran
- Assignment: Week 7: Class Roster Builder (Arrays)
-
- What does this program do?:
- Builds a class roster using parallel arrays and a simple menu.
- */

using System;
namespace ClassRoster;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("=== Class Roster ===");
        Console.WriteLine();

        // TODO 1: Create parallel arrays with a fixed capacity of 3
        // Create:
        // - string[] rosterNames
        // - int[] rosterCredits
        // Also create an int named count and set it to 0
        // Meaning: the first 0 slots are in use
        int rosterCapacity = 3;
        string[] rosterNames = new string[rosterCapacity];
        int[] rosterCredits = new int[rosterCapacity];
        int count = 0;

        int choice = 0;

        // TODO 2: Create a menu loop that repeats until the user chooses 4 (Exit)
        // Hint: while (choice != 4) { ... }
        {
            // Print the menu options (every loop)
            Console.WriteLine("1) Add multiple students");
            Console.WriteLine("2) Print class roster");
            Console.WriteLine("3) Print roster (sorted)");
            Console.WriteLine("4) Exit");

            // TODO 3: Get the menu choice using ReadIntInRange
            // Prompt: "Choose an option: "
            // Range: 1 to 4
            choice = ReadIntInRange("Choose an option: ", 1, 4);

            // TODO 4: Use a switch statement to handle choices 1-4
            switch (choice)
            {
                // ===== OPTION 1: Add multiple students =====
                case 1:
                    // TODO 5: If the roster is full (count == rosterCapacity), print:
                    // "Roster is full. Cannot add more students."
                    if (count == rosterCapacity)
                    {
                        Console.WriteLine("Roster is full. Cannot add more students.");
                    }
                    else
                    {
                        // Otherwise:
                        // - remainingSlots = rosterCapacity - count
                        int remainingSlots = rosterCapacity - count;
                        // - Ask how many to add:
                        //   $"How many students do you want to add? (1-{remainingSlots}): "
                        int toAdd = ReadIntInRange($"How many students do you want to add? (1-{remainingSlots}): ", 1, remainingSlots);
                        // - Create new arrays sized to the number to add:
                        //   string[] newNames
                        //   int[] newCredits
                        string[] newNames = new string[toAdd];
                        int[] newCredits = new int[toAdd];
                        // - Use a for loop to fill the new arrays:
                        for (int i = 0; i < toAdd; i++)
                        {

                        }
                        //   name prompt: $"Enter name for student {i + 1}: "
                        Console.Write($"Enter name for student {i + 1}");
                        newNames[i] = Console.ReadLine() ?? string.Empty;
                        //   credits prompt: $"Enter credits for {newNames[i]} (0-200): " (range 0-200)
                        newCredits[i] = ReadIntInRange($"Enter credits for {newNames[i]} (0-200):", 2, 200);
                        // - Copy the new arrays into the roster arrays (use a for loop)
                        for (int i = 0; i < toAdd; i++)
                        {
                            rosterNames[count] = newNames[i];
                            rosterCredits[count] = newCredits[i];
                            count++;
                        }
                        // - Print: "Students added."
                        Console.WriteLine("Students added. ");
                    }
                    break;
                case 2:

                    // ===== OPTION 2: Print class roster =====
                    // TODO 6: If count is 0, print: "Roster is empty."
                    if (count == 0)
                    {
                        Console.WriteLine("Roster is empty.");
                    }
                    else
                    {
                        // Otherwise:
                        // - Build a string[] of lines using BuildRosterLines (TODO 6.1)
                        string[] lines = BuildRosterLines(rosterNames, rosterCredits, count);
                        // - Print header: "Class Roster:"
                        Console.WriteLine("Class Roster: ");
                        // - Print each line using a foreach loop
                        foreach (string line in lines)
                        {
                            Console.WriteLine(line);
                        }
                    }
                    break;
                case 3:
                    // ===== OPTION 3: Print roster (sorted) =====
                    // TODO 7: If count is 0, print: "Roster is empty."
                    if (count == 0)
                    {
                        Console.WriteLine("Roster is empty.");
                    }
                    else
                    {
                        // Otherwise:
                        // - Print:
                        //   Sort by:
                        //   1) Name
                        //   2) Credits
                        Console.WriteLine("Sort by: ");
                        Console.WriteLine("1) Name");
                        Console.WriteLine("2) Credits");
                        // - Get sort choice using ReadIntInRange (range 1-2)
                        int sortChoice = ReadIntInRange("Choose sort of OperationCanceledException: ", 1, 2);
                        // - Copy only the USED part of the roster into new arrays (CopyUsedRoster - TODO 7.1)
                        // - Sort:
                        CopyUsedRoster(rosterNames, rosterCredits, count, out string[] sortedNames, out int[] sortedCredits);
                        //   Name: Array.Sort(sortedNames, sort")edCredits, StringComparer.OrdinalIgnoreCase)
                        //   Credits: Array.Sort(sortedCredits, sortedNames)
                        if (sortChoice == 1)
                        {
                            Array.Sort(sortedNames, sortedCredits, StringComparer.OrdinalIgnoreCase);
                        }
                        else
                        {
                            Array.Sort(sortedCredits, sortedNames);
                        }
                        // - Print header: "Class Roster (Sorted):"
                        Console.WriteLine("Class Roster (Sorted): ");
                        // - Print each line using a foreach loop
                        string[] sortedLines = BuildRosterLines(sortedNames, sortedCredits, count);
                    }
                    foreach (string line in sortedLines)
                    {
                        Console.WriteLine(line);
                    }
                    break;


                    // ===== OPTION 4: Exit =====
                    // TODO 8: When the user chooses 4, print: "Goodbye." and end the program
                    Console.WriteLine("Goodbye.");
                    // TODO 9: Add a blank line between menu actions (but not after Exit)
                    if (choice != 4)
                    {
                        Console.WriteLine();
                    }
            }

        }
    }

    private static int ReadIntInRange(string prompt, int min, int max)
    {
        int value;
        bool isValid;

        do
        {
            Console.Write(prompt);
            string input = Console.ReadLine() ?? string.Empty;
            isValid = int.TryParse(input, out value);
        }
        while (!isValid || value < min || value > max);

        return value;
    }


    private static string[] BuildRosterLines(string[] names, int[] credits, int count)
    {
        // TODO 6.1: Build and return an array of roster lines
        // - Create a string[] sized to count (hint: initialize with new)
        string[] lines = new string[count];
        // - Use a for loop to fill it (hint: use index accessor for the variable you just created)
        for (int i = 0; i < count; i++)
        {
            // - Include BOTH name and credits on each line
            lines[i] = $"{nameof[i]} = {credits[i]} credits";
        }
        return lines;
    }

    private static void CopyUsedRoster(
        string[] sourceNames,
        int[] sourceCredits,
        int count,
        out string[] names,
        out int[] credits)
    {
        // TODO 7.1: Copy only the USED roster values into new arrays
        // - Create names and credits arrays sized to count
        names = new string[count];
        credits = new int[count];
        // - Use a for loop to copy each used element
        for (int i = 0; i < count; i++)
        {
            names[i] = sourceNames[i];
            credits[i] = sourceCredits[i];
        }
    }
}
