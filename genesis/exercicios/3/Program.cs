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
        {
            // Se o parâmetro (valor desejado para calculo do fatorial)
            // for 0 ou 1, o retorno sempre será 1 (devido a regra do fatorial).
            // Se for maior que 1, é feito o número vezes o fatorial desse mesmo número menos 1
            // até o parâmetro ser 1.
            // Isso é chamado de função recursiva / método recursivo / recursive function.
            if (number <= 1)
                return 1;
            else return number * Fatorial(number - 1);
        }
 
        // Método principal.
        static void Main(string[] args)
        {
            // Muda a cor das letras do console para amarelo.
            Console.ForegroundColor = ConsoleColor.Yellow;
            // Exibe os resultados dos fatoriais de 0 à 20.
            for (int i = 0; i <= 20; i++)
            {
                // Mostra o fatorial e seu resultado.
                Console.WriteLine("{0} ! = {1}", i, Fatorial(i));
            }
            // Aguarda para sair.
            Console.ReadLine();
        }
    }
}