//Болдин
/*
Реализовать метод проверки логина и пароля. На вход подается логин и пароль.
На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains).
Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль,
программа пропускает его дальше или не пропускает. С помощью цикла do while ограничить ввод пароля тремя попытками.
*/
using System;

namespace HW4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LogIn() == true ? "Заходи":"Чет не так");
            Console.ReadKey();
        }

        static bool LogIn()
        {
            string log, pass;
            int i = 0;
            bool passed = false;
            do
            {
                //log = Console.ReadLine();
                //pass = Console.ReadLine();
                log = "root";
                pass = "GeekBrains";
                passed = log == "root" && pass == "GeekBrains" ? true : false;
                i++;
            } while (i < 3);
            return passed;
        }
    }
}
