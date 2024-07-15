using System;

class Program
{
    static void Main()
    {
        // Part 1: Print numbers 1 to 10
        int num1 = 1;
        while (num1 <= 10)
        {
            Console.WriteLine(num1);
            num1++;
        }
        Console.WriteLine(); // Adding a blank line for separation

        // Part 2: Print numbers 10 to 1
        int num2 = 10;
        while (num2 >= 1)
        {
            Console.WriteLine(num2);
            num2--;
        }
        Console.WriteLine();

        // Part 3: Print even numbers from 1 to 10
        int num3 = 2; // Start from the first even number
        while (num3 <= 10)
        {
            Console.WriteLine(num3);
            num3 += 2; // Increment by 2 to get the next even number
        }
        Console.WriteLine();

        // Part 4: Print odd numbers from 1 to 10
        int num4 = 1; // Start from the first odd number
        while (num4 <= 10)
        {
            Console.WriteLine(num4);
            num4 += 2; // Increment by 2 to get the next odd number
        }
        Console.WriteLine();

        // Part 5: Multiplication table of a number
        Console.Write("Enter the number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        int i = 0;
        while (i <= 10)
        {
            int result = number * i;
            Console.WriteLine($"{number} * {i} = {result}");
            i++;
        }
        Console.WriteLine();

        // Part 6: Factorial of a number
        Console.Write("Enter the number: ");
        int numToFactorial = Convert.ToInt32(Console.ReadLine());
        int factorial = 1;
        int j = 1;
        while (j <= numToFactorial)
        {
            factorial *= j;
            j++;
        }
        Console.WriteLine($"The factorial of {numToFactorial} is: {factorial}");
        Console.WriteLine();

        // Part 7: Sum of series 1+2+3+...+n
        Console.Write("Enter the number: ");
        int numToSum = Convert.ToInt32(Console.ReadLine());
        int sum = 0;
        int k = 1;
        while (k <= numToSum)
        {
            Console.Write(k);
            sum += k;
            if (k < numToSum)
            {
                Console.Write(" + ");
            }
            else
            {
                Console.Write($" = {sum}");
            }
            k++;
        }
        Console.WriteLine();
        Console.WriteLine();

        // Part 8: Multiplication table horizontally from 1 to n
        Console.Write("Input upto the table number starting from 1 : ");
        int tableNumber = Convert.ToInt32(Console.ReadLine());
        int m = 1;
        while (m <= 10)
        {
            int n = 1;
            while (n <= tableNumber)
            {
                Console.Write($"{n}x{m} = {n * m}\t");
                n++;
            }
            Console.WriteLine();
            m++;
        }
        Console.WriteLine();

        // Part 9: Right angle triangle with numbers
        Console.Write("Input number of rows : ");
        int rows = Convert.ToInt32(Console.ReadLine());
        int p = 1;
        while (p <= rows)
        {
            int q = 1;
            while (q <= p)
            {
                Console.Write(q);
                q++;
            }
            Console.WriteLine();
            p++;
        }
        Console.WriteLine();

        // Part 10: Right angle triangle with asterisks
        Console.Write("Input number of rows : ");
        int rowsAsterisk = Convert.ToInt32(Console.ReadLine());
        int r = 1;
        while (r <= rowsAsterisk)
        {
            int s = 1;
            while (s <= r)
            {
                Console.Write("*");
                s++;
            }
            Console.WriteLine();
            r++;
        }
        Console.WriteLine();

        // Part 11: Pyramid with numbers increasing by 1
        Console.Write("Input number of rows : ");
        int rowsPyramid = Convert.ToInt32(Console.ReadLine());
        int t = 1;
        int currentNumber = 1;
        while (t <= rowsPyramid)
        {
            int u = 1;
            while (u <= rowsPyramid - t)
            {
                Console.Write(" ");
                u++;
            }
            int v = 1;
            while (v <= t)
            {
                Console.Write($"{currentNumber} ");
                currentNumber++;
                v++;
            }
            Console.WriteLine();
            t++;
        }
        Console.WriteLine();
    }
}
