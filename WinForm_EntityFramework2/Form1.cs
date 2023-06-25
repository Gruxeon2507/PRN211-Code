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
                var data = (from c in context.Customers
                            select new
                            {
                                CustomerId = c.CustomerId,
                                CustomerName = c.CustomerName,
                                Birthdate = c.Birthdate,
                                Address = c.Address,
                                Gender = c.Gender


                            }).ToList();
                dataGridView1.DataSource = data;
                txtCustomerId.DataBindings.Add("Text", data, "CustomerId");
                txtName.DataBindings.Add("Text", data, "CustomerName");
                txtBirthdate.DataBindings.Add("Text", data, "Birthdate");
                txtAddress.DataBindings.Add("Text", data, "Address");

                // Set up data binding
                rdoMale.DataBindings.Add("Checked", data, "Gender");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (MySaleDBContext context = new MySaleDBContext())
            {
                //tao 1 doi tuong product de add du lieu
                bool gender;
                if (rdoMale.Checked) gender = true;
                else gender = false;
                Customer c = new Customer()
                {

                    CustomerName = txtName.Text,
                    Birthdate = DateTime.Parse(txtBirthdate.Text),
                    Address = txtAddress.Text,
                    Gender = gender
                };
                //add vao db su dung ef
                context.Customers.Add(c);
                if (context.SaveChanges() > 0)
                {
                    MessageBox.Show("Add success");
                }
                else
                {
                    MessageBox.Show("Add Failed");
                }
            }
            LoadData();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoMale.Checked)
            {
                // Update the current item in the BindingSource
                rdoFemale.Checked = false;
            }
            else
            {
                rdoMale.Checked = true;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (MySaleDBContext context = new MySaleDBContext())
            {
                //tim doi tuong product de update du lieu
                Customer c = context.Customers.FirstOrDefault(c => c.CustomerId == Int32.Parse(txtCustomerId.Text));
                if (c == null)
                {
                    MessageBox.Show("product khong ton tai");
                    return;
                }
                bool gender;
                if (rdoMale.Checked) gender = true;
                else gender = false;
                //Update nhung thuoc tinh can thiet
                c.CustomerName = txtName.Text;
                c.Birthdate = DateTime.Parse(txtBirthdate.Text);
                c.Address = txtAddress.Text;
                c.Gender = gender;

                if (context.SaveChanges() > 0)
                {
                    MessageBox.Show("Update success");
                }
                else
                {
                    MessageBox.Show("Update Failed");
                }
            }
            LoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (MySaleDBContext context = new MySaleDBContext())
            {
                //tim doi tuong product de update du lieu
                Customer c = context.Customers.FirstOrDefault(c => c.CustomerId == Int32.Parse(txtCustomerId.Text));
                if (c == null)
                {
                    MessageBox.Show("product khong ton tai");
                    return;
                }
                context.Customers.Remove(c);

                if (context.SaveChanges() > 0)
                {
                    MessageBox.Show("Delete success");
                }
                else
                {
                    MessageBox.Show("Delete Failed");
                }
            }
            LoadData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (MySaleDBContext context = new MySaleDBContext())
            {
                //link queue cach 1:
                //var data = context.Products.Where(p => p.ProductName.Contains(txtName.Text)).ToList();
                var data = (from c in context.Customers
                            where c.CustomerName.Contains(txtName.Text)
                            select new
                            {
                                CustomerId = c.CustomerId,
                                CustomerName = c.CustomerName,
                                Birthdate = c.Birthdate,
                                Address = c.Address,
                                Gender = c.Gender
                            }).ToList();
                dataGridView1.DataSource = data;
            }
        }
    }
}