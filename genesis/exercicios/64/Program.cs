using System;

namespace _64
{
    class Program
    {
        static void Main(string[] args)
        {
             int max , cont = 0;

            Console.WriteLine("Quantos alunos fizeram a prova?");
            max = int.Parse(Console.ReadLine());
            //Existe...max = decimal.Parse(Console.ReadLine());

            decimal[] nota = new decimal[max];
            decimal total = 0, media = 0;

            while (cont < max)
            {
                Console.WriteLine("Qual o valor da prova do " + (cont + 1) + "º aluno?");
                nota[cont] = int.Parse(Console.ReadLine());
    
                total += nota[cont];

                cont++;
            }
            cont = 0;
            media = total / max;

            while(cont < max)
            {
                if (nota[cont] > media)
                {
                    Console.WriteLine("A nota do " + (cont + 1) + "º aluno foi superior a media da turma, parabéns");
                }
                cont++;
            }
        }
    }
}
