using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class FullTime : Teacher
    {
        public double HeSo { get; set; }

        //ctor + tab
        public FullTime()
        {
            
        }

        public FullTime(string code, string name, double heso) : base(code, name)
        {
               HeSo = heso;
        }

        public override double GetSalary()
        {
            return HeSo*1800000;
        }
    }
}
