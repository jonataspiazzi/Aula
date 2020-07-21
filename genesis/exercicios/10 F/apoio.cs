using System;

namespace _10_F
{
    public class Apoio
    {
        public static int ValordeM()
        {
            Console.WriteLine("Digite o valor de M");
            var M = int.Parse(Console.ReadLine());
            return M;
        }
        public static int ValordeR()
        {
            Console.WriteLine("Digite o valor de M");
            var R = int.Parse(Console.ReadLine());
            return R;
        }
        public static int Soma(int M, int R)
        {
            var A = 3;
            var total = M + A + R;
            return total;
        }

        public static void Mensagem(int M, int R)
        {
            Console.WriteLine("O total de M + 3 + R é: " + Soma(M, R));
        }
    }
}