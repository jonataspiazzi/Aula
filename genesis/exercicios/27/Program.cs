using System;

namespace _27
{
    class Program
    {
        static void Main(string[] args)
        {
           decimal salario, vendas, valor, total, comissao;
           string texto;

           Console.WriteLine(" Qual o valor do salario?");
           texto = Console.ReadLine();
           salario = int.Parse(texto);

           Console.WriteLine(" Qual o valor total em vendas?");
           texto = Console.ReadLine();
           vendas = int.Parse(texto);

           Console.WriteLine("Qual a porcentagem da comissão?");
           texto = Console.ReadLine();
           valor = int.Parse(texto);

           comissao = valor / 100M * vendas;

           total = salario + comissao;
        
            Console.WriteLine("O valor a receber em comissão é: " + comissao );
            Console.WriteLine("O valor total a receber é: " + total);
        }
    }
}
