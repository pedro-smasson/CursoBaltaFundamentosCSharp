using System;
using System.Threading;

namespace Cronômetro
{
    class Program
    {
        static void Main() => Menu();

        static void Menu() 
        {
            Console.Write("0 - Sair\n");
            Console.Write("M - Tempo em minutos (2m)\n");
            Console.Write("S - Tempo em segundos (20s)\n");
            Console.Write("-----------------\n");
            Console.Write("Informe o tempo limite do cronômetro: ");

            string entrada = Console.ReadLine().ToLower();

            if (entrada == "0") { Environment.Exit(0); }

            char unidadeTempo = char.Parse(entrada.Substring(entrada.Length - 1, 1));
            int tempoLimite = int.Parse(entrada.Substring(0, entrada.Length - 1));
            int tempoEmSegundos = 1;

            if (unidadeTempo == 'm')
                tempoEmSegundos = 60;

            Inicio(tempoLimite * tempoEmSegundos);
        }

        static void Inicio(int tempoLimite) 
        {
            int tempoAtual = 0;

            while (tempoAtual != tempoLimite) 
            {
                Console.Clear();
                tempoAtual++;
                Console.WriteLine(tempoAtual + " seg");
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("Tempo limite finalizado!\n");
            Menu();
        }
    }
}