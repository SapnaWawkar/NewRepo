using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5_Assignment
{
    public class ConvertToInt
    {
        public static int ConvertToInteger(string str)
        {
            Console.WriteLine(str);
            int value;
            bool result = int.TryParse(Console.ReadLine(), out value);
            if (result)
            {
                return value;
            }
            else
            {
                Console.WriteLine("Wrong Input..Please enter a proper number\n");
                return ConvertToInteger(str);
            }


        }
    }
}
