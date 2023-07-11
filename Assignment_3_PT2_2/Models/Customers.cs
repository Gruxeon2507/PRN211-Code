namespace Assignment_3_PT2_2
{
    public class Customers
    {
        public string CustomerCode { get; set; }
        public string CustomerName { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string DOB { get; set; }

        public Customers()
        {
            
        }

        public Customers(string customerCode, string customerName, string gender, string address, string dOB)
        {
            CustomerCode = customerCode;
            CustomerName = customerName;
            Gender = gender;
            Address = address;
            DOB = dOB;
        }
    }
}
