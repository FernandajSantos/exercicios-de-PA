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

            //exercicio 09:

            int n, par = 0, impar = 0, positivo = 0, negativo = 0;
            string resposta;
            do
            {
                Console.Write("Digite um número inteiro ");
                n = int.Parse(Console.ReadLine());

                if (n % 2 == 0)
                {
                    par++;
                }
                else
                {
                    impar++;
                }
                if (n >= 0)
                {
                    positivo++;
                }
                else
                {
                    negativo++;
                }

                Console.Write("deseja encerar o programa? ");
                resposta = Console.ReadLine();
            } while (resposta != "s");
            Console.WriteLine("a quantidade de números pares é: " + par);
            Console.WriteLine("a quantidade de números impares é: " + impar);
            Console.WriteLine("a quantidade de números positivos é: " + positivo);
            Console.WriteLine("a quantidade de números negativos é: " + negativo);

            Console.ReadKey();
        }


    }
}



