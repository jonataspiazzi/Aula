using System;

namespace _50_B
{
    class Program
    {
        static void Main(string[] args)
        {
           int cont = 0, max = 0;
           int idade = 0, sexo = 0, olho = 0, cabelo = 0;
           int pCaso = 0, sCaso = 0;
        
            Console.WriteLine("Quantas pessoas participaram da pesquisa?");
            max = int.Parse(Console.ReadLine());

            for (cont = 0; cont < max; cont++)
            {
                Console.WriteLine("Qual a idade do " + (cont + 1) + "º participante?");
                idade = int.Parse(Console.ReadLine());

                Console.WriteLine("Qual o sexo do  " + (cont + 1) + "º participante?");
                Console.WriteLine("1 para Mulher e 2 para Homem");
                sexo = int.Parse(Console.ReadLine());

                Console.WriteLine("Qual a cor dos olhos do " + (cont + 1) + "º participante?");
                Console.WriteLine("1 para preto, 2 para castanho, 3 para azul e 4 para verde");
                olho = int.Parse(Console.ReadLine());

                Console.WriteLine("Qual a idade do " + (cont + 1) + "º participante?");
                Console.WriteLine("1 para preto, 2 para castanho e 3 para ruivo");
                cabelo = int.Parse(Console.ReadLine());

                if (sexo == 2 && olho == 1)
                {
                    pCaso++;
                }

                if (sexo == 1 && cabelo == 2 && (olho == 3 || olho == 4))
                {
                    sCaso++;
                }

            }

            Console.WriteLine("A quantidade de homens de olhos pretos são: " + pCaso);
            Console.WriteLine("A quantidade de Mulheres com cabelos pardos e olhos azuis ou verdes são: " + sCaso);
        }
    }
}
