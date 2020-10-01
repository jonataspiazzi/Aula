using System;

namespace _40_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos operarios trabalharam?");
            var max = int.Parse(Console.ReadLine());

            Operario O = new Operario();

            O.codigo = new int[max]; O.horas = new int[max]; O.salario = new decimal[max];

            for (var i = 0; i < max; i++)
            {
                Console.WriteLine($"Qual o codigo do {i+1} º operario?");
                O.codigo[i] = int.Parse(Console.ReadLine());
                
                Console.WriteLine("E quantas horas de trabalho ele fez?");
                O.horas[i] = int.Parse(Console.ReadLine());
            }

            decimal totalDosSalarios = 0;  

            for (var i = 0; i < max; i++)
            {
                O.GetCalculoDoSalario(max, O.horas, O.salario);
                
                Console.WriteLine($"O salario do funcionario {O.codigo[i]} é: {O.salario[i]}");

                totalDosSalarios = totalDosSalarios + O.salario[i];
            }

            Console.WriteLine($"O total de funcionarios esse mês foi {max}, gerando um gasto de {totalDosSalarios}");
        }
    }
    class Operario
    {
        public int [] codigo;
        public int [] horas;
        public decimal [] salario;

        public void GetCalculoDoSalario(int max, int [] horas, decimal [] salario)
        {
            decimal a = 0, b = 0, c = 0;

            for ( var i = 0; i < max; i++)
            {
                if (horas[i] > 50)
                {
                    a = (horas[i] - 50) * 1.50M;
                    b = horas[i] * 10.50M;
                    c = a + b;
                }
                else if(horas[i] <= 50)
                {
                    c = horas[i] * 10.50M;
                }
                salario[i] = c;
            }

        }
    }
}
