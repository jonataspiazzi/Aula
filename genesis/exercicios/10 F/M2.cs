using System;

namespace _10_F
{
    public class M2
    {
        //Pq   MainWindow funcionou?
        static void MainWindow(string[] args)
        {
            Console.WriteLine("Digite o valor de M ");
            var M = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de R ");
            var R = int.Parse(Console.ReadLine());
        }
        public static int Total(int M, int R)
        {
            var A = 3;
            var total = M + A + R;
            return total;
        }
        public static void Executar(int M, int R)
        {
            Console.WriteLine("O total de M + 3 + R é: " + Total(M, R));
        }
    }   
}