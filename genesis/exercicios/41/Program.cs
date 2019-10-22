using System;

namespace _41
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal idade, max, cont, infantilA, infantilB, juvenilA, juvenilB, adulto;
            string texto, nome;

            infantilA = 0;
            infantilB = 0;
            juvenilB = 0;
            juvenilA = 0;
            adulto = 0;
            cont = 0;

            Console.WriteLine("Quantos nadadores vão se matrícular?");
            texto = Console.ReadLine();
            max = int.Parse(texto);

            while (cont < max)
            {
                Console.WriteLine("Qual o nome do nadador?");
                nome = Console.ReadLine();

                Console.WriteLine("Qual a idade do nadador?");
                texto = Console.ReadLine();
                idade = int.Parse(texto);

                if (idade >= 5)
                if (idade <= 7)
                 {
                    Console.WriteLine(nome + " pertence a categoria infantilA");
                    infantilA = infantilA + 1;
                 }
                   if (idade >= 8)
                   if (idade <= 11)
                    {
                       Console.WriteLine(nome + " pertence a categoria infantilB");
                       infantilB = infantilB + 1;
                    }
                      if(idade >= 12)
                      if(idade <= 13)
                       { 
                           Console.WriteLine(nome + " pertence a categoria juvenilA");
                           juvenilA = juvenilA + 1;
                       }
                         if(idade >= 14)
                         if(idade <= 17)
                         {
                            Console.WriteLine(nome + " pertence a categoria infantilB");
                            juvenilB = juvenilB + 1;
                         }
                           if(idade >= 18)
                           {
                               Console.WriteLine(nome + " pertence a categoria adulto");
                               adulto = adulto + 1;
                           }
                           if(idade < 5)
                           {
                              Console.WriteLine(" Este clube não aceita alunos com idade inferior a 5 anos.");
                           }
                else {}

             cont = cont + 1;
            }
            Console.WriteLine("O total de nadadores da categoria infantilA é: " + infantilA);
            Console.WriteLine("O total de nadadores da categoria infantilB é: " + infantilB);
            Console.WriteLine("O total de nadadores da categoria juvenilA é: " + juvenilA);
            Console.WriteLine("O total de nadadores da categoria juvenilB é: " + juvenilB);
            Console.WriteLine("O total de nadadores da categoria adulto é: " + adulto);
        }
    }
}
