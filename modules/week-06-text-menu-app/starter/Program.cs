/*******************************************************************************
- Course: DEV 110
- Instructor: Zak Brinlee
- Term: Winter 2026
-
- Programmer: Aatiqa Imran
- Assignment: Week 6: Text Menu App
-
- What does this program do?:
- Runs a text-heavy menu app that demonstrates string formatting and output patterns.
- */

using System;

namespace TextMenuApp;

public class Program
{
    public static void Main(string[] args)
    {
        // TODO 1: Build a title banner using strings
        // Create variables for:
        // - title: "Text Menu Studio"
        string title = "Text Menu Studio";
        // - subtitle: "Strings + Console Output Patterns"
        string subtitle = "Strings + Console Output Patterns";
        // - divider: 48 equals signs (hint: use new string() constructor)
        string divider = new string('=', 48);
        // Display: divider, title in uppercase, subtitle, divider
        Console.WriteLine(divider);
        Console.WriteLine(title.ToUpper());
        Console.WriteLine(subtitle);
        Console.WriteLine(divider);

        int choice = 0;

        // TODO 2: Create a menu loop that repeats until user chooses 6 (Exit)
        // Hint: Use a while loop
        while (choice != 6)
        {
            // TODO 3: Print the menu box
            Console.WriteLine();
            // Required menu option texts (tests check for these):
            Console.WriteLine("+-------------------------------+");
            // - 1) Greeting Card
            Console.WriteLine("| 1) Greeting Card              |");
            // - 2) Name Tag Formatter
            Console.WriteLine("| 2) Name Tag Formatter         |");
            // - 3) Phrase Analyzer
            Console.WriteLine("| 3) Phrase Analyzer            |");
            // - 4) Fancy Receipt Line
            Console.WriteLine("| 4) Fancy Receipt Line         |");
            // - 5) Menu Banner Builder
            Console.WriteLine("| 5) Menu Banner Builder        |");
            // - 6) Exit
            Console.WriteLine("| 6) Exit                       |");
            Console.WriteLine("+-------------------------------+");

            // TODO 4: Get menu choice from user
            // Use ReadIntInRange helper with prompt: "Choose an option (1-6): "
            // Range: 1 to 6
            choice = ReadIntInRange("Choose an option (1-6):", 1, 6);

            // TODO 5: Use a switch statement to handle each menu option
            switch (choice)
            {
                case 1:

                    // ===== OPTION 1: Greeting Card =====
                    // Prompts: "Enter your name: " and "Enter a short message: "
                    Console.Write("Enter your name: ");
                    string userName = Console.ReadLine();
                    Console.Write("Enter a short message: ");
                    string shortMessage = Console.ReadLine();
                    // Required string operations:
                    // - Use Trim() to clean up the name
                    string trimUserName = userName.Trim();
                    // - Use ToUpper() for an uppercase version
                    string upperUserName = trimUserName.ToUpper();
                    // - Use concatenation OR interpolation for greeting text
                    Console.WriteLine($"Greeting Text: {shortMessage}");
                    // - Use string.Format() for at least one output line
                    Console.WriteLine(string.Format("Greeting: {0}", shortMessage));
                    // - Display a boxed card with the name, uppercase name, and message
                    Console.WriteLine(" -----------------------------------");
                    Console.WriteLine($"Hello, {trimUserName}");
                    Console.WriteLine($"Nice to meet you. {trimUserName}");
                    // Include the word "Message:" in your output
                    Console.WriteLine($"Message: {shortMessage}");
                    Console.WriteLine(" -----------------------------------");
                    break;
                case 2:

                    // ===== OPTION 2: Name Tag Formatter =====
                    // Prompts: "Enter first name: " and "Enter last name: "
                    Console.Write("Enter first name: ");
                    string firstName = Console.ReadLine();
                    Console.Write("Enter last name: ");
                    string lastName = Console.ReadLine();
                    // Required string operations:
                    // - Use Trim() on both inputs
                    string trimFirstName = firstName.Trim();
                    string trimLastName = lastName.Trim();
                    // - Use concatenation to build full name
                    Console.WriteLine("Full Name: " + trimFirstName + " " + trimLastName);
                    // - Use string indexing to get first characters for initials
                    Console.WriteLine(string.Format("Character: {0}{1}", trimFirstName[0], trimLastName[0]));
                    // - Use ToUpper() for initials
                    char trimFirstNameUpper = char.ToUpper(trimFirstName[0]);
                    char trimLastNameUpper = char.ToUpper(trimLastName[0]);
                    // - Use ToLower() for lowercase version
                    char trimFirstNameLower = char.ToLower(trimFirstName[0]);
                    char trimLastNameLower = char.ToLower(trimLastName[0]);
                    // Display three things:
                    // - Name tag with the full name (include a bracket [)
                    Console.WriteLine("----------------------------------------------------");
                    Console.WriteLine(string.Format("Full Name: [{0} {1}]", trimFirstName, trimLastName));
                    // - Initials (use word "Initials:" in label)
                    Console.WriteLine($"Initials: {trimFirstNameUpper}{trimLastNameUpper}");
                    // - Lowercase version (use word "Lowercase:" in label)
                    Console.WriteLine($"Lowercase: {trimFirstNameLower}{trimLastNameLower}");
                    Console.WriteLine("----------------------------------------------------");
                    break;
                case 3:

                    // ===== OPTION 3: Phrase Analyzer =====
                    // Prompt: "Enter a phrase: "
                    Console.WriteLine("Enter a phrase: ");
                    string phrase = Console.ReadLine();
                    // Required string operations:
                    // - Use Trim() on input
                    string trimPhrase = phrase.Trim();
                    // - Use Length property
                    int length = trimPhrase.Length;
                    // - Use Contains() to check for letter 'a' (convert to lowercase first)
                    bool containsLetter = trimPhrase.ToLower().Contains('a');
                    // - Use Replace() to change spaces to dashes
                    string newPhrase = trimPhrase.Replace(' ', '-');
                    // - Use Split() to break into words
                    string[] words = trimPhrase.Split(' ');
                    // - Use string.Join() to create comma-separated list
                    string commaSeparated = string.Join(",", words);
                    // Display: length, contains check, dashed version, and words list
                    Console.WriteLine("----------------------------------------");
                    Console.WriteLine($"Length: {length}                       ");
                    Console.WriteLine($"Contains Check: {containsLetter}       ");
                    Console.WriteLine($"Dashed Version: {newPhrase}            ");
                    Console.WriteLine($"Words List: {string.Join(",", words)}  ");
                    Console.WriteLine("--------------------------------------- ");
                    break;
                case 4:

                    // ===== OPTION 4: Fancy Receipt Line =====
                    // Prompts: "Enter item name: ", "Enter price: ", "Enter quantity (1-9): "
                    // Use ReadDouble for price and ReadIntInRange for quantity
                    Console.Write("Enter item name: ");
                    string itemName = Console.ReadLine().Trim();
                    double price = ReadDouble("Enter Price: ");
                    int quantity = ReadIntInRange("Enter quantity (1-9):", 1, 9);
                    // Required:
                    // - Calculate total (price * quantity)
                    double total = price * quantity;
                    // - Create a receipt table with header row (ITEM, QTY, TOTAL)
                    Console.WriteLine("+-------------------------------------+");
                    Console.WriteLine("| ITEM          QTY            TOTAL  |");
                    Console.WriteLine("+-------------------------------------+");
                    // - Use string.Format() with composite formatting for the data row
                    // - Use alignment specifiers (left/right alignment)
                    // - Use currency format specifier (:C2) for the total
                    Console.WriteLine(string.Format(" {0,-20} {1,-5} {2,10:C2} ", itemName, quantity, total));
                    break;
                case 5:

                    // ===== OPTION 5: Menu Banner Builder =====
                    // Prompts: "Enter a title: ", "Enter a subtitle: ", "Enter width (30-60): "
                    Console.Write("Enter a title: ");
                    string bannerTitle = Console.ReadLine();
                    Console.Write("Enter a subtitle: ");
                    string bannerSubTitle = Console.ReadLine();
                    // Use ReadIntInRange for width (min=30, max=60)
                    int width = ReadIntInRange("Enter width: ", 30, 60);
                    // Required string operations:
                    // - Create border line with equals signs (use new string constructor)
                    string border = new string('=', width);
                    // - Use PadLeft() to center text (formula: (width + text.Length) / 2)
                    // - Use ToUpper() on title
                    string centeredTitle = bannerTitle.ToUpper().PadLeft((width + title.Length) / 2);
                    bannerSubTitle = bannerSubTitle.PadLeft((width + bannerSubTitle.Length) / 2);
                    // - Display banner with borders and centered text
                    Console.WriteLine(border);
                    Console.WriteLine(centeredTitle);
                    Console.WriteLine(bannerSubTitle);
                    Console.WriteLine(border);
                    // - Show three alignment examples (centered, left, right)
                    Console.WriteLine("----------------------------------------------------");
                    Console.WriteLine(bannerSubTitle);
                    Console.WriteLine(bannerSubTitle.PadRight(width));
                    Console.WriteLine(bannerSubTitle.PadLeft(width));
                    Console.WriteLine("----------------------------------------------------");
                    break;
                case 6:

                    // ===== OPTION 6: Exit with String Analysis =====
                    // Prompt: "Enter a closing word: "
                    Console.Write("Enter a closing word:");
                    string closingWord = Console.ReadLine();
                    // Required string operations (demonstrate these 4 methods):
                    // - Use Equals() with StringComparison.OrdinalIgnoreCase to compare with "goodbye"
                    bool isGoodbye = closingWord.Equals("goodbye", StringComparison.OrdinalIgnoreCase);
                    // - Use Substring() to extract first 3 characters (check length first!)
                    string firstThree = closingWord.Length >= 3 ? closingWord.Substring(0, 3) : closingWord;
                    // - Use EndsWith() to check if ends with "!"
                    bool endsWithExclamation = closingWord.EndsWith("!");
                    // - Use IndexOf() to find position of space character
                    int spacePosition = closingWord.IndexOf(' ');
                    // Display the results of all four operations
                    Console.WriteLine("--------------------------------------");
                    Console.WriteLine($"Goodbye: {isGoodbye}                 ");
                    Console.WriteLine($"Characters: {firstThree}             ");
                    Console.WriteLine($"Exclamation: {endsWithExclamation}   ");
                    Console.WriteLine($"Space Position: {spacePosition}      ");
                    Console.WriteLine("--------------------------------------");
                    // Then print: "Goodbye!"
                    Console.WriteLine("Goodbye!");
                    break;
            }

            // TODO 6: Add a blank line between menu actions (but not after Exit)
            if (choice != 6)
            {
                Console.WriteLine();
            }
        }
    }

    private static int ReadIntInRange(string prompt, int min, int max)
    {
        int value;
        bool isValid;

        // TODO 7: Implement input validation
        // Use a do-while loop with int.TryParse()
        // Keep prompting until input is valid AND within range
        // Return the valid number
        do
        {
            Console.Write(prompt);
            string input = Console.ReadLine();
            isValid = int.TryParse(input, out value);
        }
        while (!isValid || value < min || value > max);

        return value;
    }

    private static double ReadDouble(string prompt)
    {
        // TODO 8: Implement input validation
        // Use a do-while loop with double.TryParse()
        // Keep prompting until input is a valid number
        // Return the valid number
        double value;
        bool isValid;

        do
        {
            Console.Write(prompt);
            string input = Console.ReadLine();
            isValid = double.TryParse(input, out value);
        }
        while (!isValid);

        return value;
    }
}
