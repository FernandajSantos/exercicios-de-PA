using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {

            //3: Escreva um programa que exiba na tela a tabuada de um número que deverá ser informado pelo usuário
            //(deverá ser usada qualquer estrutura de repetição).

            int n, tabuada;

            Console.Write("Digite um número para sua tabuada: ");

            n = int.Parse(Console.ReadLine());
            Console.Write("\n");
            for (int x = 1; x <= 10; x++)
            {
                tabuada = n * x;
                Console.Write("{0}x{1}={2}\n", n, x, tabuada);
            }
            Console.ReadKey();
        }
        
     }  

}

