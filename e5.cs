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
            //escreva um programa que leia 15 numeros inteiros e exiba na tela ao final
            //o maior numero que foi digitado
            Console.WriteLine("DIGITE 15 NUMEROS \n");
            int num, maior_num;
            Console.WriteLine("DIGITE O 1 NUMERO!");
            maior_num = int.Parse(Console.ReadLine());
            for (int x = 1; x < 15; x++)
            {
                Console.WriteLine("DIGITE O {0} NUMERO ", x + 1);
                num = int.Parse(Console.ReadLine());
                if (maior_num < num)
                {
                    maior_num = num;
                }

            }
            Console.WriteLine("\n O MAIOR NUMERO DIGITADO FOI:  " + maior_num);
            Console.ReadKey();


        }
    }
}
