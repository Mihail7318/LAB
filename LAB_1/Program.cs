using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LAB_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double h, b, V, S;
            Console.WriteLine("Введите высоту h: ");
            h = Convert.ToDouble( Console.ReadLine());
            Console.WriteLine("Введите сторону b: ");
            b = Convert.ToDouble(Console.ReadLine());
            S = Math.Pow(b, 2);
            V =  (S * h)/3;
            Console.WriteLine("Объем пирамиды V: "+ Math.Round(V, 2));
            Console.ReadKey();
        }
    }
}
