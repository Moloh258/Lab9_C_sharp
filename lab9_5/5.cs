using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер года: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Год ");
            a = (a - 1984) % 60 + 1;
            switch (((a - 1) % 10) / 2 + 1)
            {
                case 1: Console.Write("зелёно");
                    break;
                case 2: Console.Write("красно");
                    break;
                case 3: Console.Write("жёлто");
                    break;
                case 4: Console.Write("бело");
                    break;
                case 5: Console.Write("чёрно");
                    break;
            }
            switch ((a - 1) % 12 + 1)
            {
                case 3: Console.Write("го ");
                    break;
                case 4: Console.Write("го ");
                    break;
                case 5: Console.Write("го ");
                    break;
                default: Console.Write("й ");
                    break;
            }
            switch ((a - 1) % 12 + 1)
            {
                case 1: Console.Write("крысы");
                    break;
                case 2: Console.Write("коровы");
                    break;
                case 3: Console.Write("тигра");
                    break;
                case 4: Console.Write("зайца");
                    break;
                case 5: Console.Write("дракона");
                    break;
                case 6: Console.Write("змеи");
                    break;
                case 7: Console.Write("лошади");
                    break;
                case 8: Console.Write("овцы");
                    break;
                case 9: Console.Write("обезьяны");
                    break;
                case 10: Console.Write("курицы");
                    break;
                case 11: Console.Write("собаки");
                    break;
                case 12: Console.Write("свиньи");
                    break;
            }
        }
    }
}
