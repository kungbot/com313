using System;

namespace HowManyDaysApp
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter a date (MM/DD/YYYY) or type 'exit' to quit:");

                // Get user input
                string userInput = Console.ReadLine();

                // Check if the user wants to exit
                if (userInput.ToLower() == "exit")
                {
                    break;
                }

                // Try to parse the user input as a date
                if (DateTime.TryParse(userInput, out DateTime enteredDate))
                {
                    DateTime currentDate = DateTime.Now;
                    
                    // Calculate the difference between the current date and the entered date
                    TimeSpan difference = enteredDate - currentDate;

                    if (difference.TotalDays > 0)
                    {
                        // Future date
                        Console.WriteLine($"There are {difference.Days} days left until {enteredDate.ToShortDateString()}.");
                    }
                    else if (difference.TotalDays < 0)
                    {
                        // Past date
                        Console.WriteLine($"{Math.Abs(difference.Days)} days have passed since {enteredDate.ToShortDateString()}.");
                    }
                    else
                    {
                        // Same date
                        Console.WriteLine("The entered date is today.");
                    }
                }
                else
                {
                    // Invalid date input
                    Console.WriteLine("Invalid date. Please enter a valid date in MM/DD/YYYY format.");
                }
            }

            Console.WriteLine("Program exited. Goodbye!");
        }
    }
}
