using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {/// <summary>
     /// Задача 4. Вывести название предмета по введенной первой букве: ф – физика, м – математика, и – история, г – география, б – биология.
     /// </summary>
     /// <param name="args"></param>
        
        public static string Input(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }
        public static string Value(string letter)
        {
            switch(letter.ToLower())
            {
                case "б":return "биология";
                case "ф": return "физика";
                case "м": return "математика";
                case "и": return "история";
                case "г": return "география";
                default: return "Некоретно";
            }

        }
        
        
        
        
        static void Main(string[] args)
        {
            string letter = Input("Первая буква предмета: ");
            string letter1=Value(letter);

            Console.Write($"Предмет:\t{letter1}");
            Console.ReadKey();
        }
    }
}
