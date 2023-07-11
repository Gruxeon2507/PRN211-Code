namespace Assignment_3_PT2_2
{
    public class Customers
    {
        public string CustomerCode { get; set; }
        public string CustomerName { get; set; }
        public bool Gender { get; set; }
        public string Address { get; set; }
        public DateTime DOB { get; set; }

        public Customers()
        {
            
        }

        public Customers(string customerCode, string customerName, bool gender, string address, DateTime dOB)
        {
            CustomerCode = customerCode;
            CustomerName = customerName;
            Gender = gender;
            Address = address;
            DOB = dOB;
        }
    }
}
