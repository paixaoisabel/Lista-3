using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exer_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int num = 1; num <= 20; num++)
            {
                Console.WriteLine("Tabuada de {0}:", num);

                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine("{0} x {1} = {2}", num, i, num * i);
                }

                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
            }

            Console.WriteLine("Todas as tabuadas foram exibidas.");
        }
    }
}
