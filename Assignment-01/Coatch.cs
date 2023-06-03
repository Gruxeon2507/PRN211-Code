using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_01
{
    internal class Coatch:Human
    {
        public int YearOfExperience { get; set; }

        public Coatch()
        {
            
        }
        public Coatch(int code, string name, string address, string posision, double salary, int yearOfExperience) : base(code, name, address, posision, salary)
        {
            YearOfExperience = yearOfExperience;


        }
        public override string? ToString()
        {
            return Code + "\t" + Name + "\t" + Address + "\t" + Posision + "\t" + Salary + "\t" + YearOfExperience;
        }
    }
}
