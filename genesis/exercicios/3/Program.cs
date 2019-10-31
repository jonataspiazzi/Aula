using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace EX3
{
    class Program
    {
        // Método calculador do fatorial.
        static long Fatorial(int number)
        { Console.WriteLine("Qual o codigo do produto?");
            codigo = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual a quantidade do produto?");
            quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual o valor unitario?");
            valor = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual a descrição do produto?");
            descrição = Console.ReadLine();




            cont++;
            }

            Console.WriteLine("O total de itens da nota fiscal é: " + cont);
        }
    }
}