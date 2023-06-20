using WinForm_EntityFramework2.Model;

namespace WinForm_EntityFramework2
{
    public partial class d : Form
    {
        public d()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            using (MySaleDBContext context = new MySaleDBContext())
            {
                var data = (from c in context.Customers select new
                {
                    CustomerId=c.CustomerId,
                    CustomerName=c.CustomerName,
                    Birthdate=c.Birthdate,
                    Address=c.Address,
                    Gender=c.Gender


                }).ToList();
                dataGridView1.DataSource = data;
                txtCustomerId.DataBindings.Add("Text", data, "CustomerId");
                txtName.DataBindings.Add("Text", data, "CustomerName");
                txtBirthdate.DataBindings.Add("Text", data, "Birthdate");
                txtAddress.DataBindings.Add("Text", data, "Address");
                chkMale.DataBindings.Add("Checked", data, "Gender");
                chkFemale.DataBindings.Add("Checked", data, "Gender",false);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
    }
}