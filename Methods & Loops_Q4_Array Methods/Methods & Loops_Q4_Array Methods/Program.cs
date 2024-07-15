using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // ---------------------------------------------------------------------
        // Question: Finding the First Element Meeting a Condition in an Array
        // Write a C# program to find and display the first element greater than 50 in an integer array.
        // Hint: Use the Array.Find() method with a condition-checking function (Predicate) to find the first element greater than 50 in the array.
        // Define a condition-checking function that returns true if the element is greater than 50.

        int[] numbers1 = { 10, 20, 30, 40, 55, 60, 70, 80 };
        Predicate<int> isGreaterThan50 = (int num) => num > 50;
        int firstElementGreaterThan50 = Array.Find(numbers1, isGreaterThan50);
        if (firstElementGreaterThan50 != 0)
        {
            Console.WriteLine($"First element greater than 50: {firstElementGreaterThan50}");
        }
        else
        {
            Console.WriteLine("No element greater than 50 found in the array.");
        }

        // ---------------------------------------------------------------------
        // Question: Find the First Element Greater Than 10
        // Write a C# program that finds the first element greater than 10 in an integer array and displays it.
        // Hint: Define an array of integers. Use Array.Find() method with a condition-checking function to find the first element greater than 10.
        // Define a condition-checking function that returns true if the element is greater than 10.

        int[] numbers2 = { 5, 8, 12, 15, 20 };
        Predicate<int> isGreaterThan10 = (int num) => num > 10;
        int firstElementGreaterThan10 = Array.Find(numbers2, isGreaterThan10);
        if (firstElementGreaterThan10 != 0)
        {
            Console.WriteLine($"First element greater than 10: {firstElementGreaterThan10}");
        }
        else
        {
            Console.WriteLine("No element greater than 10 found in the array.");
        }

        // ---------------------------------------------------------------------
        // Question: Find the First Negative Number
        // Write a C# program to find the first negative number in an array of integers and display it.
        // Hint: Define an array of integers. Use Array.Find() method with a condition-checking function to find the first negative number.
        // Define a condition-checking function that returns true if the element is negative.

        int[] numbers3 = { 5, 8, -3, 12, 0, -7 };
        Predicate<int> isNegative = (int num) => num < 0;
        int firstNegativeNumber = Array.Find(numbers3, isNegative);
        if (firstNegativeNumber != 0)
        {
            Console.WriteLine($"First negative number: {firstNegativeNumber}");
        }
        else
        {
            Console.WriteLine("No negative number found in the array.");
        }
    }
}
