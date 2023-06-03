using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace OOP
{
    public class Manager : IManager
    {
        public List<Teacher> Data { get; set; }
        public Manager()
        {

        }

        public Manager(List<Teacher> data)
        {
            this.Data = data;
        }

        public void InputList(int size)
        {
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Enter Code: ");
                string code = Console.ReadLine();
                Console.WriteLine("Enter Name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Fulltime or PartTime?(0-Full Time, 1-Part Time)");
                int option = Convert.ToInt32(Console.ReadLine());
                if (option == 0)
                {
                    Console.WriteLine("Enter he so: ");
                    double heso = Convert.ToDouble(Console.ReadLine());
                    Teacher T = new FullTime(code, name, heso);
                    Data.Add(T);

                }
                else
                {
                    Console.WriteLine("Enter Slot");
                    int slot = Convert.ToInt32(Console.ReadLine());
                    Teacher T = new PartTime(code, name, slot);
                    Data.Add(T);
                }
            }
        }

        public void OutputList()
        {
            foreach (var item in Data)
            {
                Console.WriteLine(item);
            }
        }

        public void HigestSalaryList()
        {
            double max = -1;
            foreach (var item in Data)
            {
                if (item.GetSalary() > max)
                {
                    max = item.GetSalary();
                }
            }
            foreach (var item in Data)
            {
                if (item.GetSalary() == max)
                {
                    Console.WriteLine(item.Name);
                }
            }
        }

        public void MoreThanTenSlotList()
        {
            Console.Write("No Teacher Have More Than Ten Slot: ");
            int count = 0;
            foreach (Teacher item in Data)
            {
                try
                {
                    PartTime t = (PartTime)item;
                    if (t.Slot >= 10)
                    {
                        count++;
                    }
                }
                catch (Exception)
                {
                    continue;
                }

            }
            Console.WriteLine(count);
        }

        public void TotalSlot()
        {
            Console.Write("Total Slot Of Partime Teacher: ");
            int total = 0;
            foreach (Teacher item in Data)
            {
                try
                {
                    PartTime t = (PartTime)item;
                    total += t.Slot;
                }
                catch (Exception)
                {
                    continue;
                }

            }
            Console.WriteLine(total);
        }

        public void SortBySalary()
        {
            Console.WriteLine("Sort Teacher By Salary");
            for (int i = 0; i < Data.Count; i++)
            {
                for (int j = i + 1; j < Data.Count; j++)
                {
                    if (Data[i].GetSalary() > Data[j].GetSalary())
                    {
                        (Data[j], Data[i]) = (Data[i], Data[j]);
                    }
                }
            }


            foreach (var item in Data)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public void NameStartWithT()
        {
            Console.WriteLine("Teacher Has Name Start With T:");
            foreach (var item in Data)
            {
                string[] arr = Regex.Split(item.Name, @"\s+");
                if (arr[arr.Length - 1][0] == 'T')
                {
                    Console.WriteLine(item.ToString());
                }


            }
        }

        public void CoefficientSmallerThanTwo()
        {
            Console.WriteLine("Teacher Has Coefficient Smaller Than Two");
            foreach (Teacher item in Data)
            {
                try
                {
                    FullTime t = (FullTime)item;
                    if (t.HeSo < 2)
                    {
                        Console.WriteLine(t.ToString());
                    }
                }
                catch (Exception)
                {
                    continue;
                }

            }
        }

        public void SaveFile()
        {
            try
            {
                string filename = "..\\..\\..\\data.txt";

                ////C1
                //StreamWriter sw = new StreamWriter(filename);
                //sw.WriteLine("Data");
                //sw.Close();


                //C2 Tu Dong Huy Sau Khi Chay xong
                using (StreamWriter sw = new StreamWriter(filename))
                {
                    foreach (var item in Data)
                    {
                        if (item is FullTime)
                        {
                            sw.WriteLine(item + "\t0");

                        }
                        else
                        {
                            sw.WriteLine(item + "\t1");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Save fail: " + ex.Message);
            }
        }

        public bool CheckCode(List<Teacher> Data,string code)
        {
            foreach(Teacher item in Data)
            {
                if (item.Code.Equals(code))
                {
                    return false;
                }
            }
            return true;
        }
        public void LoadFile()
        {
            Data.Clear();
            try
            {
                string filename = "..\\..\\..\\data.txt";
                using (StreamReader sr = new StreamReader(filename))
                {
                    string line = sr.ReadLine();
                    while (line != null)
                    {
                        //xu li khi doc tung line
                        line = line.Trim(); 

                        if (!string.IsNullOrEmpty(line)) 
                        {
                            Console.WriteLine(line);
                            string[] s = line.Split('\t');
                            if (s.Length == 4)
                            {
                                string code = s[0];
                                if (CheckCode(Data, code))
                                {
                                    string name = s[1];
                                    double salary = Convert.ToDouble(s[2]);
                                    if (s[3].Equals("0"))
                                    {
                                        double heso = salary / 2000000;
                                        Teacher T = new FullTime(code, name, heso);
                                        Data.Add(T);
                                    }
                                    else
                                    {
                                        int slot = (int)salary / 100000;
                                        Teacher T = new FullTime(code, name, slot);
                                        Data.Add(T);
                                    }
                                }
                                
                            }

                        }

                        line = sr.ReadLine();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Load fail: " + ex.Message);
            }
        }
    }
}
