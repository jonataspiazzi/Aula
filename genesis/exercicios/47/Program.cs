using System;

namespace _47
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal num = 0, expoente = 0, cont = 0, fat = 1;

            Console.WriteLine("Qual o valor da base?");
            num = int.Parse(Console.ReadLine());

           Console.WriteLine("Qual o valor do expoente?");
            expoente = int.Parse(Console.ReadLine());

            while (cont <= expoente)
            {
                fat *= cont; // fat = fat * cont;
                cont++;
            }
            Console.WriteLine("O valor da potência é; " + fat);
        }
    }
}
