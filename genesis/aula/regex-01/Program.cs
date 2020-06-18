using System;
using System.Text.RegularExpressions;

namespace regex_01
{
    class Program
    {
        static void Main(string[] args)
        {
            // \w = (word) letras e numeros.
            // \d = (digit) digitos (numeros).
            // \s = (space) espaços, (em branco).
            // {minimo, maximo} = define a quantidade de vezes que deve ser encontrado.
            // {3, 50}
            // ? casa 0 ou 1 vezes. = {0,1}
            // * casa 0 a infinito. = {0, infinito}
            // + casa 1 a infinito. = {1 infinito}
            // . coringa (casa qualquer coisa)
            // (?<nome_do_grupo>...casamento...) cria um grupo.

            var regex = new Regex(@"\s*(?<dig1>\d+)\s*(?<operador>.)\s*(?<dig2>\d+)\s*");
            Console.WriteLine("Digite uma mensagem: ");

            var msg = Console.ReadLine();

            var m = regex.Match(msg);

            var dig1 = int.Parse(m.Groups["dig1"].Value);
            var funcao = m.Groups["operador"].Value;
            var dig2 = int.Parse(m.Groups["dig2"].Value);

            Console.WriteLine("Numero 1 = " + dig1);
            Console.WriteLine("Op = " + funcao);
            Console.WriteLine("Numero 2 = " + dig2);
        }
    }
}
