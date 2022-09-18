using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5_Assignment
{
    internal class LINQ3
    {
        public static void Execute()
        {
            var currentDate = DateTime.Now;
            var Date = new DateTime(currentDate.Year, currentDate.Month, currentDate.Day).AddDays(-(7 * 3));
            Console.WriteLine("Date Before 3 Weeks");
            Console.WriteLine(Date);
            Console.ReadLine();
        }
    }
}
