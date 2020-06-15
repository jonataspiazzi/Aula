using System;

namespace v3
{
    public class Matematica
    {
        public static void ImprimeTabuada(int num)
        {
            Console.WriteLine("-----------");

            for (var i = 0; i <= 10; i++)
            {
                Console.WriteLine(num + " X " + i + " = " + (num * i));
            }
        }
    }
}