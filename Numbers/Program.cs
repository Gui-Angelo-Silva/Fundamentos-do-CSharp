using System;
using System.Globalization;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            decimal valor = 10.25m;
            // string.Format("{0:C}", valor);
            //valor.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR"));
        }
    }
}