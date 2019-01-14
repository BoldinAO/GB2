//Болдин
/*
a) Разработать рекурсивный метод, который выводит на экран числа от a до b (a<b);
б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.
*/
using System;


namespace HW7
{
    class Program
    {
        static void Main(string[] args)
        {
            Rec(1, 10);
            RecCount(1, 10);
            Console.ReadKey();
        }

        public static void Rec(int a, int b)
        {
            if(a <= b)
            {
                Console.WriteLine(a);
                Rec(++a, b);
            }
        }

        public static void RecCount(int a, int b, int summ = 0)
        {
            if (a <= b)
            {
                RecCount(++a, b, summ: (summ + a - 1));
            } else { Console.WriteLine(summ); }
        }
    }
}
