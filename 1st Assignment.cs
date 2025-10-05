using System;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== C# Assignment 1 =====\n");

            // Running all programs one by one
            new EvenOddChecker().Run();
            new SimpleCalculator().Run();
            new GradeEvaluator().Run();
            new SumOfNaturalNumbers().Run();
            new MultiplicationTable().Run();
            new FactorialCalculator().Run();
            new ReverseNumber().Run();
            new ArrayMaxMin().Run();
            new ArrayEvenOddCount().Run();
            new ArraySearchElement().Run();

            Console.WriteLine("\n===== All Programs Executed Successfully =====");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }

    // 1. Even or Odd Checker
    class EvenOddChecker
    {
        public void Run()
        {
            Console.WriteLine("---- Program 1: Even or Odd Checker ----");
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
                Console.WriteLine($"{num} is Even.\n");
            else
                Console.WriteLine($"{num} is Odd.\n");
        }
    }

    // 2. Simple Calculator
    class SimpleCalculator
    {
        public void Run()
        {
            Console.WriteLine("---- Program 2: Simple Calculator ----");
            Console.Write("Enter first number: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter second number: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Choose operation (+, -, *, /): ");
            char op = Convert.ToChar(Console.ReadLine());

            switch (op)
            {
                case '+': Console.WriteLine($"Result = {a + b}\n"); break;
                case '-': Console.WriteLine($"Result = {a - b}\n"); break;
                case '*': Console.WriteLine($"Result = {a * b}\n"); break;
                case '/': 
                    if (b != 0) Console.WriteLine($"Result = {a / b}\n");
                    else Console.WriteLine("Division by zero not allowed.\n");
                    break;
                default: Console.WriteLine("Invalid operation!\n"); break;
            }
        }
    }

    // 3. Grade Evaluator
    class GradeEvaluator
    {
        public void Run()
        {
            Console.WriteLine("---- Program 3: Grade Evaluator ----");
            Console.Write("Enter marks (0–100): ");
            int marks = Convert.ToInt32(Console.ReadLine());

            if (marks >= 85) Console.WriteLine("Grade: A\n");
            else if (marks >= 70) Console.WriteLine("Grade: B\n");
            else if (marks >= 55) Console.WriteLine("Grade: C\n");
            else if (marks >= 40) Console.WriteLine("Grade: D\n");
            else Console.WriteLine("Grade: F\n");
        }
    }

    // 4. Sum of Natural Numbers
    class SumOfNaturalNumbers
    {
        public void Run()
        {
            Console.WriteLine("---- Program 4: Sum of Natural Numbers ----");
            Console.Write("Enter a number (n): ");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= n; i++)
                sum += i;

            Console.WriteLine($"Sum of numbers from 1 to {n} = {sum}\n");
        }
    }

    // 5. Multiplication Table
    class MultiplicationTable
    {
        public void Run()
        {
            Console.WriteLine("---- Program 5: Multiplication Table ----");
            Console.Write("Enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"\nMultiplication Table of {n}:");
            for (int i = 1; i <= 10; i++)
                Console.WriteLine($"{n} x {i} = {n * i}");
            Console.WriteLine();
        }
    }

    // 6. Factorial Calculator
    class FactorialCalculator
    {
        public void Run()
        {
            Console.WriteLine("---- Program 6: Factorial Calculator ----");
            Console.Write("Enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int fact = 1;
            int i = 1;

            while (i <= n)
            {
                fact *= i;
                i++;
            }

            Console.WriteLine($"Factorial of {n} = {fact}\n");
        }
    }

    // 7. Reverse a Number
    class ReverseNumber
    {
        public void Run()
        {
            Console.WriteLine("---- Program 7: Reverse a Number ----");
            Console.Write("Enter an integer: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int reversed = 0;

            while (num != 0)
            {
                int digit = num % 10;
                reversed = reversed * 10 + digit;
                num /= 10;
            }

            Console.WriteLine($"Reversed Number = {reversed}\n");
        }
    }

    // 8. Array - Find Maximum and Minimum
    class ArrayMaxMin
    {
        public void Run()
        {
            Console.WriteLine("---- Program 8: Array - Find Maximum and Minimum ----");
            int[] arr = new int[10];
            Console.WriteLine("Enter 10 integers:");

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Element {i + 1}: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            int max = arr[0], min = arr[0];
            foreach (int num in arr)
            {
                if (num > max) max = num;
                if (num < min) min = num;
            }

            Console.WriteLine($"Maximum = {max}, Minimum = {min}\n");
        }
    }

    // 9. Array - Count Even and Odd Numbers
    class ArrayEvenOddCount
    {
        public void Run()
        {
            Console.WriteLine("---- Program 9: Array - Count Even and Odd Numbers ----");
            int[] arr = new int[10];
            Console.WriteLine("Enter 10 integers:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Element {i + 1}: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            int evenCount = 0, oddCount = 0;
            foreach (int num in arr)
            {
                if (num % 2 == 0) evenCount++;
                else oddCount++;
            }

            Console.WriteLine($"Even numbers: {evenCount}, Odd numbers: {oddCount}\n");
        }
    }

    // 10. Array - Search Element
    class ArraySearchElement
    {
        public void Run()
        {
            Console.WriteLine("---- Program 10: Array - Search Element ----");
            Console.Write("Enter size of array: ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];

            for (int i = 0; i < size; i++)
            {
                Console.Write($"Element {i + 1}: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Enter number to search: ");
            int search = Convert.ToInt32(Console.ReadLine());

            bool found = false;
            foreach (int num in arr)
            {
                if (num == search)
                {
                    found = true;
                    break;
                }
            }

            if (found)
                Console.WriteLine($"{search} exists in the array.\n");
            else
                Console.WriteLine($"{search} not found in the array.\n");
        }
    }
}
