using System;

namespace MyApp
{
    class Program 
    {
        static void Main(string[] args)
        {
            var id = Guid.NewGuid();
            id.ToString();

            id = new Guid("b108e9b4-c7a3-4f05-b0ab-4dca396e1b06");

            id = new Guid();
            Console.WriteLine(id);
        }
    }
}