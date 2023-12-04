using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Парные числа от 1 к 20 создают ряд: ");
        int i = 2;
        while (i <= 20)
        {
            Console.Write(i + " ");
            i += 2;
        }
    }
}