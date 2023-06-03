using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_2_3
{
    public partial class Lunar : Form
    {
        public Lunar()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int normalYear;
            if (int.TryParse(txtCalYear.Text, out normalYear))
            {
                int lunarYear = GetLunarYear(normalYear);
                txtLunarYear.Text = lunarYear.ToString();
            }
            else
            {
                MessageBox.Show("Invalid input. Please enter a valid year.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private int GetLunarYear(int normalYear)
        {
            ChineseLunisolarCalendar calendar = new ChineseLunisolarCalendar();
            DateTime normalDate = new DateTime(normalYear, 1, 1);
            int lunarYear = calendar.GetYear(normalDate);
            return lunarYear;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
