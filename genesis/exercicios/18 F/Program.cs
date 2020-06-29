using System;

namespace _18F
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int numA = 0, numB = 0;

            Console.WriteLine("Digite o valor de A");
            numA = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de B");
            numB = int.Parse(Console.ReadLine());

            if(Apoio.Comparacao(numA,numB); => 1)
            {
                Console.WriteLine(numA + " é maior que " + numB);
            }
            else if(Apoio.Comparacao(numA,numB); < 1)
            {
                Console.WriteLine(numA + "é menor que " + numB);
            }
            */

            int numA = 0, numB = 0;

            Console.WriteLine("Digite o valor de A");
            numA = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de B");
            numB = int.Parse(Console.ReadLine());

            var B = Apoio.Comparacao(numA, numB);

            if(B >= 0)
            {
                Console.WriteLine("num A é maior ou igual que numB");
            }
            else if(B < 1)
            {
                Console.WriteLine(" num A é menor que num B");
            }
        }
    }
}
