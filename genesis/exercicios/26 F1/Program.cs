using System;

namespace _26_F1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 1;
            int n2 = 1;

            Console.WriteLine("Digite o número: ");
            int num = int.Parse(Console.ReadLine());
            bool pertence = false;

            //Console.WriteLine(n1);
            //Console.WriteLine(n2);

            for (var cont = 0; cont < 28; cont++)
            {
                int soma = n1 + n2;
                n1 = n2;
                n2 = soma;

                if (num == n1)
                {
                    pertence = true;
                }

                //Console.WriteLine(n2);
            }

            if (pertence)
            {
                Console.WriteLine("O número " + num + " pertence a sequencia Fibonacci.");
            }
            else
            {
                Console.WriteLine("O número " + num + " não pertence a sequencia Fibonacci.");
            }
        }
    }
}
