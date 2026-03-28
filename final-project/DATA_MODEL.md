# Final Project — Data Model Planning Template

_Fill this out **before** writing any code. Think through your app's data first._

---

## Scenario (1–2 sentences)

_What does your app do? Who uses it and why?_

[This app is a Budget Tracker that helps users record and manage their expenses. A student or anyone managing personal spending can use this app to add expenses, view them, calculate total spending, and save the date to a file. ]

---

## Inputs (with types)

_List **at least 5** named inputs your app collects or works with. Include the data type for each._

_Example format:_
_- `movieTitle` (string) — the name of the movie the user enters_

- `expenseName` (string) — the name of the expense the user enters (example: Coffee or Groceries)
- `category` (string) — the type of expense (example: Food, Bills, Entertainment)
- `amount` (double) — the amount of money spent
- `menuChoice` (int) — the option the user chooses from the menu (1-5)
- `exitChoice` (bool or int) — determines whether user wants to exit the program

---

## Calculated or Derived Values

_List any values your program computes from the inputs (totals, averages, counts, formatted strings, etc.)._
_If your app doesn't calculate anything, write "None" and explain why._

[The program calculates the total spendign by adding all expense amounts stored in the list.

Example: totalSpending (double) - the sum of all expense amounts entered by the user.]

---

## Outputs (what the user sees)

_Describe what the program displays. Include menu options, summary views, confirmation messages, etc._

[A menu with options (Add Expense, View Expenses, Show Total Spending, Save Expenses, Exit)
A list of all expenses entered by the user
The total amount spent
A confirmation message when an expense is added
A confirmation message when expenses are saved to a file]

---

## Edge Case to Consider (at least 1)

_What could go wrong or behave unexpectedly? How will your app handle it?_

_Examples: file not found, user enters a letter instead of a number, empty list, duplicate entry._

[One edge case is when the user tries to view expenses before adding any. If the expenses list is empty, the program will display the message. This prevents errors and informs the user that they need to add expenses first.]
