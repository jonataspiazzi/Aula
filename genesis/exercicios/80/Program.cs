using System;

namespace _80
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 0, max = 20;
            int especial = 0;

            int [] num = new int [cont];

            Console.WriteLine("Digite os 10 primeiros valores em ordem crescente");

            for(cont = 0; cont < 10; cont++)
            {
                Console.WriteLine("Digite o valor do " + (cont + 1) + "º numero");
                num[cont] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Os numeros já digitados em ordem crescente são:");

            for(cont = 0; cont < max; cont++)
            {
                Console.Write(num[cont] + " /");
            }
            
            // op 1
            
            int max = 9;

            for(cont = 10; cont < 20; cont++)
            {
                Console.WriteLine("Digite o valor do " + (cont + 10) + "º numero");
                num[cont] = int.Parse(Console.ReadLine());
                max++;

                // A = num atual digitado
                // B = Para rodar em todos os vetores 
                // C = Ir colocando os vetros para as casas do lado, do ultimo ate a vetor que eu quero colocar 
                // max = os 10 numeros já digitados + os novos ate aqui

                int A = cont, B = 0, C = 0;

                for (B = 0; B < max; max--)
                {
                    if (num[A] > num[max])
                    {
                        for (C = ; C < max; max--) // parei aqui
                        {
                            num[max] = num[(max + 1)];
                            num[max] = num[A];
                        }
                    }
                }
            }

            //inserindo os outros 10 numeros na ordem crescente.

            /* op 2

            for(cont = 10; cont < 20; cont++)
            {
                Console.WriteLine("Digite o valor do " + (cont + 10) + "º numero");
                num[cont] = int.Parse(Console.ReadLine());
            }

            for (cont = 0; cont < 20; cont++)
            {
                if (num[cont] > especial)
                {
                    especial = num[cont]
                    num[cont + 1] = especial;
                }

            */
                

            }
            Console.WriteLine("A nova ordem crescente é: ");    
            
             for (cont = 0; cont < max; cont++)
             {
                 Console.Write(num[cont]);
             }
    
        }
    }
}
