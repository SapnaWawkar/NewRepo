﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5_Assignment
{
    internal class LINQ2
    {
        public static void Execute()
        {
            
            Console.WriteLine("Enter Year");
            int i = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Month");
            int j = int.Parse(Console.ReadLine());
            Console.WriteLine("No of Days in Month As Below");
            Console.WriteLine(System.DateTime.DaysInMonth(i, j));
            Console.WriteLine("No of Days in Year ");
            
            if ((i % 4 == 0 || i % 400 == 0) && (i % 100 != 0))
            {
                Console.WriteLine("366");
            }
            else
            {
                Console.WriteLine("365");
            }
            Console.ReadLine();
        }
    }
}
