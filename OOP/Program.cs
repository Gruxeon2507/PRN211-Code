using System.Xml;

namespace OOP
{ 
    public class Program
    {
        static void Main(string[] args)
        {
            //Khai bao va khoi tao 1 List TEacher
            List<Teacher> data = new List<Teacher>()
            {
                new FullTime("T01","Nguyen Van A",2.0),
                new PartTime("T02","Nguyen Van B",10),
                new FullTime("T03","Nguyen Van C",1.5)
            };

            IManager m=new Manager(data);
            while (true) {
                Console.WriteLine("1. Input list teacher");
                Console.WriteLine("2. Show List teacher");
                Console.WriteLine("3. No Of Partime teacher have no slot > 10");
                Console.WriteLine("4. Total No Slot of parttime teacher");
                Console.WriteLine("5. Sort The List By Salary");
                Console.WriteLine("6. Teacher Whose Name Start With T");
                Console.WriteLine("7. Teacher Whose Coefficient < 2.0");
                Console.WriteLine("8. Highest Salary");
                Console.WriteLine("9. Save to file");
                Console.WriteLine("10. Load File");
                Console.WriteLine();
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        {
                            Console.WriteLine("Enter size: ");
                            int size = Convert.ToInt32(Console.ReadLine());
                            m.InputList(size);
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("List Teacher: ");
                            m.OutputList();
                            break;
                        }
                    case 3:
                        {
                            m.MoreThanTenSlotList();
                            break;
                        }
                    case 4:
                        {
                            m.TotalSlot();
                            break;
                        }
                    case 5:
                        {
                            m.SortBySalary();
                            break;
                        }
                    case 6:
                        {
                            m.NameStartWithT();
                            break;
                        }
                    case 7:
                        {
                            m.CoefficientSmallerThanTwo();
                            break;
                        }
                    case 8:
                        {
                            m.HigestSalaryList();
                            break;
                        }
                    case 9:
                        {
                            m.SaveFile();
                            break;
                        }
                    case 10:
                        {
                            m.LoadFile();
                            break;
                        }
                }
            }
        }
    }
}
