using System;

namespace EditorHtml{

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
            HandleMenuOption(option);
        }

        public static void HandleMenuOption(short option)
        {
            switch(option)
            {
                case 1: Editor.Show(); break;
                case 2: Console.WriteLine("1");break;
                case 0: 
                {
                    Console.Clear();
                    Environment.Exit(0);
                };break;
                default: Show();break;
            }
        }
        public static void WriteOptions()
        {
            Console.SetCursorPosition(3,2);
            Console.WriteLine("Editor HTML");
            Console.SetCursorPosition(3,3);
            Console.WriteLine("==============");
            Console.SetCursorPosition(3,4);
            Console.WriteLine("Selecione uma opção abaixo");
            Console.SetCursorPosition(3,6);
            Console.WriteLine("1 - Novo arquivo");
            Console.SetCursorPosition(3,7);
            Console.WriteLine("2 - Abrir");
            Console.SetCursorPosition(3,9);
            Console.WriteLine("0 - sair");
            Console.SetCursorPosition(3,11);
            Console.Write("Opção: ");
        }
        public static void DrawScreen()
        {
            UpperLower(40);

            Middle(10,40);
                
            UpperLower(40);

        }
        public static void UpperLower(int column)
        {
            Console.Write("+");

            for (int i = 0; i<= column;i++)
            {
                Console.Write("-");
            }
            Console.Write("+");
            Console.Write("\n");
        }
         public static void Middle(int line, int column)
         {
            for(int lines = 0; lines <= line; lines++)
            {
                Console.Write("|");

                for (int i = 0; i<= column;i++)
                {
                Console.Write(" ");
                }

                Console.Write("|");
                Console.Write("\n");
            }
         }
    }
}