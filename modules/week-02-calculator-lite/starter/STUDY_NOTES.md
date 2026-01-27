# Week 2: Calculator Lite - Study Notes

**Name:**

## Understanding Data Types

**What are the four data types you used in this assignment?**
[List each data type (string, bool, int, double) and explain what kind of data each one stores]

Answer: string: stores text
        bool: stores values with two states true or false
        int: stores integers
        double: stores floating point numbers

**Why did we use `double` instead of `int` for the calculations?**
[Explain the difference between int and double, and why double is better for this calculator]

Answer: We use double instead of int because double can store numbers with decimals, while int can only store numbers.This make the calculation more easy to do as when the user want an decimal results.

**How do you convert a string to a boolean?**
[Explain how you converted the user's "yes/no" input into a true/false value]

Answer: string agree = Console.ReadLine();
        bool useDecimals = (agree.ToLower() == "yes");
I convert the user yes/no input into a boolean by checking if the string is equal to yes or no.

## Challenges and Solutions

**Biggest challenge with this assignment:**
[What was the hardest part? Understanding data types, getting user input, performing calculations, formatting output, or handling division by zero?]

Answer: The hardest part was understanding perfoming calcuations, formatting output.

**How you solved it:**
[Explain what you did to overcome the challenge - reviewed documentation, asked for help, tested different approaches, etc.]

Answer: I try to practice those problems in different way like different problems on W3schools, watched youtube video, reviewed documentaiton and tested different approaches.

**Most confusing concept:**
[What was hardest to understand? Parsing input, modulus operator, percentage formula, conditional formatting, or something else?]

Answer: Parsing input is really hard for me to understand like where to use as in the assingment it was godo to have in order like what need to do.

## Understanding Arithmetic Operations

**What is the difference between the modulus operator (%) and division (/)?**
[Explain what each operator does and give an example]

Answer: The division / give the result of dividing two numbers and operator % gives what is left after dividing.

**How do you calculate the average of two numbers?**
[Write the formula in your own words]

Answer: I calculated average = (num1 + num2) / 2 as adding two number and divide the sum by 2.

**What is the formula for percentage difference?**
[Explain the formula you used: ((num1 - num2) / num1) * 100]

Answer: I used the ((num1 - num2) / num1) * 100 as subtract the second number from the first number and divide the result by the first number and then multiply by 100 to get as a percentage.

## Input and Output

**How do you read user input in C#?**
[Explain what Console.ReadLine() does and what type of data it returns]

Answer: It read what the user type and use a string to retun it.

**How do you convert string input to a number?**
[Explain the Parse methods you used, like double.Parse()]

Answer: I convert a string to a number using method like int.Parse() or double.Parse() which change the text input to an integer or decimal value.

**What is string interpolation and how did you use it?**
[Explain the $ symbol and curly braces {} in Console.WriteLine()]

Answer: String interpolation let us insert variables into text using $ and {} like showing Hello, {userName} in Console.WriteLine();

## Conditional Logic

**How do you format numbers with 2 decimal places vs whole numbers?**
[Explain the :F2 and :F0 format specifiers]

Answer: :F2 format a number to show two decimal place while :F0 shows it is a whole number with no decimals.

**Why is it important to check for division by zero?**
[Explain what happens if you try to divide by zero and how you handled it]

Answer: Dividing by zero cause an error and crash the program and we check if the second number is zero before dividing and show an error message instead.

**How did you use the boolean variable to control formatting?**
[Explain how you used if/else to format output differently based on user preference]

Answer: I used the boolean useDecimals with if/else to decide whether numbers and results should show decimals or whole numbers.

## What I Learned

**Key takeaways from this week:**
[What are the 3-5 most important things you learned?]

1.How to read and convert user input
2.Use int and double
3.do arithmetic calculations
4.control program flow with booleans
5.handle errors and formating

**Which data type concept was most useful?**
[Explain which data type (string, bool, int, or double) you found most interesting and why]

Answer: I found double most useful because it let us do calculations with whole numbers and decimals.

**How does conditional formatting improve user experience?**
[Why is it helpful to let users choose decimal precision?]

Answer: Conditional formatting let's users choose decimal precision, making result clear and easy to understand.

## Testing and Debugging

**What test cases did you use to verify your program works?**
[List the different inputs you tested - positive numbers, negative numbers, decimals, zero, etc.]

Answer: I tested my program with positive numbers, negative numbers, zero and decimal to make sure the calculation work correctly.

**What bugs or errors did you encounter and fix?**
[Describe any errors you got and how you fixed them]

Answer: I encounter an error such as duplicating variables declaration and dividing by zero. I fixed them like removing and add an if statement to check for zero before dividing.

## Time Spent

**Total time:** [7.5 hours]

**Breakdown:**

-   Understanding data types: [1 hours]
-   Reading and parsing user input: [2 hours]
-   Implementing arithmetic operations: [.5 hours]
-   Adding conditional formatting: [1 hours]
-   Handling division by zero: [1 hours]
-   Testing and debugging: [1 hours]
-   Writing documentation: [1 hours]
// I want to be honest some of these took me a long more time than mention it, because I had to step away, come back, understand the problem, debug, and figure out what was really needed.
**Most time-consuming part:** [Which aspect took the longest and why?]

Answer: Reading and parsing user input took me longest because I had to make sure the input is correct converted.

## Reflection

**What would you do differently next time?**
[What would you change in your approach or code?]

Answer: Next time I would test each part step by step to avoid error and debugging faster.

**How does this assignment prepare you for more complex programs?**
[Why are these skills important for future programming tasks?]

Answer: This assignment teach me how to handle user input, use different data types, and managing error, which are important skills for more complex programs.
