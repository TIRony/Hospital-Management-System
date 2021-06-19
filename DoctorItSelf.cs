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
    public partial class DoctorItSelf : Form
    {
        HospitalContext2 context = new HospitalContext2();
        public DoctorItSelf()
        {
            InitializeComponent();
        }

        private void DoctorItSelf_Load(object sender, EventArgs e)
        {
            this.loadData();
        }
        private void loadData()
        {
            var doctor = context.Doctors.FirstOrDefault(e => e.UserName == LoginHelper.LogIn.UserName);
            if (doctor == null)
            {
                MetroFramework.MetroMessageBox.Show(this, "Your Data has clashed, Contrct to ADMIN");
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
                        MetroFramework.MetroMessageBox.Show(this,"Enter Your Real UserName, If you donot know, Contact to ADMIN");
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
                this.loadData();

                MetroFramework.MetroMessageBox.Show(this, "Successfully Update");
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message);
            }
        }
    }
}
