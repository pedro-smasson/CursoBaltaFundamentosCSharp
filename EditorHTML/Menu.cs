using System;

namespace EditorHtml
{
    public static class Menu
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;

            DrawScreen();
            WriteOptions();

            var option = short.Parse(Console.ReadLine());
            HandleMenuOptions(option);
        }

        public static void DrawColumns() 
        {
            Console.Write("+");
            for (int i = 0; i <= 38; i++)
            {
                Console.Write("-");
            }
            Console.Write("+");
            Console.Write("\n");
        }

        public static void DrawLines() 
        {
            for (int lines = 0; lines <= 10; lines++)
            {
                Console.Write("|");
                for (int i = 0; i <= 38; i++)
                {
                    Console.Write(" ");
                }
                Console.Write("|");
                Console.Write("\n");
            }
        }

        public static void DrawScreen()
        {

            DrawColumns();

            DrawLines();

            DrawColumns();
        }

        public static void WriteOptions()
        {
            Console.SetCursorPosition(3, 2);
            Console.WriteLine("Editor HTML");
            Console.SetCursorPosition(3, 3);
            Console.WriteLine("===========");
            Console.SetCursorPosition(3, 4);
            Console.WriteLine("Selecione uma opção abaixo");
            Console.SetCursorPosition(3, 6);
            Console.WriteLine("1 - Novo arquivo");
            Console.SetCursorPosition(3, 7);
            Console.WriteLine("2 - Abrir");
            Console.SetCursorPosition(3, 9);
            Console.WriteLine("0 - Sair");
            Console.SetCursorPosition(3, 10);
            Console.Write("Opção: ");
        }

        public static void HandleMenuOptions(short option)
        {
            switch (option)
            {
                case 1: Editor.Show(); break;

                case 2: Viewer.Show(""); break;

                case 0: Environment.Exit(0); break;

                default: Show(); break;
            }
        }
    }
}