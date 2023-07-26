using System;

namespace MyApp
{
    class Program 
    {
        static void Main(string[] args)
        {
            var texto = "Este texto é um teste";
            Console.WriteLine(texto.StartsWith("Este"));
            Console.WriteLine(texto.StartsWith("este"));
            Console.WriteLine(texto.StartsWith("texto"));

            Console.WriteLine(texto.EndsWith("Este texto é um teste"));
            Console.WriteLine(texto.EndsWith("Testo"));
            Console.WriteLine(texto.EndsWith("xpro"));
        }
    }
}