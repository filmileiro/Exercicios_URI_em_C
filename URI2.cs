﻿using System;
using System.Globalization;

namespace Uri3
{
    class Program
    {
        static void Main(string[] args)
        {
            double raio, n, area;

            n = 3.14159;

            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = n * Math.Pow(raio, 2);

            Console.WriteLine("A=" + area.ToString("F4"));





        }
    }
}
