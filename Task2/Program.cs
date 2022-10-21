using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите последовательность чисел");
            int i = 0;
            int n = 0;
            int m = 0;
            do
            {
                if (i > 0)
                {
                    m++;
                }
                else
                {
                    n++;
                }
                i = Convert.ToInt32(Console.ReadLine());
            } while (i != 0);
            if (n > m)
            {
                Console.WriteLine("отрицательных чисел больше");
            }
            else if (n < m)
            {
                Console.WriteLine("положительных чисел больше");
            }
            else
            {
                Console.WriteLine("количество отрицательных чисел равно количеству положительных");
            }
            Console.ReadKey();
        }
    }
}
