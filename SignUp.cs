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
    public partial class SignUp : Form
    {
        HospitalContext2 context = new HospitalContext2();
        public SignUp()
        {
            InitializeComponent();
        }

        private void buttonAutoPassword_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int pass = r.Next(50) + 1000;
            txtPassword.Text = pass.ToString();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserName.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Invalid");
                return;
            }
            try
            {
                int PhnNo = Int32.Parse(txtPhnNo.Text);
                int age = Int32.Parse(txtAge.Text);
                int w = Int32.Parse(txtWeight.Text);
                DateTime dob = DateTime.Parse(txtDOB.Text);
                //int report;
                //report = Int32.Parse(txtReportID.Text);
                Patient p;

                //int password = Int32.Parse(txtPassword.Text);

                if (txtID.Text == "")
                {
                    p=new Patient();
                    context.Patients.Add(p);
                }
                else
                {
                    int id = Int32.Parse(txtID.Text);
                    p = context.Patients.FirstOrDefault(e2 => e2.ID == id);
                    if (p == null)
                    {
                        //this.Init();
                        return;
                    }
                }
                if (RadioMale.Checked == true)
                {
                    p.Gender = "Male";
                }
                else
                {
                    p.Gender = "Female";
                }
                p.UserName = txtUserName.Text;
                p.Email = txtMail.Text;
                p.Address = txtAddress.Text;
                p.DOB = dob;
                p.PhnNo = PhnNo;
                p.Age = age;
                p.Weight = w;
                //p.ReportID = report;
                p.BloodGroup = ComboBlood.SelectedItem.ToString();

                context.SaveChanges();
                this.updateLogin();

                MetroFramework.MetroMessageBox.Show(this,"Update Done, Please note your User name and password"+"\n"+"User Name: "+txtUserName.Text+"\n"+"Password: "+txtPassword.Text);
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
            l.UserType = "patient";
            if (txtPassword.Text == null)
            {
                MetroFramework.MetroMessageBox.Show(this, "Plese Click the AUTO button to set Auto generate password");
                return;
            }
            l.Password = txtPassword.Text;

            context.SaveChanges();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            LogInUser l = new LogInUser();
            l.Show();
            this.Close();
        }
    }
}
