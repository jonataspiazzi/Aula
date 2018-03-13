using System;

namespace v2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Test");

            int num, pos, i, cont, qtd = 20;
            int[] conj = new int[qtd];

            conj[0] = 2;
            conj[1] = 6;
            conj[2] = 9;
            conj[3] = 13;
            conj[4] = 18;
            conj[5] = 20;
            conj[6] = 25;
            conj[7] = 29;
            conj[8] = 33;
            conj[9] = 35;

            for (cont = 10; cont < qtd; cont++)
            {
                Console.Write("Digite o " + (cont + 1) + "º número: ");
                num = int.Parse(Console.ReadLine());

                pos = cont;

                for (i = 0; i < qtd; i++)
                {
                    if (num < conj[i])
                    {
                        pos = i;
                        break;
                    }
                }

                for (i = cont; i > pos; i--)
                {
                    conj[i] = conj[i - 1];
                }
                
                conj[pos] = num;
            }

            for (i = 0; i < qtd; i++)
            {
                Console.WriteLine("Conjunto[" + i + "] = " + conj[i]);
            }
        }
    }
}
