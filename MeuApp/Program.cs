using System;

namespace MeuApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var nome = RetornaNome("Guilherme", "Silva");
            Console.WriteLine(nome);
        }

        static string RetornaNome(string nome, string sobrenome)
        {
            return nome + " " + sobrenome;
        }
    }
}