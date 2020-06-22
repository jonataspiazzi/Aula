using System;

namespace calculadora
{
    public class funcoes
    {
        public static int soma(int numA, int numB)
        {
           int resultado = numA + numB;

           return resultado;
        }

         public static int subitracao(int numA, int numB)
        {
           int resultado = numA - numB;

           return resultado;
        }

         public static int divisao(int numA, int numB)
        {
           int resultado = numA / numB;

           return resultado;
        }

         public static int multiplicacao(int numA, int numB)
        {
           int resultado = numA * numB;

           return resultado;
        }
    }
}