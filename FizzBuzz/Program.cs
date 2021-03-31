using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            // allow the user to give us upperBound, lowerBound (think validate)
            // allow the user to set condition for multiple 7, 11
            // count from 0 to 100, and print eaach number per line
            // if number is multiple of 3, print fizz
            // if number is multiple of 5, print buzz
            // if number is multiple of both, print fizzbuzz

            // for (int i = 0; i <= 100; i++)
            // {
            //     Console.Write($"{i} ");
            //     if (i % 3 == 0 && i != 0)
            //     {
            //         Console.Write("Fizz");
            //     }
            //     if (i % 5 == 0 && i != 0)
            //     {
            //         Console.Write("Buzz");
            //     }
            //     Console.Write("\n");
            // }
            var run = new Program();
            run.FizzBuzz();
        }

        private void FizzBuzz()
        {
            int start = ReadIntFromConsole("Enter a starting bound number:");
            int stop = ReadIntFromConsole("Enter a stop bound number:");
            int inc = ReadIntFromConsole("Enter an increment number:");
            int mult1 = ReadIntFromConsole("Enter a multiple to check:");
            int mult2 = ReadIntFromConsole("Enter a multiple to check:");
            LoopThroughBounds(start, stop, inc, mult1, mult2);
        }

        private void LoopThroughBounds(int start = 0, int stop = 100, int inc = 1, int mult1 = 3, int mult2 = 5)
        {
            if (start > stop)
            {
                var tmp = start;
                start = stop;
                stop = tmp;
            }
            for (var i = start; i <= stop; i += inc)
            {
                PrintNumber(i, mult1, mult2);
            }
        }

        private int ReadIntFromConsole(string msg = "Enter a number:")
        {
            Console.WriteLine(msg);
            return Int32.Parse(Console.ReadLine());
        }

        private void PrintNumber(int i, int m1, int m2)
        {
            if (!IsMultipleOf(i, m1) && !IsMultipleOf(i, m2))
            {
                WriteToConsole($"{i}");
            }
            if (IsMultipleOf(i, m1))
            {
                WriteToConsole("Fizz");
            }
            if (IsMultipleOf(i, m2))
            {
                WriteToConsole("Buzz");
            }
            WriteToConsole("\n");
        }

        private bool IsMultipleOf(int i, int mul)
        {
            return i % mul == 0 && i != 0;
        }

        private void WriteToConsole(string msg)
        {
            Console.Write(msg);
        }
    }
}
