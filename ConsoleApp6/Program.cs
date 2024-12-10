using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{/// <summary>
/// Задача 5. Дан признак транспортного средства: a – автомобиль, в – велосипед, м - мотоцикл,
/// с – самолет, п – поезд. Вывести на экран максимальную скорость транспортного средства в зависимости от введенного признака.
/// </summary>
    class Program
    {
        public static string Input(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }
        public static string Value(string transport)
        {
            switch(transport)
            {
                case "а":return "автомобиль - 180 км/ч";
                case "в": return "велосипед - 25 км/ч";
                case "м": return "мотоцикл - 230 км/ч";
                case "с": return "самолет - 499 км/ч";
                case "п": return "поезд - 350 км/ч";
                default:return "Некоретно";
            }
        }
        static void Main(string[] args)
        {
            string transport = Input("первая буква транспорта:");
            string transport1 = Value(transport);
            Console.Write($"Транспорт: {transport1}");
            Console.ReadKey();
        }
    }
}
