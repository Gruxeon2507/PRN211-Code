namespace Question1
{
    public partial class Form1 : Form
    {
        List<Product> data = new List<Product>();

        public Form1()
        {
            InitializeComponent();
            

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            List<Product> temp = data;
            Product product = new Product();
            product.ProductId = Int32.Parse(txtId.Text);
            product.ProductName= txtName.Text;
            product.Price = (double)numPrice.Value;
            if(btnTrue.Checked)
            {
                product.IsActive = true;
            }
            if(btnFalse.Checked)
            {
                product.IsActive = false;
            }
           data.Add(product);
           loaddata();
           
           
        }
        private void loaddata()
        {
            dataGrid.DataSource = data.ToList();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (data.Count>0)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filename = saveFileDialog.FileName;
                    using (StreamWriter sw = new StreamWriter(filename))
                    {
                        foreach (var item in data)
                        {
                            sw.WriteLine(item.ProductId+";"+item.ProductName+";"+item.Price+";"+item.IsActive);
                        }
                    }
                }

            }
            else
            {
                MessageBox.Show("The Data Is Empty");
            }
        }
    }
}