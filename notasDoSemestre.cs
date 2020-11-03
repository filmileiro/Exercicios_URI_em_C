using System;
using System.Globalization;

namespace notasDoSemestre
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, nota3, nota4, media;


            Console.WriteLine("Digite a primeira nota");
            nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Clear();

            Console.WriteLine("Digite a segunda nota");
            nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Clear();

            Console.WriteLine("Digite a terceira nota");
            nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Clear();

            Console.WriteLine("Digite a quarta nota nota");
            nota4 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Clear();

            media = (nota1 + nota2 + nota3 + nota4) / 4;

            Console.WriteLine("Sua média é " + media.ToString("F2"));

            

            
        }   
    }
}
