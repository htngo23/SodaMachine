﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            view thirsty = new view();
            thirsty.menu();
            Console.ReadLine();
        }
    }
}
