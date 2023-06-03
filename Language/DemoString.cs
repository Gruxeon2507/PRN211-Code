using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Language
{
    internal class DemoString
    {
        public DemoString()
        {
            //Chứa code ôn lại và học vái mới về String trong C#
            string str = "FPT University!";
            String str1 = new String("I hate you");
            Console.WriteLine("Enter String");
            str = Console.ReadLine();
            name(str);
            //Coi s là chuỗi họ tên của mình
            //hiển thị họ, tên tên đệm của mình
             
        }
        public static void name(String s)
        {
            s = s.Trim();
            s = s.ToLower();
            string[] a = Regex.Split(s, @"\s+");
            //string[] a = Regex.Split(" ".ToLower\,StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = ""+a[i].Trim();
            }    
            Console.WriteLine(a.Length);
            Console.Write("first name: " + char.ToUpper(a[a.Length - 1][0]) + a[a.Length - 1].Substring(1) + "\n");
            Console.Write("last name: " + char.ToUpper(a[0][0]) + a[0].Substring(1) + "\n");
            Console.Write("sur name: ");
            for (int i = 1; i < a.Length - 1; i++)
            {
                if (a[i].Length>1)
                Console.Write(char.ToUpper(a[i][0]) + a[i].Substring(1)+" ");
                else
                {
                    Console.Write(char.ToUpper(a[i][0]) + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
