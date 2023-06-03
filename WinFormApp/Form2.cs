using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

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
            List<TextBox> textBoxes = new List<TextBox>();
            List<Label> labels = new List<Label>();
            for (int i = 0; i < n; i++)
            {
                Label lbl = new Label();
                lbl.Text = "Enter text: " + (i + 1).ToString();
                lbl.Location = new System.Drawing.Point(24, 148 + i * 30);
                lbl.Size = new System.Drawing.Size(78, 32);
                this.Controls.Add(lbl);
                labels.Add(lbl);


                TextBox txt = new TextBox();
                txt.Location = new System.Drawing.Point(150, 148 + i * 30);
                txt.Size = new System.Drawing.Size(324, 39);
                this.Controls.Add(txt);
                textBoxes.Add(txt);

            }
            Button btnCreate = new Button();
            btnCreate.Text = "Submit";
            btnCreate.Location = new System.Drawing.Point(170, 148 + n * 30);
            this.Controls.Add(btnCreate);
            btnCreate.Click += (sender, e) => BtnCreate_Click(sender, e, n, textBoxes, labels, btnCreate);
        }

        string selectedValue;
        private void BtnCreate_Click(object? sender, EventArgs e, int n, List<TextBox> textBoxes, List<Label> labels, Button btnCreate)
        {
            for (int i = 0; i < n; i++)
            {
                RadioButton radioButton = new RadioButton();
                radioButton.Text = textBoxes[i].Text;
                radioButton.Location = new System.Drawing.Point(24, 148 + i * 30);
                radioButton.Size = new System.Drawing.Size(324, 39);
                this.Controls.Remove(textBoxes[i]);
                this.Controls.Remove(labels[i]);
                this.Controls.Add(radioButton);
                radioButton.CheckedChanged += RadioButton_CheckedChanged;
            }
            //selectedValue = this.Controls.
            
            btnCreate.Click +=  BtnCreate_Click2;


        }
        private void BtnCreate_Click2(object? sender, EventArgs e)
        {
            MessageBox.Show("Ban da chon: "+selectedValue);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Get the selected radio button's value
            RadioButton radioButton = (RadioButton)sender;
            selectedValue = radioButton.Text;
           
        }
    }
}
