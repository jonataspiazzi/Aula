using System;

namespace _78
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 0, cont = 0;

            Console.WriteLine("Quantos caracteres você vai digitar?");
            max = int.Parse(Console.ReadLine());

            string [] caractere = new string[max];

            for (cont = 0; cont < max; cont++)
            {
                Console.WriteLine("Digite o " + (cont + 1) + "º caractere");
                caractere[cont] = Console.ReadLine();
            } 

            for (cont = 0; cont < max; cont++)
            {
                if (caractere[cont] != "a")
                {
                    Console.Write(caractere[cont] + " ");
                }

                // alternativo - tbm funciona.

                 /* 

                string sem = ";

             for (cont = 0; cont < max; cont++)
            {
                if (caractere[cont] != "a")
                {
                    sem = sem + caractere[cont];
                }
                sem = sem + "";
            }
            Console.WriteLine(sem);
            */
            }
        }
    }
}
