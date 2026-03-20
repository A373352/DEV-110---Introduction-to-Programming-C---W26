# Week 5: Guess the Number - Study Notes

**Name:** Aatiqa

## Loop Types

**How is a `do-while` loop different from a `while` loop?**
[Explain when each loop is best used]

Answer: A while loop checks the condition first before running the code. If the condition is false, the loop will not run. A do-while loop runs the code first and then checks the condition. This means the code will run at least one time. A while loop is best when you want to check the condition first .A do-while loop is best when you wnat the code to run at least once.

**Where did you use a `do-while` loop in this assignment and why?**
[Describe the input validation use]

Answer: I used the do-while loop in the ReadIntInRange method. It asks the user to enter a number and checks if the number is valid. If the number is not valid or not in range, it asks again. I used a do-while loop because the program must ask the user for input at least once.

**Where did you use a `while` loop and why?**
[Describe the guessing loop]

Answer: I used a while loop for the guessing part of the game. The loop continues asking the user to guess the number until the guess is correct. The loop stops when the guess is equal to the secret number.

**Where did you use a `for` loop and why?**
[Describe the rounds loop]

Answer: I used a for loop to repeat the game rounds. The loop runs from round 1 to the number of rounds the user chooses. A for loop is good here because the number of rounds is known.

## Input Validation

**Why did you create a helper method for input validation?**
[Explain how it avoids repeating code for max value and rounds]

Answer: I created a helper method so I would not repeat the same validation code many times. Both the max value and number of rounds need validation, so the method makes the code cleaner and easier to reuse.

**How did you make sure the max value was between 10 and 100?**
[Explain your range check logic]

Answer: I checked if the number is greater than or equal to 10 and less than or equal to 100. If the number was outside this range, the program asked the user to enter another number.

**How did you make sure the number of rounds was between 1 and 3?**
[Explain your range check logic]

Answer: I used the same validation method and checked if the value was between 1 and 3. If the value was outside this range, the program asked the user to enter a valid number.

**How did you handle invalid input (non-numbers)?**
[Explain how int.TryParse works]

Answer: I used int.TryParse() to check if the input was a number. If it was not a number, the program printed an error message and asked the user to try again.

## Guessing Logic

**How did you compare the guess to the secret number?**
[Explain the if/else logic for too low, too high, and correct]

Answer: I used if and else statements.
If the guess was less than the secret number, the program printed "Too low."
If the guess was greater than the secret number, the program printed "Too high."
If the guess was equal to the secret number, the program printed "Correct!"

**How did you count the number of guesses?**
[Explain where you incremented the counter]

Answer: I used a variable called guessCount. Every time the user made a guess, I increased the value by 1.


## Random Numbers

**How did you generate the secret number?**
[Explain Random and Next(min, max)]

Answer: I used the Random class. I created a Random object and used the Next() method to generate a random number between 1 and the maximum value.

**Why does `Random.Next(1, max + 1)` include the max value?**
[Explain why +1 is needed]

Answer: The Next() method does not include the upper number. So I added +1 to make sure the maximum number could be included.

## Testing and Debugging

**What inputs did you test to confirm your loops worked correctly?**
[List several test cases]

Answer: I tested these inputs:

Max value = 10, rounds = 1

Max value = 50, rounds = 2

Max value = 100, rounds = 3

Entering letters instead of numbers

Entering numbers outside the allowed range


**What bugs or errors did you encounter and fix?**
[Describe any logic or loop errors]

Answer: At first, the program crashed when I entered text instead of a number. I fixed this by using int.TryParse(). I also fixed an issue where the program did not repeat when the input was invalid.

## What I Learned

**Key takeaways from this week:**
[3-5 main things you learned]

1. I learned how to use for, while, and do-while loops.
2. I learned how to validate user input.
3. I learned how to use Random numbers in C#.
4. I learned how to reuse code with helper methods.
5. I learned how to debug loops and conditions.

**Which loop felt most natural to use and why?**

Answer: The for loop felt most natural because it is easy to control how many times the loop runs.

## Time Spent

**Total time:** [6.5 hours]

**Breakdown:**

- Planning the loops: [2 hours]
- Input validation: [1 hours]
- Guessing logic: [1 hours]
- Testing and debugging: [1 hours]
- Writing documentation: [1.5 hours]

**Most time-consuming part:** [Which aspect took the longest and why?]

Answer: The most part took longest was planning the loops because I was make sure that I am writing correct loops

## Reflection

**What would you do differently next time?**

Answer: Next time I would plan the program steps first before writing the code. This would help me avoid mistakes and make the code easier to write.

**How did using three different loop types improve your understanding of repetition?**

Answer: Using three different loop types helped me understand that each loop is useful for different situations. I learned when to use for loops for counting, while loops for conditions, and do-while loops when input must happen at least once.
