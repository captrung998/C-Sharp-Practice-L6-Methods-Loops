using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Part 1: Display the first 10 natural numbers
        Console.WriteLine("Part 1:");
        for (int i = 1; i <= 10; i++)
        {
            Console.Write($"{i} ");
        }
        Console.WriteLine();

        // Part 2: Display the cube of numbers up to an integer
        Console.WriteLine("\nPart 2:");
        Console.Write("Input number of terms: ");
        int terms = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= terms; i++)
        {
            int cube = i * i * i;
            Console.WriteLine($"Number is: {i} and cube of {i} is: {cube}");
        }

        // Part 3: Display the multiplication table of a given integer
        Console.WriteLine("\nPart 3:");
        Console.Write("Input the number (Table to be calculated): ");
        int number = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{number} X {i} = {number * i}");
        }

        // Part 4: Display a Y pattern with asterisks
        Console.WriteLine("\nPart 4:");
        int n = 7; // Size of the pattern (adjust as needed)
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (j == i || j == n - 1 - i)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }

        // Part 5: Simulate character health regeneration
        Console.WriteLine("\nPart 5:");
        int health = 0;
        for (int round = 1; round <= 5; round++)
        {
            health += 10;
            Console.WriteLine($"Round {round}: Health {health}");
        }

        // Part 6: Iterate through a list of names using foreach loop
        Console.WriteLine("\nPart 6:");
        List<string> names = new List<string> { "John", "James", "Luke", "Lila" };
        foreach (var name in names)
        {
            Console.WriteLine($"Name: {name}");
        }

        // Part 7: Display squares of numbers in a list using foreach loop
        Console.WriteLine("\nPart 7:");
        List<int> numbers = new List<int> { 2, 3, 4, 5 };
        foreach (var number in numbers)
        {
            Console.WriteLine($"Square of {number}: {number * number}");
        }
    }
}
