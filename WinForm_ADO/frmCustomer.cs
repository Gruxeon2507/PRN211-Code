using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm_ADO
{
    public partial class frmCustomer : Form
    {
        public frmCustomer()
        {
            InitializeComponent();
        }

        public frmCustomer(string name)
        {
            InitializeComponent();
            Text = "Welcome " + name;

        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        DataProvider dp = new DataProvider();
        private void LoadData()
        {
            List<Customer> data = new List<Customer>();
            //lay du lieu tu bang customer va add vao data
            using (IDataReader dr = dp.executeQuery2("SELECT * FROM Customers"))
            {
                while (dr.Read())
                {
                    string id = dr.GetInt32(0).ToString();
                    string name = dr.GetString(1);
                    string gender = dr.GetBoolean(3).ToString();
                    string dob = dr.GetDateTime(2).ToString();
                    string address = dr.GetString(4);
                    Customer c = new Customer(id, name, address, gender, dob);
                    data.Add(c);
                }
                dr.Close();
            }

            //add daata vao data grid

            dgCustomer.DataSource = data;


        }

        private void dgCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dgCustomer.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
            txtName.Text = dgCustomer.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
            txtAddress.Text = dgCustomer.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
            txtDob.Text = dgCustomer.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
            if (dgCustomer.Rows[e.RowIndex].Cells[3].FormattedValue.ToString().Equals("True"))
            {
                btnGender.Checked = true;
                btnGender2.Checked = false;
            }
            else
            {
                btnGender.Checked = false;
                btnGender2.Checked = true;
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string strSQL = "DELETE FROM Customers WHERE CustomerId = @id";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@id",txtID.Text)
            };
            if (dp.executeNonQuery(strSQL, parameters))
            {
                MessageBox.Show("Delete Success");
                LoadData();
            }
            else
            {
                MessageBox.Show("Delete Failed");
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string strSQL = "INSERT INTO Customers(CustomerName,Birthdate,Gender,Address) VALUES(@name,@dob,@gender,@address)";
            SqlParameter gender;
            if (btnGender.Checked)
            {
                gender = new SqlParameter("@gender", "True");
            }
            else
            {
                gender = new SqlParameter("@gender", "False");

            }
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@id",txtID.Text),
                new SqlParameter("@name",txtName.Text),
                gender,
                new SqlParameter("@dob",txtDob.Text),
                new SqlParameter("address",txtAddress.Text)


            };
            if (dp.executeNonQuery(strSQL, parameters))
            {
                MessageBox.Show("Insert Success");
                LoadData();
            }
            else
            {
                MessageBox.Show("Insert Failed");

            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtName.Text = "";
            txtDob.Text = "";
            txtAddress.Text = "";
            btnGender.Checked = false;
            btnGender2.Checked = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string strSQL = "UPDATE Customers SET CustomerName = @name,Birthdate = @dob, Gender = @gender, Address = @address WHERE CustomerId = @Id";
            SqlParameter gender;
            if (btnGender.Checked)
            {
                gender = new SqlParameter("@gender", "True");
            }
            else
            {
                gender = new SqlParameter("@gender", "False");

            }
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@id",txtID.Text),
                new SqlParameter("@name",txtName.Text),
                gender,
                new SqlParameter("@dob",txtDob.Text),
                new SqlParameter("address",txtAddress.Text)


            };
            if (dp.executeNonQuery(strSQL, parameters))
            {
                MessageBox.Show("Update Success");
                LoadData();
            }
            else
            {
                MessageBox.Show("Update Failed");

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
