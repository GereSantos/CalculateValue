using System;
using System.Globalization;

namespace Exercise_Employee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Cdp, np, Cdp2, np2;
            double total, vlup1, vlup2;

            string[] valores = Console.ReadLine().Split(' ');

            Cdp = int.Parse(valores[0]);
            np = int.Parse(valores[1]);
            vlup1 = double.Parse(valores[2], CultureInfo.InvariantCulture);

            valores = Console.ReadLine().Split(' ');

            Cdp2 = int.Parse(valores[0]);
            np2 = int.Parse(valores[1]);
            vlup2 = double.Parse(valores[2], CultureInfo.InvariantCulture);

            total = (np * vlup1) + (np2 * vlup2);

            Console.WriteLine("Valor a pagar: " + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
