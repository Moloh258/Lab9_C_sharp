using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число заданий в диапозоне 10-40");
            int a = Convert.ToInt32(Console.ReadLine());
            switch (a / 10)
            {
                case 2:
                    Console.Write("Двадцать ");
                    break;
                case 3:
                    Console.Write("Тридцать ");
                    break;
                case 4:
                    Console.Write("Сорок ");
                    break;
            }
            if (a / 10 == 1)
                switch (a)
                {
                    case 10:
                        Console.Write("Десять");
                        break;
                    case 11:
                        Console.Write("Одиннадцать");
                        break;
                    case 12:
                        Console.Write("Двенадцать");
                        break;
                    case 13:
                        Console.Write("Тринадцать");
                        break;
                    case 14:
                        Console.Write("Четырнадцать");
                        break;
                    case 15:
                        Console.Write("Пятнадцать");
                        break;
                    case 16:
                        Console.Write("Шестнадцать");
                        break;
                    case 17:
                        Console.Write("Семнадцать");
                        break;
                    case 18:
                        Console.Write("Восемнадцать");
                        break;
                    case 19:
                        Console.Write("Девятнадцать");
                        break;
                }
            else
            {
                switch (a%10)
                {
                    case 1:
                        Console.Write("одно");
                        break;
                    case 2:
                        Console.Write("два");
                        break;
                    case 3:
                        Console.Write("три");
                        break;
                    case 4:
                        Console.Write("четыре");
                        break;
                    case 5:
                        Console.Write("пять");
                        break;
                    case 6:
                        Console.Write("шесть");
                        break;
                    case 7:
                        Console.Write("семь");
                        break;
                    case 8:
                        Console.Write("восемь");
                        break;
                    case 9:
                        Console.Write("девять");
                        break;
                }
            }
        }
    }
}
