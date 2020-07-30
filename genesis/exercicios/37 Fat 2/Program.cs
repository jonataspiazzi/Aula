using System;

namespace _37_Fat_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0, fat = 1;

            Console.WriteLine("Digite um número");
            num = int.Parse(Console.ReadLine());

            Console.WriteLine("O fatorial é: " + Fatoreal(num, fat));
        }
        static int Fatoreal(int num, int fat)
        {
            while (num > 1)
            {
                fat *= num;
                num--;
            }
            return fat;
        }
    }
}
