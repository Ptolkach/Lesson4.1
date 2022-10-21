using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите поочередно положительные числа A, B, C");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int n = c;
            int count_a = 0;
            int count_b = 0;
            if (c > a || c > b)
            {
                Console.WriteLine(0);
            }
            else
            {
                while (n <= a)
                {
                    count_a++;
                    n += c;
                }
                n = c;
                while (n <= b)
                {
                    count_b += count_a;
                    n += c;
                }
                Console.WriteLine(count_b);
            }
            Console.ReadKey();
        }
    }
}
