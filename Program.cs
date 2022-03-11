using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace App4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число, для определения факториала");
            int n = Convert.ToInt32(Console.ReadLine());
            SumAsync(n);

            Console.ReadKey();
        }

        static void Factorial(int n)
        {
            int s = 1;
            for (int i = 1; i <= n; i++)
            {
                s *= i;
                Thread.Sleep(10);
            }
            Console.WriteLine($"Факториал заданного числа равен: {s}");
        }

        static async void SumAsync(int n)
        {
            await Task.Run(() => Factorial(n));
        }

    }
}