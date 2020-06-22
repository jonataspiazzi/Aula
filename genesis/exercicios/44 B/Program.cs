using System;

namespace _44_B
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 0, salario = 0, idade = 0, cont =0;
            int contSalario = 0, contHomem = 0;
            int maiorIdade = Int32.MinValue, menorIdade = Int32.MaxValue;
            int salarioTotal = 0;
            string x;

            Console.WriteLine("Quantas pessoas foram intrevistadas?");
            max = int.Parse(Console.ReadLine());

            for (cont = 0; cont < max; cont++)
            
            {
                Console.WriteLine("Qual o valor do salario do " + (cont + 1) + "º intrevistado:");
                salario = int.Parse(Console.ReadLine());

                Console.WriteLine("Qual a idade do " + (cont + 1) + "º intrevistado:");
                idade = int.Parse(Console.ReadLine());

                Console.WriteLine("Qual o sexo do " + (cont + 1) + "º intrevistado?");
                Console.WriteLine("f para feminino e m para masculino");
                x = Console.ReadLine();
                if (x == "f") 
                {
                    if (salario > 100)
                    {
                        contSalario++;
                    }
                }
	        	else if (x == "m")
                {
                    contHomem++;
                } 

                if (idade > maiorIdade)
                {
                    maiorIdade = idade;
                }
                else if (idade < menorIdade)
                {
                    menorIdade = idade;
                }
                
                salarioTotal = salario + salarioTotal;
            }

            int media;
            media = salarioTotal / max;


            Console.WriteLine("A media dos salarios é " + media);
            Console.WriteLine("A maior idade do grupo é: " + maiorIdade);
            Console.WriteLine("A menor idade do grupo é: " + menorIdade);
            Console.WriteLine(contSalario + " mulheres recebem um salário maior que R$ 100,00");
            Console.WriteLine(contHomem + " homens participaram da pesquisa");
        }
    }
}
