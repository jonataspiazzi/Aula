using System;

namespace aula1
{
    class Program
    {
        static void Main(string[] args)
        {
            //variaveis 
            decimal salario, meses, férias, v13, acerto, rescisão;
            string texto;

            //programa
            salario = 0;
            meses = 0;
            férias = 0;
            v13 = 0;
            acerto = 0;
            rescisão = 0;
            texto = "";

            // lalala

            Console.WriteLine("Qual o valor do salario?");
            texto = Console.ReadLine();
            salario = decimal.Parse(texto);

            Console.WriteLine("Quantos meses foram trabalhados?");
            texto = Console.ReadLine();
            meses = decimal.Parse(texto);

            férias = (salario / 12 * meses) / 3;

            v13 = salario / 12 * meses;

            acerto = (salario / 12 * meses) * 1.4M;

            rescisão = férias + v13 + acerto;

            Console.WriteLine("O valor da rescisão é " + rescisão);
        }
    }
}
