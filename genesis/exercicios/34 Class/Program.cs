using System;

namespace _34_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos numeros seram digitados?");
            var max = int.Parse(Console.ReadLine());

            Numeros N = new Numeros();

            N.num = new int [max];

            for(var i = 0; i < max; i++)
            {
                N.num[i] = N.GetLeiaNumero($"Qual o valor do {i+1}º numero?");

                if(N.num[i] >= 4 && N.num[i] <= 20)
                {
                    N.media = N.media + N.num[i];
                    N.contNum++;
                }
                if(N.num[i] < N.menorNum)
                {
                    N.menorNum = N.num[i];
                }
            }
            var a = N.media / N.contNum;
            Console.WriteLine($"A media dos numeros digitados entre 4 e 20 foi: {a}");
            Console.Write($"E o menor numero digitado foi: {N.menorNum}");
            
        }
    }
    class Numeros
    {
        public int [] num;
        public int contNum;
        public int media;
        public int menorNum = Int32.MaxValue;
        public int GetLeiaNumero(string Mensagem)
        {
            Console.WriteLine(Mensagem);
            return int.Parse(Console.ReadLine());
        }
        public string GetLeiaString(string Mensagem)
        {
            Console.WriteLine(Mensagem);
            return Console.ReadLine();
        }
    }
}
