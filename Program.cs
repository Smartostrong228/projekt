﻿using System;

namespace Фибоначчи
{
    class Program
    {
        static void fibonachchiRecursiya(int x, int y)
        {
            if (y > 400)
            {
                return;
            }
            int z = x + y;
            x = y;
            y = z;
            Console.WriteLine(z);
            fibonachchiRecursiya(x,y);
        }

        static void fibonachchiCycle(int en)
        {
            int x = 0;
            int y = 1;
            for (int h = 0; h < en;h++)
            {
                int z = x + y;
                x = y;
                y = z;
                Console.WriteLine(z);
            }
        }

        static void Main(string[] args)
        {
            fibonachchiCycle(5);
        }

    }
}
