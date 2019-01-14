//Болдин
/*
С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.
*/
using System;
using System.Collections.Generic;

namespace HW3
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            List<int> arr = new List<int>();
            do
            {
                Console.WriteLine("Введите число. Для выхода введите 0.");
                arr.Add(int.Parse(Console.ReadLine()));
            } while (!arr.Contains(0));
            foreach (int c in arr)
            {
                if(c % 2 == 1 && c > 0) { count += c; }
            }
            Console.WriteLine($"Сумма нечетных положительных чисел = {count}");
            Console.ReadKey();
        }
    }
}
