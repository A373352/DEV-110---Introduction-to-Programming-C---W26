# Week 6: Text Menu App - Study Notes

**Name:**

## Loop Types

**How is a `do-while` loop different from a `while` loop?**
[Explain when each loop is best used]

Answer: A do-while loop always executes its body at least once before checking the condition, whereas a while loop checks the condition first and may not run at all if the condition is false. do-while loops are best used when you need the code to run at least once, such as prompting the user for input. while loops are best used when you might not want the loop to execute at all unless the condition is true.


**Where did you use a `do-while` loop in this assignment and why?**
[Describe how you validated the menu choice and numeric inputs]

Answer: I used a do-while loop inside the ReadIntInRange and ReadDouble helper methods. This ensures that the user is prompted at least once for input and that the loop continues until they enter a valid number within the required range.


**Where did you use a `while` loop and why?**
[Describe the menu loop and why it repeats]

Answer: I used a while loop for the main menu (while (choice != 6)). This loop repeats the menu until the user chooses option 6 to exit. It’s ideal here because the menu should keep showing as long as the exit condition isn’t met.


**Where did you use a `for` loop and why?**
[If you didn’t use a for loop, explain why it wasn’t needed]

Answer: I did not use a for loop in this assignment because there weren’t any tasks that required a fixed number of repetitions. All loops needed were based on conditions or user input.


## Input Validation

**Why did you create a helper method for input validation?**
[Explain how it avoids repeating code for multiple prompts]

Answer: I created helper methods (ReadIntInRange and ReadDouble) to avoid repeating the same validation logic for multiple prompts. This makes the code cleaner, easier to maintain, and prevents mistakes from copying input validation repeatedly.


**How did you validate the menu choice (1–6)?**
[Explain your range check logic and do-while loop]

Answer: I used the ReadIntInRange method with a do-while loop. The method uses int.TryParse to check if the input is numeric and then verifies that it is between 1 and 6. The prompt repeats until a valid number is entered.


**How did you handle invalid input (non-numbers)?**
[Explain how int.TryParse and double.TryParse work]

Answer: I used int.TryParse and double.TryParse to attempt converting the input. If the conversion fails, the program tells the user the input is invalid and prompts again, avoiding runtime errors.

## String Operations

**Which string methods did you use across the different menu options?**
[List key methods like Trim, ToUpper, ToLower, Replace, Split, Join, Contains, PadLeft, PadRight, and formatting techniques]

Answer: rim() – remove extra spaces from user input

ToUpper() and ToLower() – change case for display

Replace() – replace spaces with dashes in phrases

Split() – break phrases into words

Join() – create a comma-separated list of words

Contains() – check for specific letters

PadLeft() and PadRight() – align text in banners

string.Format() and interpolation ($"{var}") – format output


**Which four string methods did you demonstrate in Option 6 (String Analysis)?**
[Explain Equals with StringComparison, Substring, EndsWith, and IndexOf]

Answer: Equals() with StringComparison.OrdinalIgnoreCase – compare strings ignoring case

Substring() – extract the first three characters

EndsWith() – check if the string ends with "!"

IndexOf() – find the position of the first space character


**What's the difference between string concatenation and interpolation?**
[Explain when you used each approach and which you prefer]

Answer: Concatenation uses + to join strings, while interpolation uses $"{var}" to embed variables directly in a string. I used concatenation for simple name joins and interpolation for formatted output that includes multiple variables. I prefer interpolation because it’s easier to read and maintain.

## What I Learned

**Key takeaways from this week:**
[3-5 main things you learned]

1. How to validate user input safely using TryParse and loops.
2. The difference between while and do-while loops and when to use each.
3. How to manipulate strings with methods like Trim, ToUpper, Split, and Join.
4. How to format console output neatly with alignment and borders.
5. How helper methods simplify repetitive tasks and improve code readability.


**Which loop felt most natural to use and why?**

Answer: The while loop for the menu felt most natural because the menu needs to keep repeating until the user chooses to exit, and the condition directly controls repetition.


## Time Spent

**Total time:** [X hours]

**Breakdown:**

- Planning the loops: [X hours]
- Input validation: [X hours]
- String formatting: [X hours]
- Testing and debugging: [X hours]
- Writing documentation: [X hours]

**Most time-consuming part:** [Which aspect took the longest and why?]

Answer:

## Reflection

**What would you do differently next time?**

Answer:

**How did using three different loop types improve your understanding of repetition?**

Answer:
