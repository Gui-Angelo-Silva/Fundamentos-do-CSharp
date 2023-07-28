using System;

namespace DotnetLists
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[3];
            try
            {
                for (var index = 0; index < 10; index++)
                {
                    //IndexOutOfRangeException
                    Console.WriteLine(arr[index]);
                }
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.Message);
                Console.WriteLine("Não encontrei o índice na lista");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.Message);
                Console.WriteLine("Ops, algo deu errado!");
            }
        }
    }
}