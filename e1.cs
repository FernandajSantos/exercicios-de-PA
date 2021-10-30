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
            // 1: Escreva um programa que exiba na tela em ordem crescente,
            // apenas os números pares existentes de 11 a 250.
            Console.WriteLine("Veja abaixo os numeros pares de 11 a 250 em ordem crescente ");
            for (int numero = 11; numero <= 250; numero++)
            {
                if (numero % 2 == 0)
                {

                    Console.WriteLine(numero);
                }

            }

            Console.ReadKey();
        }
    }
}
