using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_01
{
    internal class Manager : iManager
    {
        public List<Human> Data { get; set; }
        public Manager(List<Human>  data)
        {
            Data = data;
        }
        public void changePlayer(int playerCode, int option, int shirtNumber, double salary)
        {
            Player p = new Player();
            for(int i=0;i<Data.Count;i++)
            {
                if (Data[i] is Player && Data[i].Code == playerCode)
                {
                    p = (Player)Data[i];
                    if (option == 0)
                    {
                        ((Player)Data[i]).ShirtNumber= shirtNumber;
                    }
                    else if (option == 1)
                    {
                        ((Player)Data[i]).Salary=salary;
                    }
                }
            }
           
        }

        public void inputList(int size)
        {
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Player Code: ");
                int code = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Player Name: ");
                string name = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Player Address: ");
                string address = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Player shirtnumber: ");
                int shirtNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Player position: ");
                string position = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Salary: ");
                double salary = Convert.ToDouble(Console.ReadLine());

                Player p = new Player(code, name, address, position, salary, shirtNumber);

                Data.Add(p);
            }
        }

        public void MaxLuong()
        {
            double max = -1;
            foreach (Human p in Data)
            {
                if (p.Salary > max)
                {
                    max = p.Salary;
                }
            }
            foreach (Human p in Data)
            {
                if (max == p.Salary)
                {
                    Console.WriteLine(p);
                }
            }
        }

        public void outputList()
        {
            foreach (Human p in Data)
            {
                Console.WriteLine(p);
            }
        }

        public void shortByShirtNum()
        {
            for (int i = 0; i < Data.Count; i++)
            {
                for (int j = i + 1; j < Data.Count; j++)
                {
                    if (Data[i] is Player && Data[j] is Player && ((Player)Data[i]).ShirtNumber > ((Player)Data[j]).ShirtNumber)
                    {
                        (Data[j], Data[i]) = (Data[i], Data[j]);
                    }
                }
            }
        }

        public double sumStriker()
        {
            double sum = 0;
            foreach (Human human in Data)
            {
                if (human is Player && human.Posision == "striker")
                {
                    sum += human.Salary;
                }
            }
            Console.WriteLine("total salary of striker: "+sum);
            return sum;
        }
    }
}

