# Week 10: Habit Tracker (File I/O) — Study Notes

**Name:** Aatiqa

## File I/O — Reading

**What does `File.ReadAllLines` return, and how did you use it?**
[Think about the return type and what you did with each element]

Answer: File.ReadAllLines retruns an array of strings. Each string in online line from the line. I used it to get all the lines from the habits CSV file, then looped thorugh each line to create Habit objects.

**Why is it important to skip blank lines when reading a CSV file?**
[What would happen if you tried to split an empty string on `','`?]

Answer: If we don't skip blank lines, splitting an empty string by commas would give an array with no real data, which could cause errors when trying to read the name, status, or frequency.

## File I/O — Writing

**What does `File.WriteAllLines` do, and what arguments does it take?**
[Describe the path argument and what goes in the string array]

Answer: File.WriteAllLines writes text to a file. It takes two arguments: the path of the file and an array of strings. Each string in the array becomes one line in the file.

**What is `Select(...).ToArray()` doing in `SaveHabits`?**
[Break down the two steps: what does `Select` produce, and why call `ToArray()`?]

Answer: Select goes through each habit and converts it into a CSV line like "Name,done, daily" ToArray() then turns all these lines into an arrya of strings that File.WriteAllLines can use to write to the file.

## Exception Handling

**What is a `FileNotFoundException` and when does it occur?**
[Describe the scenario where C# throws this specific exception]

Answer: A FileNoFoundException happens when the program tries to open a file that doesn't exist. For example, if the CSV file path is wrong or the file was deleted.

**Why do we catch `FileNotFoundException` specifically instead of using `catch (Exception)`?**
[Think about what catching all exceptions can hide from you]

Answer: Catching just FileNotFoundException helps us handle only the case where the file is missing. If we used catch (Exception), it could hide other errors we don't want to ignore.

## What I Learned

**Key takeaways from this week:**
[List 3 main things you learned]

1. How to read from and write to CSV files in C# using File.ReadAllLines and File.WriteAllLines
2. How to use LINQ (Count, Select) to summarize data in lists.
3. How to handle exception safely with try-catch, especially FileNotFoundException.

**What was the trickiest part of this assignment and how did you work through it?**

Answer: The trickiest part was making sure the summary counts and percentages were correct, especially avoiding divide by zero. I fixed it by checking if the total number of habits was zero before calculating percentages.

## Time Spent

**Total time:** 6 hours

**Breakdown:**

- Understanding the starter code and CSV formats: 1 hours
- Implementing LoadHabits: 1.5 hours
- Implementing PrintHabits / PrintSummary: 1 hours
- Implementing AddHabit / UpdateHabit / SaveHabits: 1.5 hours
- Testing and debugging: 1 hours
- Writing study notes: 0.5 hours

**Most time-consuming part:**

Answer: Debugging errors in the Printsummary method and making sure the LINQ counts worked correctly.
