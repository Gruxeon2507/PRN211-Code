namespace DelagateEvent
{
    public class Program
    {
        //Khai bao delegate
        delegate void MyDelegate1(int a, int b); //tro toi 1 ham void co 2 tham so nguyen
        delegate int MyDelegate2(int a,int b);
        delegate string MyDelegate3(string str);
        static void Main(string[] args)
        {   
            
            //Khi chua su dung Delegate
            Console.WriteLine("Not use delegate: ");
            Tong(12, 4);
            UCLN(12, 4);
            DienTich(12, 4);

            //Khi su dung Delegate
            Console.WriteLine("Use Delegate: ");

            //Cach tao ra delegate-C1
            MyDelegate1 dg = new MyDelegate1(Tong);
            dg += UCLN;
            dg += DienTich; 
            dg(3, 4);

            dg -= DienTich;
            dg(12, 4);
            //Cach tao ra delegate-C2
            //Dau tien cu tao theo c1
            MyDelegate2 dg2 = new MyDelegate2(Hieu);

            Console.WriteLine("a-b= "+dg2(5, 4));

            //Bat dau viet theo cach 2
            MyDelegate2 dg3 = delegate (int a, int b)
            {
                return a - b;
            };
            Console.WriteLine("a - b ="+ dg3(5,4));

            //bien doi delegate tren thanh...
            MyDelegate2 dg4 = (int a, int b) =>
            {
                return a - b;
            };
            Console.WriteLine("a - b = " + dg4(5, 4));

            //Bien hinh tiep
            MyDelegate2 dg5 = (a,b) => a - b;
            Console.WriteLine("a - b = " + dg5(5, 4));

            //Mot vi du khac ve Lambda
            MyDelegate3 dg6 = (string s) =>
            {
                return s.Substring(0,3);
            };
            Console.WriteLine("Substring(0,3)=" + dg6("FPT University"));

            MyDelegate3 dg7 = s => s.Substring(0, 3);
            Console.WriteLine("Substring(0,3)=" + dg7("FPT University"));
        }

        public static void Tong(int a,int b)
        {
            Console.WriteLine("a+b=" + (a + b));
        }

        public static void UCLN(int m ,int n)
        {
            while (m!=n)
            {
                if (m > n) m = m - n;
                else n = n - m;
            }
            Console.WriteLine("UCLN= "+n);
        }

        public static int Hieu(int a,int b)
        {
            return a - b;
        }
        public static void DienTich(int x,int y)
        {
            Console.WriteLine("S= " +(x*y));
        }
    }
}