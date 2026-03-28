# Final Project: Build Your Own App

## Summary

This is your chance to design and build a C# console app of your own choosing. There is no
starter code and no automated tests — you pick the idea, plan it out, and build everything
from scratch using the skills you have practiced all quarter.

This assignment is **extra credit** and is worth **75 points**, with an additional **25 bonus
points** if you record a short video walkthrough.

---

## Learning Objectives

- Design a program before writing code
- Use all core C# concepts from the course together in one cohesive app
- Create and organize a multi-file C# project from scratch
- Reflect on your own design decisions

---

## App Idea Guidelines

You can build any console app that interests you. A few ideas to get you started:

- Personal budget or expense tracker
- Contact or address book
- Recipe or ingredient manager
- Study flashcard quiz
- Workout or habit log
- Movie, book, or game collection tracker

Keep the scope small. A focused app that works well is worth more than a large app
that is only half finished.

---

## Required Concepts

Your app must clearly demonstrate **all 8** of the following:

| #   | Concept                                                                    | Introduced |
| --- | -------------------------------------------------------------------------- | ---------- |
| 1   | Variables using appropriate data types (`string`, `int`, `double`, `bool`) | Week 3     |
| 2   | If/else decisions (at least one conditional branch)                        | Week 4     |
| 3   | At least one loop (`while`, `do-while`, or `for`)                          | Week 5     |
| 4   | Formatted string output (labels, alignment, or headers)                    | Week 6     |
| 5   | An array or `List<T>` storing multiple items                               | Week 7     |
| 6   | At least one custom class in its own `.cs` file                            | Week 8     |
| 7   | At least two named methods beyond `Main`                                   | Week 9     |
| 8   | Read from or write to a file (CSV or plain text)                           | Week 10    |

---

## Grading Criteria

| Area                                                                      | Points  |
| ------------------------------------------------------------------------- | ------- |
| `DATA_MODEL.md` completed (5+ inputs, scenario, outputs, edge case)       | 10      |
| App compiles and runs without errors                                      | 10      |
| All 8 required concepts demonstrated in working code (5 pts each)         | 40      |
| Code quality — file header in every `.cs` file, formatted, readable names | 5       |
| Reflection section below completed                                        | 10      |
| **Total**                                                                 | **75**  |
| **Bonus: 5–10 min video walkthrough (app demo + code tour)**              | **+25** |

---

## Getting Started

1. Fill out `DATA_MODEL.md` **before writing any code**

2. Create your assignment branch:

    ```bash
    git checkout main
    git pull
    git checkout -b assignment/final-project
    ```

3. Scaffold a new console project inside the `final-project` folder:

    ```bash
    cd final-project
    dotnet new console -n YourAppName
    cd YourAppName
    ```

4. Build your app, running it often to test:

    ```bash
    dotnet run
    ```

5. Format your code before committing:

    ```bash
    dotnet format
    ```

---

## Helpful Tips / Common Pitfalls

- **Plan first** — a completed `DATA_MODEL.md` saves hours of rewriting halfway through
- **Build incrementally** — get `dotnet run` working with one feature before adding the next
- **Commit often** — small, frequent commits make it easy to undo mistakes
- **Re-read the checklist** before submitting — make sure all 8 concepts are present and visible
- **Don't over-scope** — a well-built small app beats an ambitious unfinished one

---

## Submission

1. Complete your app, fill out the reflection below, and format your code:

    ```bash
    dotnet format
    ```

2. Stage and commit everything:

    ```bash
    git add final-project/
    git commit -m "Final Project: [Your App Name]"
    ```

3. Push your branch:

    ```bash
    git push -u origin assignment/final-project
    ```

4. Open a pull request on GitHub:
    - Base branch: `main`
    - Title: `Final Project: [Your App Name]`
    - Add a short description of what your app does

5. Submit on Canvas:
    - Paste your **pull request URL** in the text submission box
    - If you recorded a video for bonus points, paste the **video link** on the next line

---

---

## My Project Reflection

_Fill out this section before submitting. Write in your own words — a few sentences per prompt is enough._

**Name:**-Aatiqa

**App Name:** Budget Tracker

--

### What I Built

_Describe your app in 1–3 sentences. What does it do? Who might use it?_

Answer: I built a console application called Budget Tracker. The app alows user to add expense, view their expenses, calculate the toal amount spent and save the expenses to a file. It can be use by students or anyone who wants to keep track of their daily spending.

---

### Why I Chose This Idea

_Why did this app interest you? What made it feel like a good fit for what you know?_

Answer: I choose this idea because managing money and tracking expenses is useful in everyday life. I also thought it would be good project because it allowed me to practice the programming concepts we learned in class like lists, loops and file saving.

---

### Required Concepts — Where I Used Them

_For each concept below, write one sentence describing where it appears in your code._

**Variables & data types:** I used variable like name (string), category (string), amount (double), and choice (int) to store user input.

**If/else decisions:** I used if / else statements to decide which menu option the user selected such as adding expenses or viewing expenses.

**Loops:** I used a while loop to keep the program running until the user chooses to exit and a foreach loop to display all expenses.

**Formatted string output:** I used formatted strings like $"{e.Name} | {e.Category} | ${e.Amount}" to display the expense information clearly.

**Array or List:** I used a List<Expense> to store multiple expenses entered by the user.

**Custom class:** I created a custom class called Expense to store the name, category and amount of each expense

**Named methods:** I created methods such as AddExpense(), ViewExpenses(), ShowTotal(), and SaveExpenses() to organize the code.

**File I/O:** I used StreamWriter to save the list of expenses into a file called expenses.txt.

---

### What Was Most Challenging

_What part of the project was hardest? How did you work through it?_

Answer: The most challenging part was fixing errors and making sure the program compiled correctly. Sometimes the program had small mistakes like incorrect variable names, and I had to carefully read the error messages to fix them.

---

### What I Would Do Differently

_If you had more time, what would you change, add, or improve?_

Answer: If I had more time, I wuld improve the program by adding better input validation so the program doesn't not crash if the user enters incorrect data. I would also add a feature to load previously saved expenses from a file.

---

### Time Spent

_Roughly how many hours did you spend total? Give a short breakdown._

| Task                  | Time |
| --------------------- | ---- |
| Planning / DATA_MODEL |   1  |
| Writing code          |   2  |
| Debugging             |   1  |
| Reflection / README   |   0.5|
| **Total**             |   4.5|
