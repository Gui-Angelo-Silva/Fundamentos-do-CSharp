using System;

namespace MeuApp 
{
    class Program
    {
        static void Main(string[] args) 
        {
            int inteiro = 100;
            float real = 25.8f;

            //real = inteiro; // 100.0f
            //inteiro = (int)real;
            //string valorReal = real.ToString();
            //inteiro = int.Parse("255");
            //inteiro = int.Parse(real.ToString());
            //inteiro = Convert.ToInt32(real);

            //Console.WriteLine(valorReal);
            Console.WriteLine(inteiro);
            Console.WriteLine(Convert.ToBoolean("true"));
            //Console.WriteLine(Convert.ToInt32(real));
        }
    }
} 