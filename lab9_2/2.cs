using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сторону света (С, З, Ю, В)");
            char ch;
            ch = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Введите команду (-1, 0, 1)");
            int a = Convert.ToInt32(Console.ReadLine());
            switch (ch)
            {
                case 'С': switch (a)
                    {
                        case -1: Console.WriteLine("Робот направлен на восток");
                            break;
                        case 0: Console.WriteLine("Робот направлен на север");
                            break;
                        case 1: Console.WriteLine("Робот направлен на запад");
                            break;
                    }break;
                case 'З': switch (a)
                    {
                        case -1: Console.WriteLine("Робот направлен на север");
                            break;
                        case 0: Console.WriteLine("Робот направлен на запад");
                            break;
                        case 1: Console.WriteLine("Робот направлен на юг");
                            break;
                    }
                    break;
                case 'Ю': switch (a)
                    {
                        case -1: Console.WriteLine("Робот направлен на запад");
                            break;
                        case 0: Console.WriteLine("Робот направлен на юг");
                            break;
                        case 1: Console.WriteLine("Робот направлен на восток");
                            break;
                    }
                    break;
                case 'В': switch (a)
                    {
                        case -1: Console.WriteLine("Робот направлен на юг");
                            break;
                        case 0: Console.WriteLine("Робот направлен на восток");
                            break;
                        case 1: Console.WriteLine("Робот направлен на север");
                            break;
                    }
                    break;
            }

        }
    }
}
