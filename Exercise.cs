using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_AssignmentExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare variables
            int number;
            bool isValid = false;

            // Start a loop to ensure a valid number is entered
            while (!isValid)
            {
                // Take input from the User
                Console.Write("Enter a number (below 10) to display its multiplication table: ");

                number = Convert.ToInt32(Console.ReadLine());

                // Check if the entered number is less than 10
                if (number < 10)
                {
                    // If the number is valid, set isValid flag to true

                    isValid = true;

                    Console.WriteLine($"\nMultiplication table for {number}:");

                    // Loop to print the multiplication table for the entered number
                    for (int i = 1; i <= 10; i++)
                    {

                        Console.WriteLine($"{number} x {i} = {number * i}");
                    }
                }
                else
                {

                    Console.WriteLine("Please enter a number below 10.");
                }
            }


        }
    }
}
