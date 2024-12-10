using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        public static int Input(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }


        public static string Value(int day)
        {


            switch (day)
            {
                case 1: return "Понедельник";
                case 2: return "вторник";
                case 3: return "среда";
                case 4: return "четверг";
                case 5: return "пятница";
                case 6: return "суббоа";
                case 7: return "воскресенье";
                default: return "Некоректный";

            }
        }

        static void Main(string[] args)
        {
            int day = Input("day= ");
            string day1 = Value(day);
            Console.Write(day1);
            Console.ReadKey();
        }
    }
}