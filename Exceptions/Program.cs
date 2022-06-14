using System;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[3];
            Console.Clear();

            try
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine(arr[i]);
                } 

                Cadastrar("OPA");  
            }

            

            catch (IndexOutOfRangeException ex) // sempre tratar erros do mais especifico para o mais generico
            {
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.Message);
                Console.WriteLine("Não encontrei esse índice");
            }

            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Não deu pra cadastrar");
            }

            catch (MinhaException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.QuandoAconteceu);
                Console.WriteLine("Não deu pra cadastrar");
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Vish,deu ruim :/");
            }

            finally
            {
                Console.WriteLine("Terminou");
            }
        }

        private static void Cadastrar(string texto)
        {
            if (string.IsNullOrEmpty(texto))
            {
                throw new MinhaException(DateTime.Now);
                //throw new Exception("O texto não pode ser nulo ou vazio");
            }
        }

        public class MinhaException : Exception
        {
            public MinhaException(DateTime date)
            {
                QuandoAconteceu = date;
            }
            public DateTime QuandoAconteceu { get; set; }
        }
    }
}
