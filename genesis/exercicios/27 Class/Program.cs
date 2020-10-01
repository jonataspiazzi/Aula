using System;

namespace _27_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos funciorarios sua empresa tem?");
            var max = int.Parse(Console.ReadLine());

            Habitante H = new Habitante();
            H.nome = new string[max];  H.salario = new int[max];  H.porcentagem = new decimal[max];
            H.vendas = new decimal[max];

            for (var i = 0; i < max; i++)
            {
                Console.WriteLine("Qual o nome do " + (i+1) + "º funcionario?");
                H.nome[i] = Console.ReadLine();
                
                Console.WriteLine("E qual o valor do seu salario?");
                H.salario[i] = int.Parse(Console.ReadLine());

                Console.WriteLine("Qual o total de vendas do(a) " + H.nome[i]);
                H.vendas[i] = decimal.Parse(Console.ReadLine());

                Console.WriteLine("Qual a porcentagem de vendas do(a) " + H.nome[i]);
                H.porcentagem[i] = decimal.Parse(Console.ReadLine());
            }
            decimal b = 0;

            for (var i = 0; i < max; i++)
            {
                b = H.GetSalarioTotal(i, H.salario, H.porcentagem, H.vendas);
                Console.WriteLine("O valor do salario do funcionario " + H.nome[i] + " é " + b);
            }

        }
    }
    class Habitante
    {
        public string [] nome;
        public int [] salario;
        public decimal [] vendas;
        public decimal [] porcentagem;

        public decimal GetSalarioTotal(int i, int [] salario, decimal [] porcentagem, decimal [] vendas)
        {
            var a = vendas[i] / 100 * porcentagem[i];
            var b = a + salario[i];
            return b;
        }
    }
}
