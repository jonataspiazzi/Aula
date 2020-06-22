using System;

namespace _9C
{
    public class Funcao
    {
        public static int Soma(int m, int n)
        {
            var resultado = m + n;
            return resultado;
        }

        public static int Subitracao(int n, int m)
        {
            var resultado = m - n;
            return resultado;
        }

        public static int Divisao(int numA, int numB)
        {
            var resultado = numA / numB;
            return resultado;
        }

        public static int Multiplicacao(int numA, int numB)
        {
            var resultado = numA * numB;
            return resultado;
        }
    }
}