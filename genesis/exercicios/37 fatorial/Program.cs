using System;

namespace _37
{
    class Program
    {
        static void Main(string[] args)
        { 
            int num = 0, cont = 1, fat = 1;
            
            Console.WriteLine("Digite um número");
            num = int.Parse(Console.ReadLine());

            while (cont <= num)
            {
                fat *= cont; // fat = fat * cont;
                cont++;
            }

            Console.WriteLine("" + num + "! = " + fat);
        }
    }
}
