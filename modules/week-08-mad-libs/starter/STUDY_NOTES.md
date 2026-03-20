# Week 8: Mad Libs (Structure + Debugging) - Study Notes

**Name:** Aatiqa

## Program Structure

**What helper methods did you create (and what does each one do)?**
[List your methods and briefly describe each]

Answer: The program has helper methods to make it organized and easy to use. ChooseTemplate() lets the user pick a story, and CollectWords() asks for all the words needed for that story. ReadNonEmptyString() makes sure the user doesn’t enter empty words, and ReadIntInRange() checks that number inputs are valid. ReadYesNo() handles yes/no questions, returning true for “y” and false for “n”.

**Why is it helpful to move code out of `Main` and into helper methods?**
[Explain how this improves readability and reduces bugs]

Answer: Moving code out of Main into helper methods makes the program easier to read because each method does one specific job, so you don’t have one long, confusing block of code. It also makes it easier to find and fix mistakes since you can test and debug each small method separately. Reusing methods like ReadNonEmptyString() or ReadIntInRange() avoids repeating the same code in multiple places, which reduces errors. Overall, it keeps the program organized, cleaner, and more reliable.

## Data Modeling

**What is the purpose of the `StoryTemplate` class in this assignment?**
[Explain what data it stores and why]

Answer: The StoryTemplate class stores the information needed for a Mad Libs story, including the template’s name, the list of prompts for the user, and the story format with placeholders. Its purpose is to keep all the data for a story together in one place, so the program can easily collect words and generate the final story. This makes the code cleaner because the main program doesn’t have to manage prompts and story text separately. It also makes it easier to add new templates in the future.

**How did using a template make it easier to support two different stories?**
[Explain how the same logic can work with different prompts/text]

Answer: Using a template lets the program treat both stories the same way because each template stores its own prompts and story text. The main logic for collecting words and generating the story doesn’t need to change it works for any template. This means we can easily add more stories later by just creating new templates. It keeps the code simple and avoids repeating the same steps for each story.

## Testing and Debugging

**Where did you set a breakpoint while debugging this program (what line or method)?**
[Be specific - example: inside GenerateStory, at the beginning of CollectWords, etc.]

Answer: I set a breakpoint at the beginning of the CollectWords method to see when word collection starts, and also inside the GenerateStory method to check how the user’s words are inserted into the story. This helped me watch the array of words and make sure the story was formatted correctly.

**What did you learn from stepping through your code line by line?**
[Describe how watching execution helped you understand flow or find bugs]

Answer: By stepping through the code line by line, I learned exactly how the program asks for input, stores it in the array, and then inserts it into the story. It helped me see the order of method calls and catch mistakes, like missing prompts or incorrect array indexing. I also understood how the play-again loop works and why input validation is important. This made it easier to fix bugs and make the program run correctly.

**What bug or logic mistake did you encounter (and how did you fix it)?**
[Describe a real issue you ran into and how breakpoints/stepping helped]

Answer: I ran into a bug where choosing a template didn’t return the correct story because I had accidentally tried to use classes that didn’t exist. By setting a breakpoint inside ChooseTemplate and stepping through, I saw that the program never reached the right if branch. I fixed it by returning a new StoryTemplate directly instead of using nonexistent classes. Stepping through also helped me notice that input validation and the play-again loop weren’t working correctly at first, so I adjusted the ReadYesNo and ReadIntInRange methods.

## What I Learned

**Key takeaways from this week:**
[3 main things you learned]

1. How to break a program into small helper methods to make it easier to read and test.
2. How to use a class (StoryTemplate) to store story data and reuse the same logic for different templates.
3. How to debug step by step with breakpoints to find and fix bugs in input handling and program flow.

**What part of this assignment helped you understand program structure the most?**
[Breaking into methods, using public/private methods, separating concerns, etc.]

Answer: The part that helped me the most was breaking the program into small helper methods like ReadNonEmptyString, ReadYesNo, and CollectWords. It showed me how separating tasks into public and private methods makes the code easier to read, understand, and debug. Using the StoryTemplate class also the idea of keeping data and logic organized. Overall, separating concerns made the program structure much clearer.

## Time Spent

**Total time:** [5 hours]

**Breakdown:**

- Planning structure (methods/classes): [1 hours]
- Input validation: [1 hours]
- Story templates + formatting: [1 hours]
- Testing and debugging: [1 hours]
- Writing documentation: [1 hours]

**Most time-consuming part:** [Which aspect took the longest and why?]

Answer: The most time consuming part was making sure the input validation and the play-again loop worked correctly. I had to test multiple cases to ensure the program only accepted valid numbers or "y"/"n" responses. Debugging small mistakes in ReadIntInRange and ReadYesNo also took extra time. It required careful stepping through the code to make sure the loops behaved as expected.

## Reflection

**What would you improve if you had more time?**
[Ideas: more templates, better formatting, more validation, etc.]

Answer: If I had more time, I would add more story templates to make the game more fun and varied. I would also improve the formatting of the stories, like adding line breaks or colors for emphasis. Additionally, I could add more input validation, such as checking that numbers are positive or animals are plural. Finally, I might include a way to save or share the completed stories.

**How did breaking your program into smaller parts help you debug?**
[Explain the connection between structure and debugging]

Answer: Breaking the program into smaller parts made it easier to find and fix bugs because each method had a clear purpose. For example, I could test ReadIntInRange or CollectWords separately without running the whole program. It also helped me understand the flow of data, like how the user’s inputs move into the story template. Overall, smaller methods made debugging more organized and less confusing.
