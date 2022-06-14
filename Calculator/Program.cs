using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();

        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("Qual conta deseja fazer?");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtracao");
            Console.WriteLine("3 - Divisao");
            Console.WriteLine("4 - Multiplicacao");
            Console.WriteLine("5 - Sair");

            Console.WriteLine("--------------");

            short res = short.Parse(Console.ReadLine());

            switch(res)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: System.Environment.Exit(0); break;
                default: Menu();break;
            }


        }

        static void Soma()
        {
            Console.Clear();
            Console.WriteLine("Primeiro Valor: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo Valor: ");
            float v2 = float.Parse(Console.ReadLine());
            
            var resultado = v1 + v2;
            Console.WriteLine("O valor da soma é " + resultado);
            // Console.WriteLine($"O valor da soma é {v1 + v2}");
            Console.ReadKey();
            Menu();

        }

        static void Subtracao()
        {
            Console.Clear();
            Console.WriteLine("Primeiro Valor: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo Valor: ");
            float v2 = float.Parse(Console.ReadLine());
            
            var resultado = v1 - v2;
            Console.WriteLine("O valor da subtracao é " + resultado);
            Console.ReadKey();
            Menu();

        } 

        static void Divisao()
        {
            Console.Clear();
            Console.WriteLine("Primeiro Valor: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo Valor: ");
            float v2 = float.Parse(Console.ReadLine());
            
            if(v2 != 0)
            {
                var resultado = v1/v2;
                Console.WriteLine("O valor da divisao é " + resultado);
            }
            else
            {
                Console.WriteLine("Nao é possivel fazer essa divisao");
            }
            Console.ReadKey();
            Menu();

        }

        static void Multiplicacao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro Valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Valor: ");
            float v2 = float.Parse(Console.ReadLine());

            var resultado = v1 * v2;
            Console.WriteLine($"O valor da multiplicacao é {resultado}");
            Console.ReadKey();   
            Menu();         
        }   
    }
}
