using System;

delegate void ReadVar(out int value);

namespace Exemplo01
{
    class Program
    {
        static ReadVar readVar = (out int value) => value = int.Parse(Console.ReadLine());
        static Action<object> writeLine = (value) => Console.WriteLine(value);

        static void Main(string[] args)
        {
            // INICIO

            int num1, num2, soma;
            num1 = 0;
            num2 = 0;
            soma = 0;
            readVar(out num1);
            readVar(out num2);
            soma = num1 + num2;
            writeLine(soma);

            // FIM
        }
    }
}
