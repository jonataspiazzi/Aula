using System;

namespace exercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] resultado = new int[11]; 

            Vezes(resultado);
            for(int i = 0; i <= 10; i++)
                {
                    Console.WriteLine($"7X{i}={resultado[i]}");
                }
        }
        static void Vezes (int[] resultado)
        {
            for (int qtd = 0; qtd <= 10; qtd++)
            {
              resultado[qtd] =  qtd * 7;
            }            
        }
    }
}
