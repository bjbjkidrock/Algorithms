﻿namespace Fibonacci
{
    using System;

    public class Fibonacci
    {
        private static long[] fibonacci;

        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            fibonacci = new long[n + 1];

            //Console.WriteLine(FibonacciIteration(n));
            Console.WriteLine(FibonacciRecursion(n));
        }

        private static long FibonacciIteration(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                if (i == 1 || i == 2)
                {
                    fibonacci[i] = 1;
                }
                else
                {
                    fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
                }
            }

            return fibonacci[n];
        }

        private static long FibonacciRecursion(int n)
        {
            if (fibonacci[n] != 0)
            {
                return fibonacci[n];
            }

            if (n == 1 || n == 2)
            {
                fibonacci[n] = 1;
                return 1;
            }

            fibonacci[n] = FibonacciRecursion(n - 1) + FibonacciRecursion(n - 2);
            return fibonacci[n];
        }
    }
}
