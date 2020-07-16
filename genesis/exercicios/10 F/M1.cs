using System;

namespace _10_F
{
    public class M1
    {
        public static int ValordeM()
         {
            Console.WriteLine("Qual o valor de M? ");
            int M = int.Parse(Console.ReadLine());
            return M;
         }
         public static int ValordeR()
         {
            Console.WriteLine("Qual o valor de R? ");
            int R = int.Parse(Console.ReadLine());
            return R;
         }
         public static int Soma(int M, int R, int total)
         {
            total = M + 3 + R;
            return total;
         }
        public static void Executar()
        {
            Console.WriteLine("O total de M + 3 + R é: ");
            Console.Write(Soma(total));
        }
    }
}