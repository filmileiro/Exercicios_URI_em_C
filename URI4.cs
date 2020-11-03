using System;

namespace uriProduto
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, prod;

            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());

            Console.WriteLine("PROD = " + (prod = A * B));
        }
    }
}
