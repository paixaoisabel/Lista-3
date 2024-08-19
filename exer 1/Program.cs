using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exer_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;

            do
            {
                Console.Write("Digite numero positivo: ");
                a = int.Parse(Console.ReadLine());
            }
            while (a <= 0);
            Console.WriteLine("O número digitado foi {0}", a);

        }
    }
}
