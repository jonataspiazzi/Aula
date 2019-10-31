using System;

namespace _56
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal codigo = 0, salario = 0, salarioFinal = 0, aumento = 0, diferenca = 0;

            Console.WriteLine("Qual o código do funcionario?");
            codigo = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual o salario do funcionario?");
            salario = int.Parse(Console.ReadLine());

            if ( codigo < 102 && codigo > 100)
            {
                aumento = salario / 100 * 10;
                salarioFinal = salario + aumento;
            }
            else if (codigo < 103 && codigo > 101)
            {
                aumento = salario / 100 * 20;
                salarioFinal = salario + aumento;    
            }
            else if (codigo < 104 && codigo > 102)
            {
                aumento = salario / 100 * 30;
                salarioFinal = salario + aumento; 
            }
            else 
            {
                aumento = salario / 100 * 40;
                salarioFinal = salario + aumento; 
            }
            diferenca = salarioFinal - salario;
            Console.WriteLine("O antigo salário é: " + salario);
            Console.WriteLine("O novo salário é: " + salarioFinal);
            Console.WriteLine("A diferente entre eles é de: " + diferenca);
            
        }
    }
}
