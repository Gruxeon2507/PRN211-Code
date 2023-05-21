namespace EventDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tao ra 3 nut;
            Button btnAsa = new Button("ASA");
            Button btnHiru = new Button("HIRU");
            Button btnBAN = new Button("BAN");


            //gan su kien onClick cho 3 nut
            btnAsa.onClick += BtnAsa_onClick;
            btnHiru.onClick += BtnHiru_onClick;
            btnBAN.onClick += BtnBAN_onClick;
            //mo phong lapp co 3 nut: ASA, HIRU, BAN
            while (true)
            {
                Console.WriteLine("1.Button ASA");
                Console.WriteLine("2.Button HIRU");
                Console.WriteLine("3.Button BAN");
                Console.WriteLine("Please click a button: ");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        {
                            btnAsa.click();
                            break;
                        }
                    case 2:
                        {
                            btnHiru.click();
                            break;
                        }
                    case 3:
                        {
                            btnBAN.click();
                            break;
                        }
                }
            }
        }

        private static void BtnBAN_onClick(string name)
        {
            Console.WriteLine("You press " + name);
        }

        private static void BtnHiru_onClick(string name)
        {
            Console.WriteLine("You press " + name);
        }

        private static void BtnAsa_onClick(string name)
        {
            Console.WriteLine("You press "+name);
        }
    }
}