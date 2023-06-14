using Microsoft.Data.SqlClient;
using System.Data;
using System.Runtime.Intrinsics.Arm;
using System.Xml.Linq;

namespace Progress_Test_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DataProvider dp = new DataProvider();
        }
        DataProvider dp = new DataProvider();

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            List<Item> data = new List<Item>();
            //lay du lieu tu bang customer va add vao data
            using (IDataReader dr = dp.executeQuery2("SELECT WordID,Word,EditDate,Meaning,w.TypeName FROM Dictionary d JOIN WordType w on d.ID=w.ID"))
            {
                while (dr.Read())
                {
                    string id = dr.GetInt32(0).ToString();
                    string word = dr.GetString(1);
                    string meaning = dr.GetString(3);
                    string editDate = dr.GetDateTime(2).ToString();
                    string typeName = dr.GetString(4);
                    Item i = new Item(id, word, meaning, editDate, typeName);
                    data.Add(i);
                }
                dr.Close();
            }
            List<String> s = new List<String>();
            using (IDataReader dr = dp.executeQuery2("SELECT * FROM WordType"))
            {
                while (dr.Read())
                {
                    string typeName = dr.GetString(1);
                    s.Add(typeName);
                }
                dr.Close();
            }
            //add daata vao data grid

            dgWord.DataSource = data;
            cbnType.DataSource = s;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string strSQL = "SELECT WordID,Word,EditDate,Meaning,w.TypeName FROM Dictionary d JOIN WordType w on d.ID=w.ID WHERE TypeName=@type";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@word",txtWord.Text),
                new SqlParameter("@meaning",txtMeaning.Text),
                new SqlParameter("@type", cbnType.Text),
            };
            List<Item> data = new List<Item>();
            if (txtMeaning.Text.Length > 0) strSQL += " AND Meaning = @meaning";
            if (txtWord.Text.Length > 0) strSQL += " AND Word=@word";

            using (IDataReader dr = dp.executeQuery2(strSQL, parameters))
            {
                while (dr.Read())
                {
                    string id = dr.GetInt32(0).ToString();
                    string word = dr.GetString(1);
                    string meaning = dr.GetString(3);
                    string editDate = dr.GetDateTime(2).ToString();
                    string typeName = dr.GetString(4);
                    Item i = new Item(id, word, meaning, editDate, typeName);
                    data.Add(i);
                }
                dr.Close();
            }
            dgWord.DataSource = data;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgWord_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                txtMeaning.Text = "";
                txtWord.Text = "";
                cbnType.SelectedIndex = 0;
            }
            else
            {


                txtMeaning.Text = dgWord.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                txtWord.Text = dgWord.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                cbnType.Text = dgWord.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}