using System;

namespace _22_F
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = 0;

            Console.WriteLine("Digite um valor de num");
            int num = int.Parse(Console.ReadLine());
            
            if (num%2==0)
            {
                Console.WriteLine("O dobro de " + num + " é " + par(A));
            }
            else
            {
                Console.WriteLine("O triplo de " + num + " é " + impar(A));
            }
            
        }
       
        static int impar(int num)
        {
            int A = num * 2;
            return A;
        }
        static int par(int num)
        {
           int A = num * 3;
           return A;
        }
    }
}
