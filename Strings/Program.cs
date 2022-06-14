using System;
using System.Text;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            

            var texto = new StringBuilder();
            texto.Append("Teste é uma dificuldade");
            texto.Append(" dificuldade");

            texto.ToString();

            Console.WriteLine(texto);
            
            /*
            var texto = " Teste é uma dificuldade ";
            Console.WriteLine(texto.Replace("uma","Isto"));
            Console.WriteLine(texto.Replace("e","OPA"));

            var divisao = texto.Split(" ");
            Console.WriteLine(divisao[0]);
            Console.WriteLine(divisao[1]);
            Console.WriteLine(divisao[2]);
            Console.WriteLine(divisao[3]);

            var resultado = texto.Substring(6,5);
            Console.WriteLine(resultado);

            Console.WriteLine(texto.Trim());
            */

            
            /*
            var texto = "Teste é uma dificuldade";
            Console.WriteLine(texto.ToLower());
            Console.WriteLine(texto.ToUpper());
            Console.WriteLine(texto.Insert(5," simples"));
            Console.WriteLine(texto.Remove(5, 10));
            Console.WriteLine(texto.Length);
            */

            /*
            var texto = "Teste é uma dificuldade";
            Console.WriteLine(texto.IndexOf("é"));
            Console.WriteLine(texto.LastIndexOf("e"));
            */

            /*
            //StringComparison.OrdinalIgnoreCase))
            //Equals existe para diversos objetos
            var texto = "Teste um";
            Console.WriteLine(texto.Equals("Teste um"));
            Console.WriteLine(texto.Equals("Teste Um"));
            */

            /*
            //StringComparison.OrdinalIgnoreCase))
            var texto = "Teste um";
            Console.WriteLine(texto.StartsWith("Teste"));
            Console.WriteLine(texto.StartsWith("teste"));
            Console.WriteLine(texto.EndsWith("Um"));
            Console.WriteLine(texto.EndsWith("um"));
            */

            /*
            var texto = "Teste um";
            //Console.WriteLine(texto.CompareTo("Teste"));
            //Console.WriteLine(texto.CompareTo("teste"));
            Console.WriteLine(texto.Contains("teste"));
            Console.WriteLine(texto.Contains("Teste"));
            Console.WriteLine(texto.Contains("Teste", StringComparison.OrdinalIgnoreCase));
            */

            /*
            var price = 10.2;
            //var texto = "price is " + price;
            //var texto = string.Format("Price {0} {1}",price, "OPA");
            //var texto = $"price {price}";
            var texto = $@"price {price}vdsvds 
            fdsfef";
            Console.WriteLine(texto);
            */

            /*
            //GUID gera ids 
            var id = Guid.NewGuid();
            id.ToString();
            Console.WriteLine(id);
            var id = new Guid("1e10dcaf-0869-4e96-8342-0ffdee28ca83");
            id.ToString();
            Console.WriteLine(id);
            */
            
        }
    }
}
