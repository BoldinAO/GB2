//Болдин
/*
 Написать метод, возвращающий минимальное из трех чисел.
*/
using System;

namespace HW1
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, z;
            Console.Write("Введите значение X: ");
            x = double.Parse(Console.ReadLine());
            Console.Write("Введите значение Y: ");
            y = double.Parse(Console.ReadLine());
            Console.Write("Введите значение Z: ");
            z = double.Parse(Console.ReadLine());
            Console.Write($"Минимальное число = {GetMin(x, y, z)}");
            Console.ReadKey();
        }

        static double GetMin(double x1, double y1, double z1)
        {
            double min;
            return min = x1 < y1 ? x1 : y1 < z1 ? y1 : z1;
        }
    }
}
