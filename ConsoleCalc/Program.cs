﻿using System;

namespace SimpleCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input first ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input second ");
            double b = Convert.ToDouble(Console.ReadLine());
            double resAdd = a + b;
            Console.WriteLine("Result addition = " + resAdd);
            double resSub = a - b;
            Console.WriteLine("Result subtraction = " + resSub);
            Console.ReadKey();
        }
    }
}
