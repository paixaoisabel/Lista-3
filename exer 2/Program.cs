using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exer_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;

            Console.Write("Digite o primeiro valor:");
            a = int.Parse(Console.ReadLine());

            do
            {
                Console.Write("Digite o segundo valor:");
                b = int.Parse(Console.ReadLine());

                if (b <= a)
                {
                    Console.WriteLine("O segundo valor deve ser maior que o primeiro, tente novamente.");
                }

            } while (b <= a);

            Console.WriteLine("Primeiro valor: " + a);
            Console.WriteLine("Segundo valor: " + b);

        }
    }
}
