using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exer_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string S;

            do
            {
                Console.Write("Digite (F) para feminino ou (M) para masculino: ");
                S = Console.ReadLine();

                if (S != "F" && S != "f" && S != "M" && S != "m")

                    Console.WriteLine("digite um valor valido.");
            }
            while (S != "F" && S != "f" && S != "M" && S != "m");
            {
                Console.WriteLine("O sexo indicado é {0}", S);
            }

        }
    }
}
