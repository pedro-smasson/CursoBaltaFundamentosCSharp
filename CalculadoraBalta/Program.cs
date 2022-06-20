using System;

namespace CursoBalta
{
    public class Program
    {
        static float Valor1 { get; set; }
        static float Valor2 { get; set; }

        static void Main() => MenuEscolhas();

        static void MenuEscolhas()
        {
            Console.WriteLine("-----------------");
            Console.WriteLine("Escolha uma opção: \n" 
                            + "1 - Somar\n"
                            + "2 - Subtrair\n"
                            + "3 - Dividir\n"
                            + "4 - Multiplicar\n"
                            + "0 - Sair");

            Console.WriteLine("-----------------");
            Console.Write("Opção: ");

            string escolha = Console.ReadLine();

            switch (escolha)
            {
                case "1": Somar(); break;

                case "2": Subtrair(); break;

                case "3": Dividir(); break;

                case "4": Multiplicar(); break;

                case "0": Environment.Exit(0); break;

                default: Console.WriteLine("\nOpção Inválida!"); MenuEscolhas(); break;
            }

            MenuEscolhas();
        }

        static void InformarValores()
        {
            Console.Write("\nInforme o primeiro valor: ");
            Valor1 = float.Parse(Console.ReadLine());

            Console.Write("Informe o segundo valor: ");
            Valor2 = float.Parse(Console.ReadLine());
        }

        static void Somar()
        {
            InformarValores();
            Console.WriteLine($"\nResultado da soma: {Valor1 + Valor2}");
        }

        static void Subtrair()
        {
            InformarValores();
            Console.WriteLine($"\nResultado da subtração: {Valor1 - Valor2}");
        }

        static void Multiplicar()
        {
            InformarValores();
            Console.WriteLine($"\nResultado da multiplicação: {Valor1 * Valor2}");
        }

        static void Dividir()
        {
            InformarValores();

            if (Valor2 == 0)
            {
                Console.WriteLine("\nNão é possível dividir por zero!");
                Dividir();

                return;
            }

            Console.WriteLine($"\nResultado da divisão: {Valor1 / Valor2}");
        }
    }
}