using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exer_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            Console.WriteLine("Essa é a tabuada do Numero 5: ");
            for (i = 1; i <= 10; ++i)
                Console.WriteLine("{0} x {1} = {2}", 5, i, 5 * i);
        }
    }
}
