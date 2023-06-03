using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignment_01
{
    internal class Player : Human
    {
        public int ShirtNumber { get; set; }

        public Player(int shirtNumber)
        {
            ShirtNumber = shirtNumber;
        }


        public Player()
        {
            
        }
        public Player(int code, string name, string address, string posision, double salary, int shirtNumber) : base(code, name, address, posision, salary)
        {
            ShirtNumber = shirtNumber;


        }

        public override string? ToString()
        {
            return ToString()+"\t"+ShirtNumber;
        }
    }
}
