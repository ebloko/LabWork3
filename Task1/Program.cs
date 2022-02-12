using System;

namespace Task1
{
    class Program
    {
        static int Factorial(int i)
        {
            if (i < 0)
            {
                return -1;
            }
            if (i <= 1)
            {
                return 1;
            }
            return i * Factorial(i - 1);   
        }

        static void Main()
        {
            Console.Write("i -> ");
            int i = Int32.Parse(Console.ReadLine());
            Console.WriteLine(Factorial(i));
        }


    }
}
