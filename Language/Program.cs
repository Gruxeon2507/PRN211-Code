
using System.Text.RegularExpressions;

namespace Language
{
    public class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("C# Language");
            int n;
            while (true)
            {
                try
                {
                    Console.Write("n= ");
                    n = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine("n= " + n);
                    break;
                }
                catch
                {
                    Console.WriteLine("invalid number");
                }
            }
            
            //Giong voi java: if,for,while
            //1.n la so chan hay le
            //2.Hien thi cac so tan cung la 3 tu 1 den n
            //3.n la so nguyen to hay khong
            //4.Hien thi n so nguyen to dau tien
            DisplayMenu(n);
          
            
        }
        private static void DisplayMenu(int n)
        {
            bool check = true;
            while (check)
            {

                Console.WriteLine("===================Option===================");
                Console.WriteLine("1. odd or equal");
                Console.WriteLine("2. all number from 1 to n that end with 3");
                Console.WriteLine("3. n is prime or not");
                Console.WriteLine("4. all prme number from 1 to n");
                Console.WriteLine("5. name conversion");
                 Console.WriteLine("6. demo list");
                Console.WriteLine("0. exit");
                Console.WriteLine("Select Function: ");
                int t;
                try
                {
                    t = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("invalid choice");
                    continue;
                }
               
                switch (t)
                {
                    case 1:
                        Console.WriteLine("1.");
                        if (n % 2 == 0)
                        {
                            Console.WriteLine("n chan");
                        }
                        else
                        {
                            Console.WriteLine("n le");
                        }
                        break;
                    case 2:
                        Console.WriteLine("2.");
                        for (int i = 0; i <= n; i++)
                        {
                            if (i % 10 == 3)
                            {
                                Console.Write(i + " ");
                            }
                        }
                        Console.WriteLine();
                        break;
                    case 3:
                        Console.WriteLine("3.");

                        if (isPrime(n))
                        {
                            Console.WriteLine("n la so nguyen to");
                        }
                        else
                        {
                            Console.WriteLine("n khong la so nguyen to");
                        }
                        break;
                    case 4:
                        Console.WriteLine("4.");
                        for (int i = 2; i <= n; i++)
                        {

                            if (isPrime(i))
                            {
                                Console.Write(i + " ");
                            }
                        }
                        Console.WriteLine();
                        break;
                    case 5:
                        DemoString demoString = new DemoString();
                        break;
                    case 6:
                        demoList();
                        break;
                    case 0:
                        check = false;
                        break;
                    default:
                        Console.WriteLine("invalid choice");
                        break;
                }
            }
        }

        private static void demoList()
        {

            List<string> list = new List<string>()
            {
                "Nguyen Van Ty",
                "Le Quang Hung",
                "Trinh Thanh Tung"
            };
            Console.WriteLine("Name List");
            foreach (string s in list)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("1:Ten cua nguoi co ho Nguyen");
            foreach (string s in list)
            {
                string[] a = Regex.Split(s, @"\s+");
                if (a[0].Equals("Nguyen")) Console.WriteLine(a[a.Length-1]);

            }
            //Console.WriteLine("2:");
            //foreach (string s in list)
            //{
            //    string[] a = Regex.Split(s, @"\s+");
            //    int sum = 0;
            //    if (a[0].Length<6)
            //    {
            //        for(int i=0;i<a.Length; i++)
            //        {
            //            sum += a.Length;
            //        }
            //    }
            //    Console.WriteLine(s+" length: "+sum);
            //}
            Console.WriteLine("2: Tinh tong so ki tu trong len ma nguoi co ho < 6");
            int total=0;
            foreach (string s in list)
            {
                string[] a = Regex.Split(s, @"\s+");
                int sum = 0;
                if (a[0].Length < 6)
                {
                    for (int i = 0; i < a.Length; i++)
                    {
                        sum += a[i].Length;
                    }
                }
                Console.WriteLine(s + " length: " + sum);
                total += sum;
            }
            Console.WriteLine("Total Length: "+total);

            Console.WriteLine("3: Nhung nguoi co ten bat dau boi ki tu T:");
            foreach (string s in list)
            {
                string[] a = Regex.Split(s, @"\s+");
                if (a[a.Length - 1][0] =='T')
                {
                    Console.WriteLine(s);
                }
            }
            Console.WriteLine("4: Nguoi co ten dai nhat");
            int max = 0;
            string maxS="";
            foreach (string s in list)
            {
                string[] a = Regex.Split(s, @"\s+");
                int sum = 0;

                for (int i = 0; i < a.Length; i++)
                {
                    sum += a[i].Length;
                }

                if (sum>max)
                {
                    max = sum;
                    maxS = s;
                }
               
            }
            Console.WriteLine("longestName "+maxS);
        }

        /// <summary>
        /// Kiểm tra số nguyên tố
        /// </summary>
        /// <param name="n"></param>
        /// <returns>true/false</returns>
        private static bool isPrime(int n)
        {
            bool isPrime = true;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
