using System;

namespace _31
{
    class Program
    {
        static void Main(string[] args)
        {
            int tempo, velocidade, distancia, litros;
            string texto;

           // Console.WriteLine("Quanto tempo levou a viagem");
           //texto = Console.ReadLine();
           // tempo = int.Parse(DateTime);

            Console.WriteLine("Quanto tempo levou a viagem");
            texto = Console.ReadLine();
            tempo = int.Parse(texto);

            Console.WriteLine("E qual a velocidade");
            texto = Console.ReadLine();
            velocidade = int.Parse(texto);

            distancia = tempo * velocidade;
            litros = distancia / 12;

            Console.WriteLine("Foram gastos" + " " + litros + " " + "litros de combustível");
        
        }
    }
}
