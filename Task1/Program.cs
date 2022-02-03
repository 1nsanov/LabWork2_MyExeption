using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            int count;
            int price;
            try
            {
                Console.WriteLine("Тираж журнала...");
                count = int.Parse(Console.ReadLine());
                Console.WriteLine("Цена за 1 штуку($)...");
                price = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                throw new MagazineException("Некорректный ввод данных...");
            }

            Magazine magazine = new Magazine(count, price);

            Console.WriteLine(magazine);

            Console.ReadLine();
        }
    }
 
}