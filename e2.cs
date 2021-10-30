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
            //2: Escreva um programa que exiba na tela em ordem decrescente,
            // apenas os números ímpares existentes entre dois números digitados pelo
            // usuário(inclusive eles). 

            int a, b, n1, n2;

            Console.WriteLine("Numero Impares");

            Console.Write("Digite o 1º valor: ");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o 2º valor: ");
            n2 = int.Parse(Console.ReadLine());
            if (n1 >= n2)
            {
                a = n1;
            }
            else
            {
                a = n2;
            }

            if (n1 <= n2)
            {
                b = n1;
            }
            else
            {
                b = n2;
            }
            Console.Write("\n");
            for (int i = a; i >= b; i--)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}
