﻿namespace WinForm_ADO
{
    internal class Customer
    {
        public Customer()
        {
        }

        public string ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        public string Dob { get; set; }

        public Customer(string iD, string name, string address, string gender, string dob)
        {
            ID = iD;
            Name = name;
            Address = address;
            Gender = gender;
            Dob = dob;
        }
    }
}