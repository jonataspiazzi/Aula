using System;

namespace _40
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal max, extra, horas, salario, salarioExtra, contS, salarioTotal, salarioFinal, cont;
            string texto, codigo;

            cont = 0;
            salarioTotal = 0;
            contS = 0;

            Console.WriteLine("Qual o total de operários?");
            texto = Console.ReadLine();
            max = int.Parse(texto);

            while ( cont < max)
            {
                Console.WriteLine("Qual o código do operários?");
                codigo = Console.ReadLine();

                Console.WriteLine("Qual o números de horas trabalhadas?");
                texto = Console.ReadLine();
                horas = int.Parse(texto);

                if ( horas > 50 )
                {
                    extra = horas - 50;
                    salario = 50 * 10.50M;
                    salarioExtra = extra * 12;
                    salarioFinal = salario + salarioExtra;
                }  
                else 
                {
                    salario = horas * 10.50M;
                    salarioFinal = salario; 
                }

                salarioTotal = salarioTotal + salarioFinal;

                Console.WriteLine("Código " + codigo);
                Console.WriteLine("Salario " + salarioTotal);

                if ( horas >= 40)
                {
                    contS = contS + 1;
                }

                cont = cont + 1;
            }

            Console.WriteLine(contS + " operários trabalharam mais de 40 horas");
            Console.WriteLine("O valor total pago em salário foi: " + salarioTotal);
        }
    }
}
