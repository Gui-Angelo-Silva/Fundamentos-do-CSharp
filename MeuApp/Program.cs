using System;

namespace MeuApp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool? valor = null;
            switch (valor)
            {
                case true: Console.WriteLine("Verdadeiro!"); break;
                case false: Console.WriteLine("Falso!"); break;
                default: Console.WriteLine("Nulo"); break;
            }
        }
    }
}