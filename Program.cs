﻿using System;
 
namespace ryad
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите длину: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 2; i <= n; i += 2)
                Console.WriteLine(i);
        }

    }
}
