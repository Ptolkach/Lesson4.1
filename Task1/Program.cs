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
            Console.WriteLine("Введите целое число больше нуля");
            int n = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            int s = 0;
            for (i = 1; i <= 2 * n - 1; i += 2)
            {
                s += i;
                Console.WriteLine(s);
            }
            Console.ReadKey();
        }
    }
}
