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
            var total = M + 3 + R;
            return total;
        }
        public static void Executar()
        {
            Console.WriteLine("O total de M + 3 + R é: " + Total(total));
        }
    }   
}