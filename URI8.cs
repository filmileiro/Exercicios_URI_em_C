using System;
using System.Globalization;
namespace Uri08
{
    class Program
    {
        static void Main(string[] args)
        {
            int funcionarios, horasTrabalhadas;
            double valorPorHora;
            double total;

            funcionarios = int.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            horasTrabalhadas = int.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            valorPorHora = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            total = (double)horasTrabalhadas * valorPorHora;

            Console.WriteLine("NUMBER = " + funcionarios);
            Console.WriteLine("SALARY = U$ " + total.ToString("F2"));

            




        }
    }
}
