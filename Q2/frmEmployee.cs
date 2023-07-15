using Q2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q2
{
    public partial class frmEmployee : Form
    {
        public frmEmployee()
        {
            InitializeComponent();
            Loaddata();
        }
        private void Loaddata()
        {
            using (PE_PRN_Sum21Context ctx = new PE_PRN_Sum21Context())
            {
                var data = ctx.Employees.ToList();
                dtgData.DataSource = data;
                txtName.DataBindings.Clear();
                txtName.DataBindings.Add("Text", data, "EmployeeName");

                txtPhone.DataBindings.Clear();
                txtPhone.DataBindings.Add("Text", data, "Phone");

                numSalary.Minimum = 0;
                numSalary.Maximum = 100000;
                numSalary.DataBindings.Clear();
                numSalary.DataBindings.Add("Value", data, "Salary");

                txtId.DataBindings.Clear();
                txtId.DataBindings.Add("Text", data, "EmployeeId");

                rdoMale.DataBindings.Clear();
                rdoMale.DataBindings.Add("Checked", data, "Male");
            }

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtgData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (PE_PRN_Sum21Context ctx = new PE_PRN_Sum21Context())
            {
                Employee em = new Employee();
                if (rdoMale.Checked)
                {
                    em.Male = true;
                }
                else
                {
                    em.Male = false;
                }
                em.Salary = (float)numSalary.Value;
                em.EmployeeName = txtName.Text;
                em.Phone = txtPhone.Text;
                ctx.Employees.Add(em);
                if (ctx.SaveChanges() > 0)
                {
                }
                else
                {

                }
            }
            Loaddata();
        }

        private void rdoMale_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoMale.Checked == false)
            {

                rdoFemale.Checked = true;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (PE_PRN_Sum21Context context = new PE_PRN_Sum21Context())
            {
                Employee em = context.Employees.FirstOrDefault(e => e.EmployeeId == Int32.Parse(txtId.Text));
                if (em == null)
                {
                    MessageBox.Show("Employee khong ton tai");
                    return;
                }
                //Update nhung thuoc tinh can thiet
                if (rdoMale.Checked)
                {
                    em.Male = true;
                }
                else
                {
                    em.Male = false;
                }
                em.Salary = (float)numSalary.Value;
                em.EmployeeName = txtName.Text;
                em.Phone = txtPhone.Text;

                if (context.SaveChanges() > 0)
                {

                }
                else
                {

                }

            }
            Loaddata();

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (PE_PRN_Sum21Context context = new PE_PRN_Sum21Context())
            {
                Employee em = context.Employees.FirstOrDefault(e => e.EmployeeId == Int32.Parse(txtId.Text));
                if (em == null)
                {
                    MessageBox.Show("Employee khong ton tai");
                    return;
                }
                context.Employees.Remove(em);

                if (context.SaveChanges() > 0)
                {

                }
                else
                {

                }

            }
            Loaddata();
        }
    }
}
