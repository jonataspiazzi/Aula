using System;

namespace _44
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal cont = 0, idade = 0, max, salario, media = 0, salarioTotal = 0, homens = 0;
            decimal maior = int.MinValue, menor = int.MaxValue, salarioMais = 0;
            bool sexo;

            Console.WriteLine("Quantos habitantes fizeram parte da pesquisa?");
            max = int.Parse(Console.ReadLine());

            while (cont < max)
            {
                Console.WriteLine("Sexo:");
                sexo = Console.ReadLine() == "m";

                Console.WriteLine("Idade:");
                idade = int.Parse(Console.ReadLine());

                Console.WriteLine("Salário:");
                salario = int.Parse(Console.ReadLine());

                salarioTotal += salario;
                media = salarioTotal / max;

                if (idade < menor)
                    {
                        menor = idade;
                    }
                else if (idade > maior)
                    {
                        maior = idade;
                    }  
                else if (sexo == "f")   
                {
                    if (salario <= 100)
                    {
                        salarioMais++;
                    }
                } 
                else
                {
                    homens++;
                } 


                


               cont++;
            }
            Console.WriteLine("A media dos salarios é " + media);
            Console.WriteLine("A maior idade do grupo é: " + maior);
            Console.WriteLine("A menor idade do grupo é: " + menor);
            Console.WriteLine(salarioMais + " mulheres recebem um salário até R$ 100,00");
            Console.WriteLine(homens + " participaram da pesquisa");
        }
    }
}
