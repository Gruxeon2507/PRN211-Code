using System.Collections.Generic;

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

        Dictionary<string, string> map = new Dictionary<string, string>();
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
            try
            {
                string filename = "..\\..\\..\\data.txt";

                ////C1
                //StreamWriter sw = new StreamWriter(filename);
                //sw.WriteLine("Data");
                //sw.Close();


                //C2 Tu Dong Huy Sau Khi Chay xong
                using (StreamWriter sw = new StreamWriter(filename))
                {
                    foreach (var item in data)
                    {
                        sw.WriteLine(item.ToString());
                    }
                }
                MessageBox.Show("Save Success", "Alert", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Save fail: " + ex.Message, "Alert", MessageBoxButtons.OK);
                Console.WriteLine("Save fail: " + ex.Message);
            }
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

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstStudent.SelectedItems != null)
            {
                if (MessageBox.Show("Ban Co Muon Xoa?", "Alert", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    lstStudent.Items.Remove(lstStudent.SelectedItem);
                    data.Remove((Student)lstStudent.SelectedItem);
                    map.Remove(((Student)lstStudent.SelectedItem).Code);
                }
            }
            else
            {
                MessageBox.Show("Chua chon item de xoa");
                return;
            }

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                string filename = "..\\..\\..\\data.txt";
                using (StreamReader sr = new StreamReader(filename))
                {
                    string line = sr.ReadLine();
                    while (line != null)
                    {
                        //xu li khi doc tung line
                        line = line.Trim();

                        if (!string.IsNullOrEmpty(line))
                        {
                            Console.WriteLine(line);
                            string[] s = line.Split('\t');
                            Student student = new Student(s[0], s[1], Convert.ToInt32(s[3]), s[2]);
                            if (map.ContainsKey(student.Code))
                            {
                                continue;
                            }
                            data.Add(student);
                            lstStudent.Items.Add(student);
                            map.Add(student.Code, student.Name);

                        }

                        line = sr.ReadLine();
                    }
                    MessageBox.Show("Load Success ", "Alert", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Load fail: " + ex.Message, "Alert", MessageBoxButtons.OK);
                Console.WriteLine("Load fail: " + ex.Message);

            }
        }

        private void txtCode_TextChanged(object sender, EventArgs e)
        {
            foreach(Student item in data)
            {
                if (item.Code.Equals(txtCode.Text))
                {
                    txtNane.Text = item.Name;
                    cboSubject.Text = item.Subject;
                    numMark.Value = item.Mark;
                }
            }
        }
    }
}