using WinForm_EnityFramework.Models;

namespace WinForm_EnityFramework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            //List<Product> data = new List<Product>();
            using (MySaleDBContext context = new MySaleDBContext())
            {
                //Get du lieu tu db, su dung ef
                var data = context.Products.Select(p => new
                {
                    ID = p.ProductId,
                    Name = p.ProductName,
                    Price = p.UnitPrice,
                    Stock = p.UnitsInStock,
                    Image = p.Image,
                    CategoryName = p.Category.CategoryName
                }).OrderBy(p=>p.Price)
                    .ThenByDescending(p=>p.Stock)
                    .ToList();


                dgProduct.DataSource = data;

                //Load data cho vao combo box
                List<Category> data2 = context.Categories.ToList();

                cbnCategory.DataSource = data2;

                cbnCategory.DisplayMember = "CategoryName";
                cbnCategory.ValueMember = "CategoryId";
                //cbnCategory.SelectedVallue = valueMember

                //load du lieu tren cac textbox khac
                txtId.DataBindings.Clear();
                txtId.DataBindings.Add("Text", data, "ID");

                txtName.DataBindings.Clear();
                txtName.DataBindings.Add("Text", data, "Name");

                txtStock.DataBindings.Clear();
                txtStock.DataBindings.Add("Text", data, "Stock");

                txtPrice.DataBindings.Clear();
                txtPrice.DataBindings.Add("Text", data, "Price");

                txtImage.DataBindings.Clear();
                txtImage.DataBindings.Add("Text", data, "Image");

                cbnCategory.DataBindings.Clear();
                cbnCategory.DataBindings.Add("Text", data, "CategoryName");
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (MySaleDBContext context = new MySaleDBContext())
            {
                //tao 1 doi tuong product de add du lieu
                Product p = new Product()
                {
                    ProductName = txtName.Text,
                    UnitPrice = Decimal.Parse(txtPrice.Text),
                    UnitsInStock = Int32.Parse(txtStock.Text),
                    Image = txtImage.Text,
                    CategoryId = (int)cbnCategory.SelectedValue
                };
                //add vao db su dung ef
                context.Products.Add(p);
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (MySaleDBContext context = new MySaleDBContext())
            {
                //tim doi tuong product de update du lieu
                Product p = context.Products.FirstOrDefault(p => p.ProductId == Int32.Parse(txtId.Text));
                if (p == null)
                {
                    MessageBox.Show("product khong ton tai");
                    return;
                }
                //Update nhung thuoc tinh can thiet
                p.ProductName = txtName.Text;
                p.UnitPrice = Decimal.Parse(txtPrice.Text);
                p.UnitsInStock = Int32.Parse(txtStock.Text);
                p.Image = txtImage.Text;
                p.CategoryId = (int)cbnCategory.SelectedValue;

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
                Product p = context.Products.FirstOrDefault(p => p.ProductId == Int32.Parse(txtId.Text));
                if (p == null)
                {
                    MessageBox.Show("product khong ton tai");
                    return;
                }
                context.Products.Remove(p);

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
            using(MySaleDBContext context = new MySaleDBContext())
            {
                //link queue cach 1:
                //var data = context.Products.Where(p => p.ProductName.Contains(txtName.Text)).ToList();
                var data = (from p in context.Products
                            where p.ProductName.Contains(txtName.Text)
                            orderby p.UnitPrice,p.UnitsInStock descending
                           select new
                           {
                               ID = p.ProductId,
                               Name = p.ProductName,
                               Price = p.UnitPrice,
                               Stock = p.UnitsInStock,
                               Image = p.Image,
                               CategoryName = p.Category.CategoryName
                           }).ToList();
                dgProduct.DataSource = data;
            }
        }
    }
}