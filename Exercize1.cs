\\ Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.

using System;

class Program
{
    static void PrintNaturalNumbers(int m, int n)
    {
        if (m <= n)
        {
            Console.WriteLine(m);
            PrintNaturalNumbers(m + 1, n);
        }
    }

    static void Main(string[] args)
    {
        // Задайте значения M и N
        int m = 1;
        int n = 10;

        PrintNaturalNumbers(m, n);
    }
}
