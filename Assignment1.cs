using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5_Assignment
{
    internal class Assignment1
    {
        

        public static void Execute()
        {
            
            int a = ConvertToInt.ConvertToInteger("How many Users do you want to add?");
            
            int cnt = 0;
            string desktopPath=Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string path = desktopPath + @"\myFile.txt";

            List<User> list = new List<User>();
            while (cnt<a)
            {
                Console.WriteLine("Enter your Id");
                int id=int.Parse(Console.ReadLine());
                Console.WriteLine("Enter your name");
                string name=Console.ReadLine();
                Console.WriteLine("Enter your Address");
                string address=Console.ReadLine();
                
                list.Add(new User{id=id,name=name,address=address});
                cnt++;
            }
            foreach (User user in list)
            {
                Console.WriteLine(user.ToString());
            }
            List<string> list1 = new List<string>();
            foreach (User user in list)
            {
                list1.Add(user.ToString());
            }
           
            foreach (string line in list1)
            {
                list1.Add(line.ToString());
            }
            try
            {
                File.WriteAllLines(path, list1);
            }
            catch(Exception e)
            {
                throw new InvalidOperationException();
                
            }
            
            File.ReadAllLines(path);
          
        }

    }
}
