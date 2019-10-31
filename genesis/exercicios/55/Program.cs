using System;

namespace _55
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal max = 0, cont = 0, saldo = 0, credito = 0;

            Console.WriteLine("Quantos clientes vão ser analisados?");
            max = int.Parse(Console.ReadLine());

            while (cont < max)
            {
                Console.WriteLine("Qual o saldo do cliente?");
                saldo = int.Parse(Console.ReadLine());

                if (saldo > 0 && saldo < 200)
                {
                    Console.WriteLine("Saldo médio: " + saldo);
                    Console.WriteLine("valor do crédito: 0");
                }
                else if (saldo > 200 && saldo < 401)
                {
                    credito = saldo / 100 * 20;
                    Console.WriteLine("Saldo médio: " + saldo);
                    Console.WriteLine("valor do crédito: " + credito);
                }
                else if (saldo > 400 && saldo < 601)
                {
                    credito = saldo / 100 * 30;
                    Console.WriteLine("Saldo médio: " + saldo);
                    Console.WriteLine("valor do crédito: " + credito);
                }
                else
                {
                    credito = saldo / 100 * 40;
                    Console.WriteLine("Saldo médio: " + saldo);
                    Console.WriteLine("valor do crédito: " + credito);
                }
                cont++;
            }
        }
    }
}
