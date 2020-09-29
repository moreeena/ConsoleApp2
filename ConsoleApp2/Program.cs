using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine($"Введите переменную типа int");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Введите переменную типа double");
                double b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"Введите пеменную типа long");
                long c = Convert.ToInt64(Console.ReadLine());
                Console.WriteLine("a={0}, b={1}, c={2}", a, b, c);
            }
            catch
            {
                Console.WriteLine($"Неравильно веденная переменная");
            }
            Console.ReadKey();
        }
    }
}
