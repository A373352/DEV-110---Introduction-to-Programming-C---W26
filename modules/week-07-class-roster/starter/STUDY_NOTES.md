# Week 7: Class Roster Builder (Arrays) - Study Notes

**Name:** Aatiqa

## Arrays and `count`

**What are “parallel arrays” and how did you use them in this assignment?**
[Explain how rosterNames and rosterCredits stay lined up by index]

Answer: Parallel arrays are two or more arrays where related data at the same index belongs together. I used like an rosterNames and rosterCredits are parallel arrays. For example, rosterNames[0] and rosterCredits[0] boht belong to the same student.

**What is the purpose of the `count` variable?**
[Explain how it tracks how many roster slots are “in use”]

Answer: The count variable keeps track of how many slots in the roster are actually used. Even if the array has extra space, count tells the program which parts contain real student data.

**Where did you use `count` in loops and why?**
[Explain why you loop 0..count-1 instead of using the full array length]

Answer: I used count whenever looping through the roster, like when printing students or copying arrays. I loop from 0 to count - 1 because only those positions have valid student information. Looping the full array length could include empty slots.

## Printing and Sorting

**How did you print the class roster using a `foreach` loop?**
[Describe building an array of roster lines and then printing each line]

Answer: I first build an array of strings called lines using the BuildRosterLines method. Each element contaiend the student's name and credits. Then I used a foreach loop to print each line, which made it simple and roadable.

**How did you sort the roster while keeping names and credits aligned?**
[Describe copying the used roster into new arrays and using Array.Sort on parallel arrays]

Answer: I copied only the used portion of the arrays into new arrays using CopyUsedRoster. Then I used Array.Sort on the parallel arrays. If sorting by name, it rearranged boht sortedNames and sortedCredits together so that each name stayed wiht its correct credits.

## What I Learned

**Key takeaways from this week:**
[3-5 main things you learned]

1. How to use parallel arrays to keep related data connected.
2. How to track used elements in an array with a count variable.
3. How to loop through arrays safely using for and foreach.
4. How to sort arrays while maintaiing relationships between parallel arrays.
5. How input validation and formatting make programs user friendly.

**Which loop felt most natural to use and why?**

Answer: The for loop felt most natural for adding and printing students because I knew exactly how many times to repeat actions based on count or the number of students being added.

## Time Spent

**Total time:** [6 hours]

**Breakdown:**

- Planning the arrays/menu: [1 hours]
- Input validation: [1 hours]
- Add + print roster features: [1 hours]
- Sorting feature: [1 hours]
- Testing and debugging: [1 hours]
- Writing documentation: [1 hours]

**Most time-consuming part:** [Which aspect took the longest and why?]

Answer: All of them time took same exactly that was adding multiple students and copying arrays correctly because I had to make sure the indexes matched between names and credits.

## Reflection

**What would you do differently next time?**

Answer: I would make the arrays grow dynamically so we are not limited to a fixed number of students.

**How did using `for` and `foreach` improve your understanding of arrays?**

Answer: I learned that for is great when you need precise control over indexes, like adding students or copying arrays. Foreach is easier when you just want to read and print each elements without worrying about the index. Both helped me work with arrays more confidently.
