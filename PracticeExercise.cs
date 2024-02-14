using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {



            // Exercise 1
            // Questions 1

            // Take input from the user
            Console.Write("Enter a positive integer (N): ");

            // Read the input 
            int n = Convert.ToInt32(Console.ReadLine());

            // Loop from 1 to N (inclusive)
            for (int i = 1; i <= n; i++)
            {

                Console.Write(i + " ");
            }


            // Exercise 1
            // Questions 2

            // Take input from the user
            Console.Write("Enter a positive integer (N): ");

            // Read the input 
            int n = Convert.ToInt32(Console.ReadLine());

            // Loop through numbers from 1 to N (inclusive)
            for (int i = 1; i <= n; i++)
            {
                // Check if the current number is not divisible by both 3 and 7
                if (i % 3 != 0 && i % 7 != 0)
                {

                    Console.Write(i + " ");
                }
            }

            // Exercise 1
            // Questions 3


            // Take input from the user
            Console.Write("Enter the value of N: ");

            // Read the input 
            int n = Convert.ToInt32(Console.ReadLine());

            // Create an array to store the numbers entered by the user
            int[] numbers = new int[n];

            // Loop to input numbers from the user
            for (int i = 0; i < n; i++)
            {

                Console.Write($"Enter number {i + 1}: ");

                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Initialize variables to store the minimum and maximum numbers
            int min = numbers[0];
            int max = numbers[0];

            // Loop to find the minimum and maximum numbers in the array
            for (int i = 1; i < n; i++)
            {

                if (numbers[i] < min)
                {
                    min = numbers[i];
                }

                else if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }

            // Output the minimal and maximal numbers
            Console.WriteLine($"The minimal number is: {min}");
            Console.WriteLine($"The maximal number is: {max}");


            // Exercise 1
            // Questions 4


            // Take input from the user
            Console.WriteLine("Enter the value of N: ");
            // Read the input 
            int n = int.Parse(Console.ReadLine());

            // Take input from the user
            Console.WriteLine("Enter the value of K: ");

            // Read the input 
            int k = int.Parse(Console.ReadLine());

            // Initialize variables to store the factorial values of N and K
            BigInteger Nfac = 1;
            BigInteger Kfac = 1;
            BigInteger result;

            // Calculate the factorial of N
            for (int i = 1; i <= n; i++)
            {
                Nfac *= i;
            }

            // Calculate the factorial of K
            for (int i = 1; i <= k; i++)
            {
                Kfac *= i;
            }

            // Calculate the binomial coefficient
            result = Nfac / Kfac;

            // Output the result
            Console.WriteLine(result);


            // Exercise 1
            // Questions 5


            // Take input from the user
            Console.Write("Enter the value of N: ");
            // Read the input 
            int n = int.Parse(Console.ReadLine());


            // Take input from the user
            Console.Write("Enter the value of K: ");
            // Read the input 
            int k = int.Parse(Console.ReadLine());

            // Initialize variables to store the factorial values of N, K, and (K-N)
            BigInteger nFactorial = 1;
            BigInteger kFactorial = 1;
            BigInteger kMinusNFactorial = 1;

            // Calculate the factorial of N
            for (int i = 1; i <= n; i++)
            {
                nFactorial *= i;
            }

            // Calculate the factorial of K and (K-N)
            for (int i = 1; i <= k; i++)
            {
                kFactorial *= i;
                // Calculate the factorial of (K-N) if i is less than or equal to (K-N)
                if (i <= (k - n))
                {
                    kMinusNFactorial *= i;
                }
            }

            // Calculate the binomial coefficient
            BigInteger result = (nFactorial * kFactorial) / kMinusNFactorial;

            // Output the result
            Console.WriteLine($"The result of {n}!*{k}! / ({k}-{n})! is: {result}");



            // Exercise 2 
            // Question 1


            // Take input from the user
            Console.Write("Enter the value of N: ");
            // Read the input 
            int n = int.Parse(Console.ReadLine());

            // Take input from the user
            Console.Write("Enter the value of X: ");
            // Read the input 
            int x = int.Parse(Console.ReadLine());

            double sum = 1; // Initialize sum with the first term (1 + ...)
            double term = 1; // Initialize the first term (1)

            // Loop to calculate the sum of the series
            for (int i = 1; i <= n; i++)
            {
                term *= i; // Calculate the factorial of i
                sum += term / Math.Pow(x, i); // Add the next term to the sum
            }

            // Output the result
            Console.WriteLine("The sum is: " + sum);


            // Exercise 2 
            // Question 2

            // Take input from the user
            Console.Write("Enter the value of N: ");
            // Read the input 
            int n = int.Parse(Console.ReadLine());

            int a = 0, b = 1, sum = 0; // Initialize variables 

            // Loop to calculate the sum of the first n terms of the Fibonacci sequence
            for (int i = 0; i < n; i++)
            {
                sum += a; // Add the current term to the sum
                int next = a + b; // Calculate the next term of the sequence
                a = b; // Update the value of the first term
                b = next; // Update the value of the second term
            }

            // Output the result
            Console.WriteLine("The sum of the first " + n + " members of the Fibonacci sequence is: " + sum);


            // Exercise 2 
            // Question 4

            // Take input from the user
            Console.Write("Enter the first number: ");
            // Read the input 
            int a = int.Parse(Console.ReadLine());

            // Take input from the user
            Console.Write("Enter the second number: ");
            // Read the input 
            int b = int.Parse(Console.ReadLine());

            // Calculate the GCD of the two numbers
            int gcd = CalculateGCD(a, b);

            // Output the result
            Console.WriteLine("The GCD of " + a + " and " + b + " is: " + gcd);
        }

        // Method to calculate the GCD using the Euclidean algorithm
        static int CalculateGCD(int a, int b)
        {
            while (b != 0)
            {
                // Swap a and b, if necessary
                int temp = b;
                b = a % b;
                a = temp;
            }
            // Return the GCD
            return a;



            // Exercise 3
            // Question 1


            // Method to calculate the nth Catalan number recursively
            static ulong Catalan(ulong n)
            {
                // Base case: if n is 0 or 1, the Catalan number is 1
                if (n <= 1)
                    return 1;

                ulong res = 0; // Initialize the result variable
                for (ulong i = 0; i < n; i++)
                    // Calculate the nth Catalan number using the recursive formula
                    res += Catalan(i) * Catalan(n - i - 1);

                return res; // Return the calculated Catalan number
            }

            static void Main()
            {

                // Take input from the user
                Console.Write("Enter the value of N: ");
                // Read the input 
                ulong n = ulong.Parse(Console.ReadLine());

                // Output the nth Catalan number
                Console.WriteLine("The " + n + "th Catalan number is: " + Catalan(n));
            }


            // Exercise 3
            // Question 5

            // Define arrays for suits and values
            string[] suits = { "Clubs", "Diamonds", "Hearts", "Spades" };
            string[] values = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };

            // Iterate over each suit
            foreach (var suit in suits)
            {
                // Iterate over each value
                foreach (var value in values)
                {
                    // Output the combination of value and suit
                    Console.WriteLine($"{value} of {suit}");
                }
            }


            // Exercise 4
            // Question 1

            // Take input from the user
            Console.Write("Enter the value of N: ");
            // Read the input 
            int n = int.Parse(Console.ReadLine());

            // Check if N is less than 20
            if (n < 20)
            {
                // If N is less than 20, generate the multiplication table
                for (int i = 1; i <= n; i++)
                {
                    for (int j = 1; j <= n; j++)
                    {

                        Console.Write(i * j + " ");
                    }

                    Console.WriteLine();
                }
            }
            else
            {

                Console.WriteLine("N should be less than 20.");
            }


            // Exercise 5
            // Question 1

            // Take input from the user
            Console.Write("Enter the value of N: ");

            // Read the input 
            int n = int.Parse(Console.ReadLine());

            // Initialize a variable to count the number of trailing zeros
            int countOfZeros = 0;

            // Loop to calculate the number of trailing zeros in the factorial of N
            for (int i = 5; n / i >= 1; i *= 5)
            {

                countOfZeros += n / i;
            }

            // Output the result
            Console.WriteLine("The number of trailing zeros in " + n + "! is: " + countOfZeros);



            // Exercise 6
            // Question 1


            // Take input from user
            Console.Write("Enter the value of N: ");

            // Read the input 
            int n = int.Parse(Console.ReadLine());

            // Create a new 2D array (matrix) of size N x N
            int[,] matrix = new int[n, n];

            // Initialize variables 
            int value = 1;
            int top = 0, bottom = n - 1, left = 0, right = n - 1;

            // Traverse the matrix in a spiral pattern and fill it with values
            while (value <= n * n)
            {
                // Fill the top row from left to right
                for (int i = left; i <= right; i++)
                {
                    matrix[top, i] = value++;
                }
                top++;

                // Fill the rightmost column from top to bottom
                for (int i = top; i <= bottom; i++)
                {
                    matrix[i, right] = value++;
                }
                right--;

                // Fill the bottom row from right to left
                for (int i = right; i >= left; i--)
                {
                    matrix[bottom, i] = value++;
                }
                bottom--;

                // Fill the leftmost column from bottom to top
                for (int i = bottom; i >= top; i--)
                {
                    matrix[i, left] = value++;
                }
                left++;
            }

            // Print the generated matrix to the console
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    // Print each element of the matrix followed by a tab
                    Console.Write(matrix[i, j] + "\t");
                }
                // Move to the next line after printing each row of the matrix
                Console.WriteLine();
            }









        }
    }
}
