using System;

class Program
{
    const int MAX = 100;

    /// <summary>
    /// Calculates the sum of the elements in an array.
    /// </summary>
    /// <param name="arr">The array of integers.</param>
    /// <returns>The sum of the elements.</returns>
    static int Sum(int[] arr)
    {
        int result = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            result += arr[i];
        }
        return result;
    }

    /// <summary>
    /// Reads an integer from the console.
    /// </summary>
    /// <param name="errorMessage">The error message to display if the input is not a valid integer.</param>
    /// <returns>The integer entered by the user.</returns>
    static int ReadIntegerFromConsole(string errorMessage)
    {
        if (!int.TryParse(Console.ReadLine(), out int result))
        {
            Console.WriteLine(errorMessage);
            Environment.Exit(1);
        }
        return result;
    }

    static void Main()
    {
        Console.Write("Enter the number of elements (1-100): ");
        int n = ReadIntegerFromConsole("Invalid input. Please provide a digit ranging from 1 to 100.");
        if (n < 1 || n > MAX)
        {
            Console.WriteLine("Invalid input. Please provide a digit ranging from 1 to 100.");
            Environment.Exit(1);
        }

        int[] arr = new int[n];

        Console.WriteLine($"Enter {n} integers:");
        for (int i = 0; i < n; i++)
        {
            arr[i] = ReadIntegerFromConsole("Invalid input. Please enter valid integers.");
        }

        int total = Sum(arr);

        Console.WriteLine($"Sum of the numbers: {total}");
    }
}