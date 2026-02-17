# Week 6: Text Menu App - Study Notes

**Name:**
Aatiqa Imran

## Loop Types

**How is a `do-while` loop different from a `while` loop?**
[Explain when each loop is best used]

Answer: A while loop checks first and may not run, but a do-while loop runs once before checking, so it always runs at least one time.

**Where did you use a `do-while` loop in this assignment and why?**
[Describe how you validated the menu choice and numeric inputs]

Answer: I used a do-while loop to keep asking the user for menu choice and numbers until they enter a valid input.

**Where did you use a `while` loop and why?**
[Describe the menu loop and why it repeats]

Answer: I used a while loop in the menu section to keep showing the menu again and again, because it repeats until the user chooses option 6 to exit the program.

**Where did you use a `for` loop and why?**
[If you didn’t use a for loop, explain why it wasn’t needed]

Answer: I did not use a for loop in this assignment because I did not need to repeat something a fixed number of times, and the while loop and do-while loop were enough for the menu and input validation.

## Input Validation

**Why did you create a helper method for input validation?**
[Explain how it avoids repeating code for multiple prompts]

Answer: I created a helper method for input validation to avoid repeating the same code in multiple places, because it lets me reuse the same method to check user input for the menu and other numeric prompts.

**How did you validate the menu choice (1–6)?**
[Explain your range check logic and do-while loop]

Answer: I validated the menu choice using the ReadIntInRange method, which uses a do-while loop to keep asking the user until they enter a number, and a range check to make sure the number is between 1 and 6.

**How did you handle invalid input (non-numbers)?**
[Explain how int.TryParse and double.TryParse work]

Answer: I handled invalid input using int.TryParse and double.TryParse, which try to convert the user’s input to a number and return false if it’s not valid, so the program keeps asking until the user enters a correct number.

## String Operations

**Which string methods did you use across the different menu options?**
[List key methods like Trim, ToUpper, ToLower, Replace, Split, Join, Contains, PadLeft, PadRight, and formatting techniques]

Answer: I used several string methods such as Trim, ToUpper, ToLower, Replace, Split, Join, Contains, PadLeft and PadRight, string.Format and interpolation.

**Which four string methods did you demonstrate in Option 6 (String Analysis)?**
[Explain Equals with StringComparison, Substring, EndsWith, and IndexOf]

Answer: Equals wiht StringComparison to check if the word is "goodbye" as not caring about uppercase and lowercase. Substring to get the first three letters of word. EndsWith use to see if the word end with an "!". IndexOf to find that where is the space in the word.

**What's the difference between string concatenation and interpolation?**
[Explain when you used each approach and which you prefer]

Answer: String concatenation uses + to join text while interpolation uses $"" to insert the variables directly and I used both but prefer interpolation because it's easier to read.

## What I Learned

**Key takeaways from this week:**
[3-5 main things you learned]

1. How to make menus and repeat actions using while and do-while loops.
2. How to check if the user type the number correctly using int.TryParse and double.TryParse.
3. How to use string methods like Trim, ToUpper, ToLower, Replace, Split and Join.
4. How to show text nicely using string.Format and $"" interpolation.
5. How to write helper methods to reuse code and avoid repeating it.

**Which loop felt most natural to use and why?**

Answer: The while loop felt most natural because it easily repeated the menu until the user chose to exit.

## Time Spent

**Total time:** [6 hours]

**Breakdown:**

- Planning the loops: [1 hours]
- Input validation: [2 hours]
- String formatting: [1 hours]
- Testing and debugging: [1 hours]
- Writing documentation: [1 hours]

**Most time-consuming part:** [Which aspect took the longest and why?]

Answer: The most time-consuming part was input validation because I had to make sure the program keeps asking the user until they enter a correct number or value.

## Reflection

**What would you do differently next time?**

Answer: Next time, I would try to make the text boxes and menus line up better so the output looks neater.

**How did using three different loop types improve your understanding of repetition?**

Answer: Using three different loop types helped me understand when to repeat something before checking, when to check first, and how to repeat a fixed or unknown number of times.
