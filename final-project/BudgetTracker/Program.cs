// ===============================
// SpendSmart Budget Tracker
// Name: Aatiqa Imran
// Description: A simple console app to track expenses
// ===============================

using System;
using System.Collections.Generic;
using System.IO;

namespace BudgetTracker
{
    public class Program
    {
        // List to store all expenses
        private static List<Expense> expenses = new List<Expense>();

        public static void Main(string[] args)
        {
            Console.WriteLine("==== SpendSmart Budget Tracker ====");

            // user's menu choice
            int choice = 0;

            // Main loop runs until user chooses 5 (Exit)
            while (choice != 5)
            {
                // Show menu
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1) Add Expense");
                Console.WriteLine("2) View Expenses");
                Console.WriteLine("3) Show Total Spending");
                Console.WriteLine("4) Save Expenses");
                Console.WriteLine("5) Exit");

                // Get user input
                Console.Write("Please enter your choice (1-5): ");
                choice = int.Parse(Console.ReadLine());

                // Call the correct function based on user choice
                if (choice == 1)
                {
                    AddExpense();
                }
                else if (choice == 2)
                {
                    ViewExpenses();
                }
                else if (choice == 3)
                {
                    ShowTotal();
                }
                else if (choice == 4)
                {
                    SaveExpenses();
                }
                else if (choice != 5)
                {
                    Console.WriteLine("Invalid choice! Please enter a number between 1-5.");
                }
            }
            // Goodbye message
            Console.WriteLine("Goodbye! Thank you for using it.");
        }

        // Method to add a new expense
        private static void AddExpense()
        {
            Console.Write("Expense Name: ");
            string name = Console.ReadLine();

            Console.Write("Category: ");
            string category = Console.ReadLine();

            Console.Write("Amount: ");
            double amount = double.Parse(Console.ReadLine());

            // Create new expense object
            Expense e = new Expense(name, category, amount);

            // Add to list
            expenses.Add(e);

            Console.WriteLine("Expense added successfully!");
        }

        // Method to display all expenses
        private static void ViewExpenses()
        {
            if (expenses.Count == 0)
            {
                Console.WriteLine("No expenses recorded yet.");
                return;
            }

            Console.WriteLine("\nAll Expenses:");
            foreach (Expense e in expenses)
            {
                Console.WriteLine($"{e.Name} | {e.Category} | ${e.Amount}");
            }
        }

        // Method to calculate and show total spending
        private static void ShowTotal()
        {
            double total = 0;

            foreach (Expense e in expenses)
            {
                total += e.Amount;
            }

            Console.WriteLine($"\nTotal Spending: ${total}");
        }

        // Method to save expenses to a text file
        private static void SaveExpenses()
        {
            using (StreamWriter writer = new StreamWriter("expenses.txt"))
            {
                foreach (Expense e in expenses)
                {
                    writer.WriteLine($"{e.Name},{e.Category},{e.Amount}");
                }
            }
            Console.WriteLine("Expenses saved to expenses.txt successfully!");
        }
    }
}
