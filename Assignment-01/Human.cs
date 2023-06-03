using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_01
{
    internal abstract class Human
    {
        public int Code { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public string Posision { get; set; }

        public double Salary { get; set; }

        public Human()
        {
            
        }

        public Human(int code, string name, string address, string posision, double salary)
        {
            Code = code;
            Name = name;
            Address = address;
            Posision = posision;
            Salary = salary;
        }
        public override string? ToString()
        {
            return Code + "\t" + Name + "\t" + Address + "\t" + Posision + "\t" + Salary;
        }
    }
}
