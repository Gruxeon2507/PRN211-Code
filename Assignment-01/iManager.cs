using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_01
{
    internal interface iManager
    {
        public void inputList(int size);

        public void outputList();
        public void changePlayer(int playerCode, int option, int shirtNumber, double salary);

        public double sumStriker();

        public void MaxLuong();
        public void shortByShirtNum();
    }
}
