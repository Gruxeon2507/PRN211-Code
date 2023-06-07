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
            Name = name;
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            this.Text = "Welcome" + Name;
        }
    }
}
