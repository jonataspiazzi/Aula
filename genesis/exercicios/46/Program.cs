using System;

namespace _46
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal max = 0, cont = 0, totalnegativo = 0;

            Console.WriteLine("Qunatos números serão digitados?");
            max = int.Parse(Console.ReadLine());

            while (num > 0) (num < 0)
            {
                while (cont < max)
                {
                    if (num < 0)
                    {
                        totalnegativo += num;
                    }
                    cont++;
                }
            }
            Console.WriteLine("O total dos numeros negativos é; " + totalnegativo);
        }
    }
}
