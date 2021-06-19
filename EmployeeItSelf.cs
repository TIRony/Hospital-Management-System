using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public partial class EmployeeItSelf : Form
    {
        HospitalContext2 Context = new HospitalContext2();
        public EmployeeItSelf()
        {
            InitializeComponent();
        }

        private void EmployeeItSelf_Load(object sender, EventArgs e)
        {
            this.LoadData();
        }
        private void LoadData()
        {
            var employee = Context.Managers.FirstOrDefault(e => e.UserName == LoginHelper.LogIn.UserName);
            if (employee == null)
            {
                MetroFramework.MetroMessageBox.Show(this, "Your Data has clashed, Contrct to ADMIN");
                return;
            }
            txtID.Text = employee.ID.ToString();
            txtUserName.Text = employee.UserName;
            txtStatus.Text = employee.Status;
            txtPhone.Text = employee.PhnNo.ToString();
            txtMail.Text = employee.Mail;
            txtSalary.Text = employee.Salary.ToString();
            txtDOB.Text = employee.DOB.ToString();
            txtAddress.Text = employee.Address;
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserName.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Invalid");
                return;
            }
            try
            {
                int PhnNo = Int32.Parse(txtPhone.Text);
                int salary = Int32.Parse(txtSalary.Text);
                DateTime dob = DateTime.Parse(txtDOB.Text);
                Manager emp;

                if (txtID.Text == "")
                {
                    emp = new Manager();
                    Context.Managers.Add(emp);
                }
                else
                {
                    int id = Int32.Parse(txtID.Text);
                    emp = Context.Managers.FirstOrDefault(e2 => e2.ID == id);
                    if (emp == null)
                    {
                        MessageBox.Show("Enter Your Real UserName, If you donot know, Contact to ADMIN");
                        return;
                    }
                }
                emp.UserName = txtUserName.Text;
                emp.Mail = txtMail.Text;
                emp.Status = txtStatus.Text;
                emp.Address = txtAddress.Text;
                emp.DOB = dob;
                emp.Salary = salary;
                emp.PhnNo = PhnNo;

                Context.SaveChanges();

                this.LoadData();

                MetroFramework.MetroMessageBox.Show(this, "Successfully Update");

            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message);
            }
        }

    }
}
