using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5_Assignment
{
    internal class Assignment2
    {
        public static void Execute()
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string path = desktopPath + @"\myFile1.txt";
            
            List<string> lines=new List<string>();
            List<User> people = new List<User>();
            lines = File.ReadAllLines(path).ToList();
            foreach (string line in lines)
            {
                string[] items = line.Split(' ');
                User p=new User(int.Parse(items[0]), items[1], items[2]);
                people.Add(p);
            }
            foreach (User p in people)
            {
                Console.WriteLine(p);
            }




            Console.ReadLine();
            
        }
    }
}
