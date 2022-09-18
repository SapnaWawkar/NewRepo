using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5_Assignment
{
    public class User
    {
        public User(int id, string name, string address)
        {
            this.id = id;
            this.name = name;
            this.address = address;
        }

        public int id { get; set; }
        public string name { get; set; }
        public string address { get; set; }

        public override string ToString()
        {
            return id+" "+name+" "+address;
        }
        
    }
}
