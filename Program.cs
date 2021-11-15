using NLog;
using System;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        private static readonly Logger Log = LogManager.GetCurrentClassLogger();
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("КАЛЬКУЛЯТОР");
                Thread.Sleep(4000);
                Console.WriteLine("Введите первое число:");
                int nam1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введите первое число:");
                int nam2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите знак:");
                string s = Console.ReadLine();

                if (s == "+")
                {
                    Console.WriteLine("Вывод:", nam1+nam2);
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
                else if (s == ">=")
                {
                    Console.WriteLine("Вывод:", nam1 >= nam2);
                }
                else if (s == "<=")
                {
                    Console.WriteLine("Вывод:", nam1 <= nam2);
                }
                else if (s=="^")
                {
                    Console.WriteLine("Вывод:", Math.Pow(nam1, nam2));
                }
                else if ( s=="fak")
                {
                    for (int i = 1; i <= nam1; i++) 
                    {
                        nam2 = nam2 * i;
                    }
                    Console.WriteLine("Факториал:", nam1, "Равен:", nam2);
                }
                Log.Info("Log");
                Log.Error("Log");
                Log.Debug("Log");
            } catch (Exception ex) { Console.WriteLine(ex.Message);
                Log.Info("Log");
                Log.Error("Log");
                Log.Debug("Log");
            }
          
        }
    }
}
