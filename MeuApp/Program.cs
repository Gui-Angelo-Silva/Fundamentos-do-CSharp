using System;

namespace MeuApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade = 18;
            int maioridade = 21;
            int idadeMaxima = 65;

            if (idade >= maioridade)
            {
                Console.WriteLine("É diferente");
            }
            else if (idade > 25)
            {
                Console.WriteLine("É igual");
            }
            else if (idade > 32)
            {
                Console.WriteLine("É igual");
            }
            else if (idade > 38)
            {
                Console.WriteLine("É igual");
            }
            else
            {
                Console.WriteLine("É igual");
            }

            Console.WriteLine("Finalizou o programa");
        }
    }
}