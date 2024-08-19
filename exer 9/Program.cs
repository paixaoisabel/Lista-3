using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exer_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1, b = 1;

            Console.WriteLine("Os trinta primeiros valores da série de Fibonacci são:");
            Console.WriteLine(a);
            Console.WriteLine(b);

            for (int i = 3; i <= 30; i++)
            {
                int proximo = a + b;
                Console.WriteLine(proximo);
                a = b;
                b = proximo;
            }
        }
    }
}
