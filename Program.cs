using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("КАЛЬКУЛЯТОР");

                Console.WriteLine("Введите первое число:");
                int nam1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введите первое число:");
                int nam2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите знак:");
                string s = Console.ReadLine();

                if (s == "+")
                {
                    Console.WriteLine("Вывод:", nam1 + nam2);
                }
                else if (s == "-")
                {

                    Console.WriteLine("Вывод:", nam1 - nam2);
                }
                else if (s == "/")
                {
                    if (nam1 == 0 || nam2 == 0) { Console.WriteLine("Деление на 0 невозможно"); }
                    else
                    {
                        Console.WriteLine("Вывод:", nam1 / nam2);
                    }

                }
                else if (s == "*")
                {

                    Console.WriteLine("Вывод:", nam1 * nam2);
                }
                else if (s==">")
                {
                    Console.WriteLine("Вывод:", nam1 > nam2);
                }
                else if ( s=="<")
                {
                    Console.WriteLine("Вывод:", nam1 < nam2);
                }
            } catch (Exception ex) { Console.WriteLine(ex.Message); }
          
        }
    }
}
