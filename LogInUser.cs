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
    public partial class LogInUser : MetroFramework.Forms.MetroForm
    {
        HospitalContext2 context = new HospitalContext2();
        public LogInUser()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click_1(object sender, EventArgs e)
        {
            var login = context.LogIns.FirstOrDefault(u => u.UserName == txtLoginUserName.Text && u.Password == txtPassword.Text);


            if (login == null)
            {
                MessageBox.Show("Invalid Username and Password");
                return;
            }
            LoginHelper.LogIn = login;

            if (login.UserType == "admin")
            {
                AdminMenu ad = new AdminMenu();
                ad.TopLevel = false;
                ad.AutoScroll = true;
                ad.FormBorderStyle = FormBorderStyle.None;
                ad.Dock = DockStyle.Fill;
                this.AllPanel.Controls.Clear();
                this.AllPanel.Controls.Add(ad);
                ad.Show();

            }
            else if (login.UserType == "employee")
            {
                EmployeeMenu em = new EmployeeMenu();
                em.TopLevel = false;
                em.AutoScroll = true;
                em.FormBorderStyle = FormBorderStyle.None;
                em.Dock = DockStyle.Fill;
                this.AllPanel.Controls.Clear();
                this.AllPanel.Controls.Add(em);
                em.Show();
            }
            else if (login.UserType == "doctor")
            {
                DoctorMenu dr = new DoctorMenu();
                dr.TopLevel = false;
                dr.AutoScroll = true;
                dr.FormBorderStyle = FormBorderStyle.None;
                dr.Dock = DockStyle.Fill;
                this.AllPanel.Controls.Clear();
                this.AllPanel.Controls.Add(dr);
                dr.Show();
            }

            else if (login.UserType == "patient")
            {
                PatientMenu pm = new PatientMenu();
                pm.TopLevel = false;
                pm.AutoScroll = true;
                pm.FormBorderStyle = FormBorderStyle.None;
                pm.Dock = DockStyle.Fill;
                this.AllPanel.Controls.Clear();
                this.AllPanel.Controls.Add(pm);
                pm.Show();
            }
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            SignUp su = new SignUp();
            su.Show();
            //this.Close();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LogInUser_Load(object sender, EventArgs e)
        {
            Image i = new Bitmap(@"C:\Users\rony1\Pictures\Hospital\hospital2.jpg");
            this.AllPanel.BackgroundImage = i;
        }
    }
}
