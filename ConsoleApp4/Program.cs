using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {/// <summary>
     /// Задача 3. По номеру месяца вывести название времени года.
     /// </summary>
     /// <param name="message"></param>
     /// <returns></returns>

        public static int Input(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }
        public static string Value(int number)
        {
            switch (number)
            {
                case 12: return "зима";
                case 1: return "зима";
                case 2: return "зима";
                case 3: return "весна";
                case 4: return "весна";
                case 5: return "весна";
                case 6: return "лето";
                case 7: return "лето";
                case 8: return "лето";
                case 9: return "осень";
                case 10: return "осень";
                case 11: return "осень";
                default: return "Некоретно";

            }
        }
        static void Main(string[] args)
        {
            int number = Input("номер месяца: ");
            string number1 = Value(number);
            Console.Write($"это:\t{number1}");
            Console.ReadKey();


        }
    }
}
