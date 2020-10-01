using System;

namespace _39_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos pescadores foram multados?");
            var max = int.Parse(Console.ReadLine());
            
            Multa M = new Multa();

            M.kilos = new decimal[max];  

            Console.WriteLine("Qual o valor da multa?");
            M.multa = int.Parse(Console.ReadLine());

            for (var i = 0; i  < max; i++)
            {
                Console.WriteLine("Quantos kilos o " + (i+1) + "º pescador pescou?");
                M.kilos[i] = decimal.Parse(Console.ReadLine());
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Atenção, valor acima de 50 kilos serão cobrados  {M.multa} reais por kilo excedente");
            Console.ForegroundColor = ConsoleColor.Gray;
            
            for (var i = 0; i < max; i++)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine((i+1) + "º pescador.");
                Console.ForegroundColor = ConsoleColor.Gray;

                var b = M.GetValorDaMulta(i,M.multa, M.kilos);
                Console.WriteLine("Siga o regulamento de pesca.");
                Console.WriteLine("Valor da multa = " + b);
                
            }
        }
    }
}

class Multa 
{
    public decimal multa;
    public decimal [] kilos;

    public decimal GetValorDaMulta(int i, decimal multa, decimal [] kilos)
    {
        var formula = kilos[i] - 50;
        var formulaDois = formula * multa;
        return formulaDois;
    }
}
