using System;
using System.Globalization;

namespace compraProdutos
{
    class Program
    {
        static void Main(string[] args)
        {
            double produto1, produto2, soma, desconto, total;

            produto1 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            produto2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            soma = produto1 + produto2;

            desconto = (soma * 20) / 100;

            total = soma - desconto;


            Console.WriteLine();
            Console.WriteLine("Valor do produto " + soma + ",00 R$");
            Console.WriteLine();
            Console.WriteLine("desconto " + desconto + ",00 R$");
            Console.WriteLine();
            Console.WriteLine("Total a pagar " + total + ",00 R$");


        }
    }
}
