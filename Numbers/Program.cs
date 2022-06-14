using System;
using System.Globalization;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            decimal valor = 4510.25m;

            // Console.WriteLine(valor.ToString("C",
            //     CultureInfo.CreateSpecificCulture("pt-PT")));
            // Console.WriteLine(valor.ToString("P",
            //     CultureInfo.CreateSpecificCulture("pt-PT")));
            // Console.WriteLine(valor.ToString("N",
            //     CultureInfo.CreateSpecificCulture("pt-PT")));

            Console.WriteLine(Math.Round(valor));
            Console.WriteLine(Math.Ceiling(valor));
            Console.WriteLine(Math.Floor(valor));
        }
    }
}
