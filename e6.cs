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
            //6 escreva um programa que calcule e exiba a media de 10 notas digitadas
           
            Double  notas, soma=0, x,  media;

            for (x = 1; x <= 10; x++) {

                do
                {
                    Console.WriteLine("DIGITE A NOTA " + x );
                    notas = Double.Parse(Console.ReadLine());

                    if (notas < 0 || notas > 10)
                    {
                        Console.Write("NOTA INVALIDA!");
                    }
                } while (notas < 0 || notas > 10);
                soma=soma + notas;
             }
            media = soma /10;
            Console.Write("SUA MEDIA É " + media);
            Console.ReadKey();
        }


        }
    }
