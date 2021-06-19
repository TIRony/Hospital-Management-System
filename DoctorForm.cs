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
    public partial class DoctorForm : Form
    {
        HospitalContext2 context = new HospitalContext2();
        public DoctorForm()
        {
            InitializeComponent();
        }

        private void DoctorForm_Load(object sender, EventArgs e)
        {
            this.Init();
        }
        private void Init()
        {
            txtSearch.Text = txtID.Text = txtUserName.Text = txtPhone.Text = txtMail.Text = txtSalary.Text = txtAddress.Text = txtDeptNo.Text = txtTimeSlot.Text = "";

            this.LoadDetails();
        }
        private void LoadDetails()
        {
            var doctor = context.Doctors.ToList();

            if (txtSearch.Text != null)
            {
                doctor = doctor.Where(d => (d.UserName).Contains(txtSearch.Text)).ToList();
            }
            dgvDetails.AutoGenerateColumns = false;
            dgvDetails.DataSource = doctor.ToList();
            dgvDetails.Refresh();
            dgvDetails.ClearSelection();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            this.Init();
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            this.New();
        }
        private void New()
        {
            txtSearch.Text = txtUserName.Text = txtDeptNo.Text = txtPhone.Text = txtMail.Text = txtSalary.Text = txtAddress.Text = txtTimeSlot.Text =txtID.Text="";
            dgvDetails.ClearSelection();
 
        }
        private void dgvDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                String id = dgvDetails.Rows[e.RowIndex].Cells[0].Value.ToString();
                this.loadData(Int32.Parse(id));
            }
        }

        private void loadData(int id)
        {
            var doctor = context.Doctors.FirstOrDefault(d => d.ID == id);

            if (doctor == null)
            {
                this.New();
                return;
            }
            txtID.Text = doctor.ID.ToString();
            txtUserName.Text = doctor.UserName;
            txtDeptNo.Text = doctor.DeptID.ToString();
            txtPhone.Text = doctor.PhnNo.ToString();
            txtMail.Text = doctor.Email;
            txtSalary.Text = doctor.Salary.ToString();
            txtDOB.Text = doctor.DOB.ToString();
            txtAddress.Text = doctor.Address;
            txtTimeSlot.Text = doctor.TimeSlot.ToString();

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            this.LoadDetails();
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
                int DpetNo = Int32.Parse(txtDeptNo.Text);
                int salary = Int32.Parse(txtSalary.Text);
                DateTime dob = DateTime.Parse(txtDOB.Text);
                int Time = Int32.Parse(txtTimeSlot.Text);
                Doctor doc;

                if (txtID.Text == "")
                {
                    doc = new Doctor();
                    context.Doctors.Add(doc);
                }
                else
                {
                    int id = Int32.Parse(txtID.Text);
                    doc = context.Doctors.FirstOrDefault(e2 => e2.ID == id);
                    if (doc == null)
                    {
                        this.Init();
                        return;
                    }
                }
                doc.UserName = txtUserName.Text;
                doc.Email = txtMail.Text;
                doc.DeptID = DpetNo;
                doc.Address = txtAddress.Text;
                doc.DOB = dob;
                doc.Salary = salary;
                doc.PhnNo = PhnNo;
                doc.TimeSlot = Time;

                context.SaveChanges();
                this.updateLogin();
                this.LoadDetails();
                this.loadData(doc.ID);
                dgvDetails.ClearSelection();
                MetroFramework.MetroMessageBox.Show(this, "Update Done, Please note your User name and password" + "\n" + "User Name: " + txtUserName.Text + "\n" + "Password: " + txtPassword.Text);
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message);
            }
        }
        private void updateLogin()
        {
            LogIn l;
            if (txtID.Text == "")
            {
                l = new LogIn();
                context.LogIns.Add(l);
            }
            else
            {
                int id = Int32.Parse(txtID.Text);
                l = context.LogIns.FirstOrDefault(e2 => e2.ID == id);
                if (l == null)
                {
                    //this.Init();
                    return;
                }
            }
            l.UserName = txtUserName.Text;
            l.UserType = "doctor";
            if (txtPassword.Text == null)
            {
                MetroFramework.MetroMessageBox.Show(this, "Plese Click the AUTO button to set Auto generate password");
                return;
            }
            l.Password = txtPassword.Text;

            context.SaveChanges();
        }
        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtID.Text == "")
                {
                    MetroFramework.MetroMessageBox.Show(this, "Please Select a Row First");
                    return;
                }
                int id = Int32.Parse(txtID.Text);

                var doctor = context.Doctors.FirstOrDefault(d => d.ID == id);
                if (doctor == null)
                {
                    this.Init();
                    return;
                }
               
                context.Doctors.Remove(doctor);
                context.SaveChanges();
                this.deleteLogin();
                this.LoadDetails();
                
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message);
            }
        }
        private void deleteLogin()
        {
            LogIn l = new LogIn();
            var doctor = context.LogIns.FirstOrDefault(e => e.UserName == txtUserName.Text);
            if (doctor == null)
            {
                MetroFramework.MetroMessageBox.Show(this, "Delete success!, But this EMPLOYEE has no data in the login database!");
                return;
            }
            context.LogIns.Remove(doctor);
            context.SaveChanges();
            MetroFramework.MetroMessageBox.Show(this, "Delete success! And also delete from LOGIN system as well.");

        }
        private void buttonAuto_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int pass = r.Next(50) + 1000;
            txtPassword.Text = pass.ToString();
        }
    }
}