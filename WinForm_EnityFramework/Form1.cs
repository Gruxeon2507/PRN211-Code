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
        MySaleDBContext context = new MySaleDBContext();
        private void LoadData()
        {
            List<Product> data = new List<Product>();

            //Get du lieu tu db, su dung ef
            data = context.Products.ToList();

            dgProduct.DataSource = data;

            //Load data cho vao combo box
            List<Category> data2 = context.Categories.ToList();

            cbnCategory.DataSource = data2;

            cbnCategory.DisplayMember = "CategoryName";
            cbnCategory.ValueMember = "CategoryId";
            //cbnCategory.SelectedVallue = valueMember

            //load du lieu tren cac textbox khac
            txtId.DataBindings.Clear();
            txtId.DataBindings.Add("Text", data, "ProductId");

            txtName.DataBindings.Clear();
            txtName.DataBindings.Add("Text", data, "ProductName");

            txtStock.DataBindings.Clear();
            txtStock.DataBindings.Add("Text", data, "UnitsInStock");

            txtPrice.DataBindings.Clear();
            txtPrice.DataBindings.Add("Text", data, "UnitPrice");

            txtImage.DataBindings.Clear();
            txtImage.DataBindings.Add("Text", data, "Image");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}