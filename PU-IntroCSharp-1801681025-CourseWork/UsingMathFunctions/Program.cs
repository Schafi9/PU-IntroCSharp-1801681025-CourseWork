﻿using System;

namespace UsingMathFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задача 2/Тест 1 - 2 II) от учебника!");
            Console.WriteLine("Vuvedi Stoinost na beta i y, za da reshish zadachata!");
            double result = 0;
            Console.Write("beta= ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("y= ");
            int y = int.Parse(Console.ReadLine());
            result = b + (Math.Pow(Math.Sin(0), 2) * (Math.Pow(Math.PI, 4)) / (Math.Sqrt(Math.Cos(6)) / 5) + Math.Abs(Math.Atan(y)));
            Console.WriteLine(result);
        }
    }
}
