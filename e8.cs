using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            int N, x, soma = 1;
            Console.WriteLine("DIGITE UM NUMERO");
            N = int.Parse(Console.ReadLine());

            for (x = 1; x <= N; x++)
            {
                soma = soma * x;
            }
            Console.WriteLine("O FATORIAL DE " + N + " É " + soma);
            Console.ReadKey();
        }
    }
}



