using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exer_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double X;
            int A, B;


            while (true)
            {
                Console.Write("Insira um valor positivo qualquer: ");
                X = double.Parse(Console.ReadLine());

                if (X > 0)
                {
                    break
                    ;
                }

                else
                {
                    Console.WriteLine("Entrada inválida. Por favor, insira um valor positivo.");
                }
            }
            while (true)
            {
                Console.Write("Insira o valor inteiro para A: ");
                A = int.Parse(Console.ReadLine());

                if (A > 0)
                {
                    break
                    ;
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Por favor, insira um valor inteiro para A.");
                }
            }

            while (true)
            {
                Console.Write("Insira um valor inteiro para B, lembrando que deve ser maior que A: ");
                B = int.Parse(Console.ReadLine());


                if (B > A)
                {
                    break
                    ;
                }

                else
                {
                    Console.WriteLine("Entrada inválida. B deve ser maior que A.");
                }
            }

            Console.WriteLine("Tabuada de {0} no intervalo de {1} para {2}:", X, B, A);
            for (int i = B; i >= A; i--)
                Console.WriteLine($"{X} x {i} = {X * i}");
        }
    }
}
