using System;

namespace _63
{
    class Program
    {
        static void Main(string[] args)
        {

            int max, cont = 0, ultimos;

            Console.WriteLine("Quantos numeros seram digítados?");
            max = int.Parse(Console.ReadLine());

            Console.WriteLine("Quantos dos ultimos numeros você quer ver?");
            ultimos = int.Parse(Console.ReadLine());

            int[] num = new int[max];

            while (cont < max)
            {
                Console.WriteLine("Digíte o " + (cont + 1) + "º numero");
                num[cont] = int.Parse(Console.ReadLine());

                cont++;
            }

            cont = 0;

            Console.WriteLine("Os ultimos " + ultimos + " numeros digitados foram:");

            while (cont < max)
            {   
                // pode fazer isso - (cont > max - ultimos)
                if (cont > max - ultimos)
                {   
                    Console.WriteLine(num[cont]);

                    cont++;
                }
                else 
                {
                    cont++;
                }
            }
        }
    }
}
