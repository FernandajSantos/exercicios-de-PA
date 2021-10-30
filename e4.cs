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
            //4escreva um programa que exiba na tela a quantidade de numeros impares existentes
            //entre dois numeros que o usuario digitar,testar inclusive os numeros digitados
            int num,num2,quant=0,menor_num,maior_num;

            Console.WriteLine("Numero Impares");

            Console.Write("Digite o primeiro valor: ");
            num = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundoº valor: ");
            num2 = int.Parse(Console.ReadLine());
           if (num <= num2)
            {
                menor_num = num;
                maior_num = num2;
            }
            else
            {
                menor_num = num2;
                maior_num = num;
            }
           for(int i = menor_num; i <= maior_num; i++)
            {
                if (i % 2 != 0)
                {
                    quant++;
                }
            }
            Console.WriteLine("quantidade de numeros impares entre " + menor_num + " e " + maior_num + " é " + quant);
            Console.ReadKey();
            
        }
    }
}
