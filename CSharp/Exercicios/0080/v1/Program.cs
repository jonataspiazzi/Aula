using System;

namespace v1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, qtd, temp1;
            temp1 = 0;
            qtd = 20;
            int[] conj_a = new int[qtd];
            conj_a[0] = 2;
            conj_a[1] = 6;
            conj_a[2] = 9;
            conj_a[3] = 13;
            conj_a[4] = 18;
            conj_a[5] = 20;
            conj_a[6] = 25;
            conj_a[7] = 29;
            conj_a[8] = 33;
            conj_a[9] = 35;
 
            for (i = 10; i < qtd; i++)
            {
                Console.Write("Digite o " + (i + 1) + "º número: ");
                conj_a[i] = int.Parse(Console.ReadLine());
 
                for (int j = 0; j < qtd; j++)
                {
                    if (conj_a[i] < conj_a[j])
                    {
                        temp1 = conj_a[i];
                        conj_a[i] = conj_a[j];
                        conj_a[j] = temp1;
                    }
                }
            }
 
            for (i = 0; i < qtd; i++)
            {
                 Console.WriteLine(conj_a[i]);
            }
        }
    }
}
