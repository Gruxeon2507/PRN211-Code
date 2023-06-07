using Microsoft.Data.SqlClient;
using System.Data;

namespace WinForm_ADO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataProvider d = new DataProvider();

        }
        DataProvider d = new DataProvider();
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //String strSelect = "SELECT * FROM Users " +
            //    "WHERE Account = '" + txtAccount.Text  +"' AND Password = '" + txtPassword.Text + "'";
            //DataTable dt = d.executeQuery(strSelect);
            //if(dt.Rows.Count > 0)
            //{
            //    MessageBox.Show("Login Success");
            //}
            //else
            //{
            //    MessageBox.Show("Login Failed");
            //}

            String strSelect = "SELECT * FROM Users " +
             "WHERE Account = @acc AND Password = @pwd";
            SqlParameter[] parameters = {
                new SqlParameter("@acc",txtAccount.Text),
                new SqlParameter("@pwd",txtPassword.Text)
            };
            using (IDataReader dr = d.executeQuery2(strSelect, parameters))
            {
                if (dr.Read())
                {
                    dr.Close();
                    MessageBox.Show("Login Success");
                    String name = getNameByAccount(txtAccount.Text);
                    frmCustomer frmCustomer = new frmCustomer(name);
                    this.Hide();
                    frmCustomer.Show();

                }
                else
                {
                    MessageBox.Show("Login Failed");
                }
            }

        }

        private string getNameByAccount(string text)
        {
            String strSelect = "SELECT * FROM Users " +
             "WHERE Account = @acc";
            String name;
            SqlParameter[] parameters = {
                new SqlParameter("@acc",txtAccount.Text),
            };
            using (IDataReader dr = d.executeQuery2(strSelect, parameters))
            {
                if (dr.Read())
                {
                    name = dr.GetString(2);
                    return name;
                }
                else
                {
                    MessageBox.Show("Err");

                }
            }
                
            return "";
        }
    }
}