using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static double Pow(double x, int n)
        {
            if (n == 0)
                return 1;
            if (n < 0)
                return 1 / (Pow(x, -n));
            return x * Pow(x, n - 1);
        }

        static void Main()
        {
            Console.WriteLine("введите число х-");
            double x = Double.Parse(Console.ReadLine());
            Console.WriteLine("введите число н-");
            int n = Int32.Parse(Console.ReadLine());

            Console.WriteLine(Pow(x, n));
        }
    }
}
