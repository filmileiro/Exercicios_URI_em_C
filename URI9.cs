using System;
using System.Globalization;

namespace Uri09
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double salariofixo, valorVendas, total;



            nome = Console.ReadLine();
            salariofixo = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            valorVendas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            total = ((valorVendas * 15.0) / 100) + salariofixo;

            Console.WriteLine("TOTAL = R$ " + total.ToString("F2"));



            


        }
    }
}
