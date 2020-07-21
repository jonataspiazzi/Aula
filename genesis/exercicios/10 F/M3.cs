using System;

namespace _10_F
{
    public class M3
    {
        public static int Soma()
        {
            var M = Apoio.ValordeM();
            var R = Apoio.ValordeR();
            var total = M + 3 + R;
            return total;
        }

        public static void Executar()
        {
            Console.WriteLine("O valor de M + 3 + R é: " + M3.Soma());
        }
    }
}