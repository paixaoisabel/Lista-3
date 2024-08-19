using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exer_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Double n;
            Double i;

            do
            {
                Console.Write("Digite um número posotivio: ");
                n = double.Parse(Console.ReadLine());
            }
            while (n < 0);

            for (i = 1; i <= 10; ++i)
                Console.WriteLine("{0} x {1} = {2}", n, i, n * i);
        }
    }
}
