﻿using System;

namespace MeuApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor = 0;
            // while (valor <= 5)
            // {   
            //     Console.WriteLine(valor);
            //     valor++; 
            // }
            do
            {
                Console.WriteLine(valor);
                valor++;
            } while (valor < 5);
        }
    }
}