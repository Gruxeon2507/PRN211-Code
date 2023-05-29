namespace WinFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Khai bao 1 list chua danh sach sinh vien
        List<Student> data = new List<Student>();
        private void Form1_Load(object sender, EventArgs e)
        {
            cboSubject.Items.Add("Japanese");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        Dictionary<string,string> map = new Dictionary<string,string>();
        private void button1_Click(object sender, EventArgs e)
        {
            
            Student s = new Student()
            {
                Code = txtCode.Text,
                Name = txtNane.Text,
                Subject = cboSubject.SelectedItem.ToString(),
                Mark = (int)numMark.Value
            };
            if (map.ContainsKey(s.Code))
            {
                MessageBox.Show(s.Code + " da ton tai");
                return;
            }
                data.Add(s);
            lstStudent.Items.Add(s);
            map.Add(txtCode.Text, txtNane.Text);

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //su kien xay ra khi nhan nut exit
            if (MessageBox.Show("Ban Co Muon Thoat Khong?", "Alert", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }

        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtCode_Enter(object sender, EventArgs e)
        {
            txtCode.BackColor = Color.Pink;
        }

        private void txtCode_Leave(object sender, EventArgs e)
        {
            txtCode.BackColor = Color.White;
        }

        private void txtNane_Enter(object sender, EventArgs e)
        {
            txtNane.BackColor = Color.Pink;
        }

        private void txtNane_Leave(object sender, EventArgs e)
        {
            txtNane.BackColor = Color.White;
        }
    }
}