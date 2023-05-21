using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public abstract class Teacher
    {
        //Thuoc Tinh: prop + tab
        public string Code { get; set; }
        
        //propfull + tab
        private string _name;
            
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        //Phuong Thuc
        public Teacher() 
        {

        }
        public Teacher(string code, string name)
        {
            Code = code;
            Name = name;
        }
        public override string? ToString()
        { 
            return Code+"\t"+Name+"\t"+GetSalary();
        }
        public abstract double GetSalary();
    }
}
