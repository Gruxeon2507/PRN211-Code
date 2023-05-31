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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(string text)
        {
            InitializeComponent();
            Text = "Welcome " + text;
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int n = (int)numText.Value;
            for(int i = 0; i < n; i++)
            {
                Label lbl = new Label();
                lbl.Text ="Enter text: " +  (i+1).ToString();
                lbl.Location = new System.Drawing.Point(24, 148+i*30);
                lbl.Size = new System.Drawing.Size(78, 32);
                this.Controls.Add(lbl);

                TextBox txt = new TextBox();
                txt.Location = new System.Drawing.Point(150, 148+i*30);
                txt.Size = new System.Drawing.Size(324, 39);
                this.Controls.Add(txt);

            }
        }
    }
}
