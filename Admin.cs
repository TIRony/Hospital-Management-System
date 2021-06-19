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
    public partial class Employee : Form
    {
        HospitalContext2 Context = new HospitalContext2();
        public Employee()
        {
            InitializeComponent();
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            this.Init();
        }
        private void Init()
        {
            txtSearch.Text = txtID.Text = txtUserName.Text = txtPhone.Text = txtMail.Text = txtSalary.Text = txtAddress.Text = "";
            this.LoadDetails();
        }
        private void LoadDetails()
        {
            var employee = Context.Managers.ToList();

            if (txtSearch.Text != null)
            {
                employee = employee.Where(e => (e.UserName).Contains(txtSearch.Text)).ToList();
                //employee = employee.Where(p => (p.PhnNo.ToString()).Contains(txtSearch.Text)).ToList();
            }
            dgvDetails.DataSource = employee.ToList();
            dgvDetails.Refresh();
            if (employee.Count > 0)
            {
                this.LoadData(employee.First().ID);
            }
            else {
                this.New();
            }
            if (txtStatus.Text == "Admin")
            {
                txtSalary.ReadOnly = true;
            }
            else if(txtStatus.Text=="Employee"){
                txtSalary.ReadOnly = false;
            }
        }
        private void refreshButton_Click(object sender, EventArgs e)
        {
            this.Init();
          
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            this.LoadDetails();
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            this.New();
        }
        private void New()
        {
            txtSearch.Text = txtID.Text = txtUserName.Text = txtPhone.Text = txtMail.Text = txtSalary.Text = txtAddress.Text = txtSearch.Text = "";
            txtStatus.Text = "Employee";
            dgvDetails.ClearSelection();
            if (txtStatus.Text == "Employee")
            {
                txtSalary.ReadOnly = false;
            }
        }
        private void dgvDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                String id = dgvDetails.Rows[e.RowIndex].Cells[0].Value.ToString();
                this.LoadData(Int32.Parse(id));
            }
        }
        private void LoadData(int id)
        {
            var employee = Context.Managers.FirstOrDefault(e => e.ID == id);

            if (employee == null)
            {
                this.New();
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
            if (txtStatus.Text == "Employee")
            {
                txtSalary.ReadOnly = false;
            }
            else if (txtStatus.Text == "Admin")
            {

                txtSalary.ReadOnly = true;
            }
            txtID.ReadOnly = true;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if(txtID.Text=="")
            {
                MetroFramework.MetroMessageBox.Show(this,"Please Select a Row First");
                return;
            }
            int id = Int32.Parse(txtID.Text);

            var employee = Context.Managers.FirstOrDefault(e2 => e2.ID == id);

            if (employee == null)
            {
                this.Init();
                return;
            }
            if (txtStatus.Text == "Employee")
            {
                Context.Managers.Remove(employee);
                Context.SaveChanges();
                this.deleteLogin();
                this.LoadDetails();
            }
            else {
                MetroFramework.MetroMessageBox.Show(this, "You are not allowed to delete an admin");
                return;
            }
        }
        private void deleteLogin()
        {
            LogIn l = new LogIn();
            var employee = Context.LogIns.FirstOrDefault(e => e.UserName == txtUserName.Text);
            if (employee == null)
            {
                MetroFramework.MetroMessageBox.Show(this, "Delete success!, But this EMPLOYEE has no data in the login database!");
                return;
            }
            Context.LogIns.Remove(employee);
            Context.SaveChanges();
            MetroFramework.MetroMessageBox.Show(this, "Delete success! And also delete from LOGIN system as well.");

        }
        private void updateButton_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtUserName.Text))
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
                else {
                    int id = Int32.Parse(txtID.Text);
                    emp = Context.Managers.FirstOrDefault(e2 => e2.ID == id);
                    if (emp == null)
                    {
                        this.Init();
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
                this.updateLogin();
                this.LoadDetails();
                this.LoadData(emp.ID);
                dgvDetails.ClearSelection();
                MetroFramework.MetroMessageBox.Show(this, "Update Done, Please note your User name and password" + "\n" + "User Name: " + txtUserName.Text + "\n" + "Password: " + txtPassword.Text);
               
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this,ex.Message);
            }
        }
        private void updateLogin()
        {
            LogIn l;
            if (txtID.Text == "")
            {
                l = new LogIn();
                Context.LogIns.Add(l);
            }
            else
            {
                int id = Int32.Parse(txtID.Text);
                l = Context.LogIns.FirstOrDefault(e2 => e2.ID == id);
                if (l == null)
                {
                    //this.Init();
                    return;
                }
            }
            l.UserName = txtUserName.Text;
            l.UserType = "employee";
            if (txtPassword.Text == null)
            {
                MetroFramework.MetroMessageBox.Show(this, "Plese Click the AUTO button to set Auto generate password");
                return;
            }
            l.Password = txtPassword.Text;

            Context.SaveChanges();
        }
        private void buttonAuto_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int pass = r.Next(50) + 1000;
            txtPassword.Text = pass.ToString();
        }
    }
}