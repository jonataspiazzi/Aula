using System;

namespace _57
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal chico = 0, chicoC = 0, ze = 0, zeC = 0, cont = 0;

            Console.WriteLine("Qual a altura de Chico em centimetros?");
            chico = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantos centimetros ele cresce por nao?");
            chicoC = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual a altura de Zé em centimetros?");
            ze = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantos centimetros ele cresce por nao?");
            zeC = int.Parse(Console.ReadLine());

            while (chico > ze)
            {
                chico = chico + chicoC;
                ze = ze + zeC;
                cont++;
            }
            Console.WriteLine("Foi preciso " + cont + " anos para Zé ficar maior que Chico");
        }
    }
}
