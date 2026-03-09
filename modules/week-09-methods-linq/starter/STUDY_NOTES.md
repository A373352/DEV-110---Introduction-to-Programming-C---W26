# Week 9: Score Stats (Methods + LINQ) - Study Notes

**Name:** Test Student

## Methods and Decomposition

**Why is it helpful to break a program into small methods?**
[Think about readability, testing, and debugging]

Answer: It is helpful to break a program into small methods because the code becomes easier to read and understand. Each method does one small task. It also makes testing easier because we can test one method at a time. If there is a problem, it is easier to find and fix the bug because the code is organized into smaller parts.

## LINQ (Stats + Method Chaining)

**Which LINQ methods did you use for basic statistics?**
[Examples: Min, Max, Average, Count with predicates]

Answer: I used the LINQ methods Min(), Max(), Average(), and Count(). Min() finds the lowest score, Max() finds the highest score, Average() calculates the average score, and Count() counts the number of scores. I also used Count with a condition to coutn passing an failing scores.

**Which LINQ methods did you chain together for reports?**
[Examples: Where + OrderByDescending, OrderByDescending + Take]

Answer: I chained several LINQ methods together such as where(), OrderBy(), OrderByescending(), and Take(). For example, I used where() with OrderByDescending() to get passing scores in descending order. I also used OrderByDescending() with Take() to show the top scores.

**Why is it helpful to put score logic in a class (ScoreReport) instead of keeping everything in Program?**
[Think about organization, reuse, and readability]

Answer: It is helpful to put the score logic in a class becasue the program becomes more organized. The ScoreReport class keeps all the score related code in one place. This makes the program easier to read and maintain. It also allows the code to be reused in other programs if needed.

## What I Learned

**Key takeaways from this week:**
[3-5 main things you learned]

1. I learned how to create and use methods in C#.
2. I learned how to use LINQ to work with lists of data.
3. I learned how to sort and filter data using LINQ methods.
4. I learned how mehtod chaining works.
5. I learned how breakign code into small methods makes programs easier to manage.

**Which concept felt easiest (methods or LINQ) and why?**

Answer: Methods felt eaiser to understan because they are simple to use and help organize the program. Each method performs one task, so it is easy to read and understand what the program is doing.

## Time Spent

**Total time:** 5 hours

**Breakdown:**

- Understanding the starter code: 1 hours
- Implementing the print methods: 1 hours
- LINQ method chaining: 1 hours
- Testing and debugging: 1 hours
- Writing documentation: 1 hours

**Most time-consuming part:** [Which aspect took the longest and why?]

Answer: All of the took same time but debugging the program as errors happen such as missing parenthesis and expressions.

## Reflection

**What would you improve next time?**

Answer: Next time I would test each method earlier to find errors faster.

**How did methods make this program easier to work on?**

Answer: Methods made the program easier to work on because each method had a clear purpose. This made the code more organized and easier to read. It also helped with debugging because I could check one method at a time.
