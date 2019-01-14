//Болдин
/*
а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает,
нужно ли человеку похудеть, набрать вес или все в норме;
б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.
*/
using System;

namespace HW5
{
    class Program
    {
        static void Main(string[] args)
        {
            Person firstP = new Person();
            Console.Write("Введите массу тела в кг: ");
            firstP.M = double.Parse(Console.ReadLine());
            Console.Write("Введите рост в метрах: ");
            firstP.H = double.Parse(Console.ReadLine());
            firstP.Info(firstP.M, firstP.H);
        }
    }
    class Person
    {
        private double h, m, imt;

        public double M
        {
            get { return m; }
            set { m = value; }
        }
        public double H
        {
            get { return h; }
            set { h = value; }
        }
        private double IMT
        {
            get { return imt; }
            set { imt = value; }
        }
        public void Info(double getM, double getH)
        {
            IMT = m / (h * h);
            GetInfo();
        }
        private void GetInfo()
        {
            double normM = H - 100;
            if(M < normM)
            {
                Console.WriteLine("Набрать вес " + (normM - M) + " кг");
            } else if (M > normM)
            {
                Console.Write($"Похудеть " + (M - normM) + "кг");
            } else
            {
                Console.Write($"Все ОК");
            }
            Console.ReadKey();
        }
    }
}
