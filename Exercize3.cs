\\ адайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

using System;

class Program
{
    static void PrintArrayReverse(int[] array, int index)
    {
        if (index >= 0)
        {
            Console.WriteLine(array[index]);
            PrintArrayReverse(array, index - 1);
        }
    }

    static void Main(string[] args)
    {
        int[] array = { 15, 5, 7, 10, 3 }; // Произвольный массив

        PrintArrayReverse(array, array.Length - 1);
    }
}