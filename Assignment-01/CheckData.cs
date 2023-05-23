using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_01
{
    internal class CheckData
    {
        public bool isNotNull(string s)
        {
            return s == null;
        }
        public static bool isDoubleNumber(string input)
        {
            double number;
            return double.TryParse(input, out number);
        }
        public static bool IsIntNumber(string input)
        {
            int number;
            return int.TryParse(input, out number);
        }
    }
}
