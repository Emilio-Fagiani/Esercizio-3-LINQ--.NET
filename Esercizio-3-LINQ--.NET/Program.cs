
using Esercizio_3_LINQ__.NET;
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        RandomNumber rm = new RandomNumber();
        List<int> randomIntegers = rm.GenerateRandomNum(5);

        Console.WriteLine("Sort");
        randomIntegers.Sort();

         foreach (int num in randomIntegers)
        {
            Console.WriteLine(num);
        }
        Console.WriteLine("______");
        Console.WriteLine();
        Console.WriteLine("Desc");

        randomIntegers.Reverse();

        foreach (int num in randomIntegers)
        {
            Console.WriteLine(num);
        }
    }
}
