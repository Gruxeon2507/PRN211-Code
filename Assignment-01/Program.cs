using Assignment_01;

namespace Assignment_01
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Khai bao va khoi tao 1 List TEacher
            List<Human> data = new List<Human>()
            {
                new Player(1,"ducKm","asdasd","striker",1000000,13),
            new Player(2, "ducKm", "asdasd", "striker", 123123, 15),
            new Player(3,"ducKm","asdasd","qwe",1023100,16),
            new Player(4,"ducKm","asdasd","adas",123231,17),
            new Player(5,"ducKm","asdasd","qwe",1023100,18)
        };

            iManager m = new Manager(data);
            while (true)
            {
                Console.WriteLine("1. Input list Players");
                Console.WriteLine("2. Show List Players");
                Console.WriteLine("3. Upadte Information");
                Console.WriteLine("4. Sum Striker Salary");
                Console.WriteLine("5. Max Salary Player");
                Console.WriteLine("6. Short By Shirt Number");
                Console.WriteLine();
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        {
                            Console.WriteLine("Enter size: ");
                            int size = Convert.ToInt32(Console.ReadLine());
                            m.inputList(size);
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("List Player: ");
                            m.outputList();
                            break;
                        }
                    case 3:
                        {
                            m.outputList();
                            Console.WriteLine("Update Info: ");
                            Console.WriteLine("Enter Player Code");
                            int code = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Player shirtnumber: ");
                            int shirtNumber = Convert.ToInt32(Console.ReadLine());
                       
                            Console.WriteLine("Salary: ");
                            double salary = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Change shirt number or salary? (0 for shirtnumber,1 for salary)");
                            int o = Convert.ToInt32(Console.ReadLine()); 
                            m.changePlayer(code,o,shirtNumber,salary);
                            break;
                        }
                    case 4:
                        {
                            m.sumStriker();
                            break;
                        }
                    case 5:
                        {
                            m.MaxLuong();
                            break;
                        }
                    case 6:
                        {
                            m.shortByShirtNum();
                            break;
                        }
                        default:
                        {
                            Console.WriteLine("Invalid Option");
                            break;
                        }
                }
            }
        }
    }
}