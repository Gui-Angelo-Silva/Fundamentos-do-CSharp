using System;
using System.Text;

namespace MyApp
{
    class Program 
    {
        static void Main(string[] args)
        {
            var texto = new StringBuilder();
            texto.Append("Este texto é um teste");
            texto.Append("é um teste");
            texto.Append("este texto");
            texto.Append("Este um teste");

            texto.ToString();
            Console.WriteLine(texto);
        }
    }
}