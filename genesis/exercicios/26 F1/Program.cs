using System;

namespace _26_F1 {
    class Program {
        static void Main (string[] args) 
        {
            var fibonacci = CriaFibonacci (30);

            Console.WriteLine ("Digite o número: ");
            int num = int.Parse (Console.ReadLine ());
            bool pertence = false;

            if (ConfirmaFibonacci(num, fibonacci, pertence))
            {
                Console.WriteLine ("O número " + num + " pertence a sequencia Fibonacci.");
            } 
            else 
            {
                Console.WriteLine ("O número " + num + " não pertence a sequencia Fibonacci.");
            }
        }

        public static int[] CriaFibonacci (int tamanho) 
        {
            int n1 = 1;
            int n2 = 1;
            int[] fibonacci = new int[tamanho];

            fibonacci[0] = n1;
            fibonacci[1] = n2;

            for (var cont = 0; cont < tamanho - 2; cont++) 
            {
                int soma = n1 + n2;
                n1 = n2;
                n2 = soma;
                fibonacci[cont + 2] = soma;
            }
            return fibonacci;
        }
        public static bool ConfirmaFibonacci(int num, int[] fibonacci, bool pertence)
        {
            for (var cont = 0; cont < 30; cont++)
            {
                if (num == fibonacci[cont])
                {
                    pertence = true;
                }
            }
            return pertence;
        }

    }
}