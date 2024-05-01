using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> numbers = [];
        
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        // Ask the user for numbers until they enter 0
        int num;
        do
        {
            Console.Write("Enter number: ");
            num = Convert.ToInt32(Console.ReadLine());
            if (num != 0)
                numbers.Add(num);
        } while (num != 0);

        // Compute sum
        int sum = numbers.Sum();

        // Compute average
        double average = numbers.Average();

        // Find maximum number
        int max = numbers.Max();

        // Find lowest number
        int smallestPositive = numbers.Where(x => x > 0).DefaultIfEmpty(int.MaxValue).Min();

        // Display results
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");
        Console.WriteLine($"The lowest positive number is: {smallestPositive}");
        Console.WriteLine("The sorted list is:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}
