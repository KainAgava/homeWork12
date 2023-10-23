using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork2._8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            string symbol;
            Console.WriteLine("введите ваше имя");
            name = Console.ReadLine();

            Console.WriteLine("введите символ");
            symbol = Console.ReadLine();
            int numberSymbols = name.Length + 2;
            Console.WriteLine();

            for (int i = 0; i < numberSymbols; i++)
            {
                Console.Write(symbol);
            }
            Console.WriteLine();
            Console.Write($"{symbol}{name}{symbol}");
            Console.WriteLine();
            for (int i = 0; i < numberSymbols; i++)
            {
                Console.Write(symbol);
            }
            Console.ReadKey();
        }
    }
}
