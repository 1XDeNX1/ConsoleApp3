﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите A: ");
            string A = Console.ReadLine();
            Console.Write("Введите B: ");
            string B = Console.ReadLine();
            Console.Write("Введите C: ");
            string C = Console.ReadLine();
            string t = B;
            string v = C;
            B = A;
            C = t;
            A = v;
            Console.WriteLine($"Значение A: {A}");
            Console.WriteLine($"Значение B: {B}");
            Console.WriteLine($"Значение C: {C}");
            Console.ReadKey();
        }
    }
}
