using System;

namespace MeuApp 
{
    class Program
    {
        static void Main(string[] args) 
        {
            int x = 12;
            bool entre = (x > 25) && (x < 40);
            bool ou = (x > 25) || (x < 40);
            bool negacao = !(x < 25);
            Console.WriteLine(entre);
            Console.WriteLine(ou);
            Console.WriteLine(negacao);
        }
    }
} 