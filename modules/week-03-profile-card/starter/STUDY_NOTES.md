# Week 3: Personal Profile Card - Study Notes

**Name:**
Aatiqa Imran

## Understanding Variables and Data Types

**What are the four main data types you used in this assignment?**
[List string, int, double, and bool - explain what each stores and give examples from your profile card]

Answer: string: Used to store text data, such as a name, dream job, or hometown.
        int: Used to store whole numbers (integers), such as age, graduation year, or height.
        double: Used to store decimal numbers, such as GPA.
        bool : Used to store true or false values (yes or no), such as whether someone is a full-time student.

**Why did you use `double` for GPA instead of `int`?**
[Explain the difference and why decimal precision matters for GPA]

Answer: I used a double for GPA instead of an int because GPA requires decimal precision (like 3.5 or 4.0), and an
int can only store whole numbers.

**How did you convert the yes/no input into a boolean?**
Explain the comparison operation you used?
Answer: I converted the yes/no input into a boolean by comparing the user’s response to "yes" if the input is "yes",
the value is set to true, otherwise it is set to false.

## Data Modeling Decisions

**How did you organize the information into logical groups?**
[Explain why you grouped certain pieces of information together (personal, academic, etc.)]

Answer: I organized the information into logical groups by separating personal details (like name and hometown) from
academic information (like GPA, graduation year, and full-time status) to make the profile card clear and easy to understand.

**Which pieces of information did you calculate rather than ask for?**
[List the derived data: birth year, years to graduation, height conversion, honor status, age in months]

Answer: birth year, years to graduation, honor status and age in months

**Why is it better to calculate birth year from age rather than ask for both?**
[Explain data consistency and reducing redundant input]

Answer: It is better to calculate birth year from age because it keeps the data consistent and avoids asking for
redundant information that could lead to errors if the two values don’t match.

## Challenges and Solutions

**Biggest challenge with this assignment:**
[What was the hardest part? Type conversion, calculations, formatting, choosing data types?]

Answer: The harderst part was calculations and formatting.

**How you solved it:**
[Explain your approach to overcoming the challenge]

Answer: I went back to the lectures and rewatched the videos to better understand the calculations and formatting.

**Most confusing concept:**
[What was hardest to understand? Type casting, modulus for height, boolean logic, or formatting?]

Answer: The hardest was to understand moduls for height.

## Type Conversion and Calculations

**How do you convert string input to a number?**
[Explain Parse methods: int.Parse(), double.Parse()]

Answer: I convert string input to a number using int.Parse() for integers and double.Parse() for decimals so the
input can be used in calculations.

**What calculation did you use to convert height from inches to feet and inches?**
[Explain: feet = inches / 12, remaining = inches % 12]

Answer: I converted height from inches to feet and inches by dividing the total inches by 12 to get the feet and using
the remainder (% 12) to get the remaining inches.

**How did you determine if someone is an honor student?**
[Explain the boolean comparison: gpa >= 3.5]

Answer: I determined if someone is an honor student by checking if their GPA is greater than or equal to 3.5; if it is,
the boolean isHonorStudent is true, otherwise it is false

## Output Formatting

**How did you format the GPA to show exactly 2 decimal places?**
[Explain the :F2 format specifier]

Answer: I formatted the GPA to show exactly 2 decimal places by using the :F2 format specifier, which rounds the
number to two digits after the decimal when displaying it.

**How did you display different text based on whether someone is full-time or part-time?**
[Explain the conditional/ternary operator you used]

Answer: I displayed the student’s status by printing true if they are full-time and false if they are part-time.

**What techniques did you use to make the output look organized?**
[Discuss alignment, spacing, section headers, borders]

Answer: Spacing, section headers, borders

## Real-World Data Modeling

**What other calculated fields could you add to a profile?**
[Think of other derived data: BMI from height/weight, time to birthday, etc.]

Answer: I could add a BMI From height/weight, time to birthday.

**Why is choosing the right data type important in real applications?**
[Explain memory, precision, and type safety]

Answer: Choosing the right data type is important to use memory efficiently, keep accurate values, and prevent errors
by ensuring only valid data is stored.

**How does this profile card relate to real-world applications?**
[Think about social media profiles, job applications, student records systems]

Answer: This profile card relates to real world applications because it organizes personal and academic information
like student records.

## What I Learned

**Key takeaways from this week:**
[What are the 3-5 most important things you learned about variables and data modeling?]

1. variables store different types of data
2. choosing the right type prevents error
3. input often needs conversion
4. calculations can create new data
5. formatting makes output clear.

**Which data type was most challenging to work with and why?**
[Reflect on your experience with string, int, double, or bool]

Answer: The most challenging data type was double because it requires careful handling of decimals and
formatting to show the correct number of decimal places.

**How does understanding data types help you write better programs?**
[Explain the benefits of type safety and appropriate data representation]

Answer: Understanding data types helps me write better programs by ensuring values are stored correctly,
preventing errors, and making calculations and data handling more accurate and reliable.

## Testing and Debugging

**What test cases did you use to verify your calculations?**
[List different inputs you tested - edge cases, typical values, etc.]

Answer: I tested typical values like GPA = 3.5, age = 16, and height = 70 inches, and edge cases like
GPA = 0.0 or 4.0, age = 0, and very tall or short heights to make sure all calculations worked correctly.

**What bugs or errors did you encounter and fix?**
[Describe any type conversion errors, calculation mistakes, or formatting issues]

Answer: I encountered errors when converting string input to numbers and fixed them by using int.Parse()
and double.Parse(), and I also corrected formatting issues to display GPA with two decimal places.

**How did you validate that your data types were correct?**
[Explain how you checked that GPA, heights, ages worked correctly]

Answer: I validated my data types by testing different inputs for GPA, height, and age to make sure numbers were
stored correctly, calculations worked as expected, and the program didn’t crash when converting strings to integers or doubles.

## Time Spent

**Total time:** [8.5 hours]

**Breakdown:**

-   Understanding data types and planning variables: [1.5 hours]
-   Collecting user input with correct types: [2 hours]
-   Implementing calculations: [1.5 hours]
-   Formatting output: [1 hours]
-   Testing and debugging: [1 hours]
-   Writing documentation: [1.5  hours]

**Most time-consuming part:** [Which aspect took the longest and why?]

Answer: The most time consuming part was collecting user input with the correct types because I had to make sure
each input was converted properly and handled without errors.

## Reflection

**What would you do differently if you started over?**
[Consider variable names, calculation order, organization, etc.]

Answer: If I started over, I would choose clearer variable names, organize calculations in a logical order, and plan
the input and output formatting more carefully to make the program easier to read and debug.

**How does proper data modeling make programs easier to maintain?**
[Think about readability, consistency, and reducing errors]

Answer: Proper data modeling makes programs easier to maintain by keeping data organized, improving readability,
ensuring consistency, and reducing the chance of errors.

**What real-world system would you like to model next?**
[Shopping cart, game character, recipe calculator, etc.]

Answer: I would like to model a shopping cart system next, where I can track items, prices, quantities, and calculate
totals and discounts.
