//Болдин
/*
*Написать программу подсчета количества «Хороших» чисел в диапазоне от 1 до 1 000 000 000.
Хорошим называется число, которое делится на сумму своих цифр.
Реализовать подсчет времени выполнения программы, используя структуру DateTime.
*/
using System;

namespace HW6
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime oldTime = DateTime.Now;
            GoodNum();
            TimeSpan timeWork = DateTime.Now - oldTime;
            Console.Write($"Время работы = {timeWork}");
            Console.ReadKey();
        }

        public static void GoodNum()
        {
            int summ = 0;
            for(int i = 1; i <= 1000000000; i++)
            {
                for(int n = 1; i <= n; n++)
                {
                    summ += n;
                }
                if(summ % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
