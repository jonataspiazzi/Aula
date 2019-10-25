using System;

namespace _37b
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0, fat = 1;
            
            Console.WriteLine("Digite um número");
            num = int.Parse(Console.ReadLine());

            while (num > 1)
            {
                fat *= num; // fat = fat * num;
                num--;
            }

            Console.WriteLine("O fatorial é: " + fat);
        }
    }
}
