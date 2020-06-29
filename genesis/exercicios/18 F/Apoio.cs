using System;

namespace _18F
{
    public class Apoio
    {
        public static int Comparacao(int numA, int numB)
        {
            int A = 0;
            if (numA > numB)
            {
                A = 1;
            }
            else if(numA < numB)
            {
                A = 0;
            }
            return A;

        }
    }
}
