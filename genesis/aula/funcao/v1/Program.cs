using System;

namespace v1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Metodo = Função

            // Interpolação de string (string interpolation) lançado do C# v6.
            // Pre-v6: "7 X " + i + " = " + (7 * i)
            // Pos-v6: $"7 x {i} = {7 * i}"

            //Console.Write("Digite o número que você deseja ver a tabuada: ");
            //var num = int.Parse(Console.ReadLine());

            for (var num = 1; num <= 10; num++)
            {
                Console.WriteLine("-----------");

                for (var i = 0; i <= 10; i++)
                {
                    Console.WriteLine(num + " X " + i + " = " + (num * i));
                }
            }
        }

        static void ImprimeTabuada()
        {
            Console.WriteLine("-----------");

            for (var i = 0; i <= 10; i++)
            {
                Console.WriteLine(num + " X " + i + " = " + (num * i));
            }
        }
    }
}
