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

            // 7 Escreva um programa que exiba todos os números de 1 a 100
            //e a cada número que for múltiplo de 10, exiba a mensagem “MÚLTIPLO DE 10”. 

            int c, multiplos;
            for (c = 1; c <= 100; c++)
            {
                if (c % 10 == 0) { Console.WriteLine("{0}: MULTIPLO DE 10!", c); }
                else { Console.WriteLine(c); }
            }
            Console.ReadKey();
        }
    }
}



