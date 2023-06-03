using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormApp
{
    public partial class FrmStart : Form
    {
        public FrmStart()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        int count = 10;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (count == 0)
            {
                timer1.Stop();
                Form2 f = new Form2(txtName.Text);
                f.Show();
                this.Hide();
            }
            lblCount.Text = count.ToString();
            count--;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
