using System;
using System.Collections.Generic;

namespace FibonacciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Enter Count Of Your Fibonacci Numbers : ");
            string countOfNumbers = Console.ReadLine();
            Console.ResetColor();
            bool isValid = Validation.ValidateCountOfNumbers(countOfNumbers);
            if (isValid)
            {
                var fibonacciNumbers = new List<int> { 1, 1 };

                while (fibonacciNumbers.Count < int.Parse(countOfNumbers)) {
                    int previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
                    int previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];
                    fibonacciNumbers.Add(previous + previous2);
                }
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Numbers : ");
                foreach (var item in fibonacciNumbers) {
                    Console.WriteLine(item);
                }
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("------------------------");
                Console.WriteLine("Run Program Again and Enter a Valid Number");
                Console.ResetColor();
            }
        }
    }
}
