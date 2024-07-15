using System;

class Program
{
    // Part 1: Displaying a Welcome Message
    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to our program!");
    }

    // Part 2: Personalized Welcome Message
    static void PersonalizedWelcomeMessage(string name)
    {
        Console.WriteLine($"Welcome, {name}!");
    }

    // Part 3: Calculating the Sum of Two Numbers
    static int CalculateSum(int num1, int num2)
    {
        return num1 + num2;
    }

    // Part 4: Counting Spaces in a String
    static int CountSpaces(string input)
    {
        int count = 0;
        foreach (char c in input)
        {
            if (c == ' ')
            {
                count++;
            }
        }
        return count;
    }

    // Part 5: Calculating the Sum of Elements in an Array
    static int CalculateArraySum(int[] array)
    {
        int sum = 0;
        foreach (int num in array)
        {
            sum += num;
        }
        return sum;
    }

    // Part 6: Swapping Two Integer Numbers
    static void SwapNumbers(ref int num1, ref int num2)
    {
        int temp = num1;
        num1 = num2;
        num2 = temp;
        Console.WriteLine($"After swapping: num1 = {num1}, num2 = {num2}");
    }

    // Part 7: Calculating Exponentiation
    static void CalculateExponent(int baseNum, int exponent)
    {
        int result = (int)Math.Pow(baseNum, exponent);
        Console.WriteLine($"{baseNum} to the power of {exponent} is {result}");
    }

    // Part 8: Displaying the Fibonacci Sequence
    static void DisplayFibonacciSequence(int terms)
    {
        int first = 0, second = 1, next;
        Console.WriteLine("Fibonacci Sequence:");
        for (int i = 0; i < terms; i++)
        {
            Console.Write(first + " ");
            next = first + second;
            first = second;
            second = next;
        }
        Console.WriteLine();
    }

    // Part 9: Checking Prime Numbers
    static void CheckPrimeNumber(int num)
    {
        bool isPrime = true;
        if (num <= 1)
        {
            isPrime = false;
        }
        else
        {
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
        }
        Console.WriteLine($"{num} is {(isPrime ? "a prime number" : "not a prime number")}");
    }

    // Part 10: Calculating the Sum of Individual Digits
    static void CalculateDigitSum(int num)
    {
        int sum = 0;
        while (num != 0)
        {
            sum += num % 10;
            num /= 10;
        }
        Console.WriteLine($"The sum of the digits is {sum}");
    }

    // Part 11: Testing Named Parameters in C#
    static void DisplayInfo(string name, int age)
    {
        Console.WriteLine($"Name: {name}, Age: {age}");
    }

    // Part 12: Testing Out Parameters in C#
    static void GetSquareRoot(double num, out double result)
    {
        result = Math.Sqrt(num);
    }

    // Part 13: Testing Default or Optional Parameters in C#
    static void GreetUser(string name, string greetingMessage = "Hello")
    {
        Console.WriteLine($"{greetingMessage}, {name}!");
    }

    static void Main()
    {
        // Part 1
        DisplayWelcomeMessage();

        // Part 2
        PersonalizedWelcomeMessage("Alice");

        // Part 3
        int sum = CalculateSum(3, 4);
        Console.WriteLine($"Sum: {sum}");

        // Part 4
        int spaceCount = CountSpaces("Hello World! How are you?");
        Console.WriteLine($"Number of spaces: {spaceCount}");

        // Part 5
        int[] array = { 1, 2, 3, 4, 5 };
        int arraySum = CalculateArraySum(array);
        Console.WriteLine($"Array sum: {arraySum}");

        // Part 6
        int num1 = 5, num2 = 10;
        SwapNumbers(ref num1, ref num2);

        // Part 7
        CalculateExponent(2, 3);

        // Part 8
        DisplayFibonacciSequence(10);

        // Part 9
        CheckPrimeNumber(29);

        // Part 10
        CalculateDigitSum(12345);

        // Part 11
        DisplayInfo(name: "John", age: 30);

        // Part 12
        GetSquareRoot(16, out double sqrtResult);
        Console.WriteLine($"Square root: {sqrtResult}");

        // Part 13
        GreetUser("Bob");
    }
}
