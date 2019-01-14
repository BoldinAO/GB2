//Болдин
/*
Написать метод подсчета количества цифр числа.
*/
using System;

namespace HW2
{
    class Program
    {
        static void Main(string[] args)
        {
            double n;
            Console.Write("Для подсчета введите любое число: ");
            n = double.Parse(Console.ReadLine());
            Console.Write($"Введенное число содержит {CountNum(n)} цифр" + (CountNum(n) == 1 ? ("у"): (CountNum(n) < 5 && CountNum(n) > 1) ? ("ы"):("")) + ".");
            Console.ReadKey();
        }

        static int CountNum(double num)
        {
            int i = 0;
            string s = num.ToString();
            foreach (var c in s)
            {
                if(c == '.' || c == ',') { continue; }
                i++;
            }
            return i;
        }
    }
}
