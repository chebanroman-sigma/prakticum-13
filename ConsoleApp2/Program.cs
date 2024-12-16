using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {/// <summary>
     /// Задача 2. По номеру месяца вывести его название.
     /// </summary>
     /// <param name="args"></param>
     /// 
        public static int Input(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }
        static void Value()
        { 
           
            int n = Input("Номер месяца: ");
            string Luma1 = Luma(n);
            Console.WriteLine($"Результат:\t{Luma1}");
            Console.ReadKey();
        }
        public static string Luma(int n)
        {
         
            switch (n)
            {
                case 1: return "январь";
                case 2: return "февраль";
                case 3: return "март";
                case 4: return "апрель";
                case 5: return "май";
                case 6: return "июнь";
                case 7: return "июль";
                case 8: return "август";
                case 9: return "сентябрь";
                case 10: return "октябрь";
                case 11: return "ноябрь";
                case 12: return "декабрь";
                default: return "Некоректно";
            }
           
        }

        static void Main(string[] args)
        {
            Value();
        }
    }
}
