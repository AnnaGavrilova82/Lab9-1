using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9_1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true) 
            {
                double a=0;
                double b=0;
                try
                {
                    Console.Write("Введите первое число: ");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите второе число: ");
                    b = Convert.ToDouble(Console.ReadLine());

                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Ошибка! ");
                    Console.ReadKey();
                    continue;
                }
            
            Console.WriteLine("Введите код вычисления: ");
            Console.WriteLine("1 - Сложение ");
            Console.WriteLine("2 - Вычитание ");
            Console.WriteLine("3 - Умножение ");
            Console.WriteLine("4 - Деление ");
            string s = Console.ReadLine();
            Console.WriteLine("Ваш выбор: {0}", s);

            switch (s)
            { 
                case "1":
                    {
                        a += b;
                        Console.WriteLine("Результат: {0}", a);
                        break;
                    }
                case "2":
                    {
                        a -= b;
                        Console.WriteLine("Результат: {0}", a);
                        break;
                    }
                case "3":
                    {
                        a *= b;
                        Console.WriteLine("Результат: {0}", a);
                        break;
                    }
                case "4":
                    {
                        a /= b;
                        Console.WriteLine("Результат: {0}", a);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Нет операций с указанным номером");
                        break;
                    }
            }



            Console.ReadKey();
            }
        }
    }
}
