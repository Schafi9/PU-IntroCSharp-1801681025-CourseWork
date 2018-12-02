using System;

namespace TangentsCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задача 4/ 213 ж) от учебника!");
            double result = 0.0;

            for (int i = 1; i <= 100; i++)
            {
                double tan = Math.Tan(i);
                result += tan;
            }

            Console.WriteLine("{0}", result);
        }
    }
}
