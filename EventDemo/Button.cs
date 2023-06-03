using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDemo
{
    //lop nay xay dung len 1 nut
    public class Button
    {
        public string Name { get; set; }

        public Button()
        {
            
        }
        public Button(string name)
        {
            Name = name;
        }

        //xay dung ham thao tac nhan nut
        public void click()
        {
            //Kich hoat su kien nhan nut
            if (onClick != null)//neu nut duoc gan su kien onclick
            {
                onClick(Name);
            }
            else
            {
                Console.WriteLine("Chua gan su kien cho nut "+Name);
            }
        }

        //tao su kien nhan nut cho 1 button
        public delegate void ButtonEventHandler(string name);
        public event ButtonEventHandler onClick;//su kien xay ra khi nhan nut

    }
}
