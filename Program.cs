using System;

namespace algoritmi1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            IsSimpleSilo(number);
        }
        static void IsSimpleSilo(int number)
        {
            int d = 0;
            int i = 2;
            while (i < number)
            {
                if (number % i == 0)
                {
                    d++;
                    i++;
                }
                if (d == 0)
                {
                    Console.WriteLine("Число простое");
                }
                else
                {
                    Console.WriteLine("Число не простое");
                }

            }
            
        }
    }
}