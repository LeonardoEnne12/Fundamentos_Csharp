using System;

namespace DotnetLists
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            var meuArray = new int[5] {1,2,3,4,5};

            var teste = meuArray;

            var testee = 1;
            var testee2 = testee;
            testee = 3;

            meuArray[0] = 43;

            Console.WriteLine(teste[0]);
            Console.WriteLine(testee2);

            var funcionarios = new Funcionarios[5];
            funcionarios[0] =new Funcionarios() { Id = 23 , Name = "Leonardo"};
            
            // for (var i = 0; i < meuArray.Length; i++)
            // {
            //     Console.WriteLine(meuArray[i]);
            // }

            // foreach (var funcionario in funcionarios)
            // {
            //     Console.WriteLine(funcionario.Id);
            //     Console.WriteLine(funcionario.Name);
            // }

        }

        public struct Funcionarios
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }
    }
}
