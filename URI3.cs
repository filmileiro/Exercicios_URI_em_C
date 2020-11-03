using System;
using System.Text.RegularExpressions;

namespace uriQuatro
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, soma;

            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());


            Console.WriteLine("SOMA = " + (soma = A + B));
        }
    }
}