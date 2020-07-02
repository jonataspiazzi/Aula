using System;

namespace funcao_aula2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual versão voce deseja executar? ");
            var ver = int.Parse(Console.ReadLine());

            if (ver == 1)
            {
                ProgV1.Executar();
            }
            else if (ver == 2)
            {
                ProgV2.Executar();
            }
            else if (ver == 3)
            {
                ProgV3.Executar();
            }
            else if (ver == 4)
            {
                ProgV4.Executar();
            }
        }
    }
}
