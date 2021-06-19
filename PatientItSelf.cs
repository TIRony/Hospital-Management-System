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
    public partial class PatientItSelf : Form
    {
        HospitalContext2 context = new HospitalContext2();
        public PatientItSelf()
        {
            InitializeComponent();
        }

        private void PatientItSelf_Load(object sender, EventArgs e)
        {
            this.loadData();
        }
        private void loadData()
        {
            var patient = context.Patients.FirstOrDefault(e => e.UserName == LoginHelper.LogIn.UserName);

            if (patient == null)
            {
                MetroFramework.MetroMessageBox.Show(this, "Your Data has clashed,Contract to ADMIN");
                return;
            }
            txtID.Text = patient.ID.ToString();
            txtUserName.Text = patient.UserName;
            txtPhnNo.Text = patient.PhnNo.ToString();
            txtMail.Text = patient.Email;
            txtDOB.Text = patient.DOB.ToString();
            //PatientRadioPanel = patient.Gender;
            if (patient.Gender == "Male")
            {
                RadioMale.Checked = true;
            }
            else
            {
                RadioFemale.Checked = true;
            }
            txtAddress.Text = patient.Address;
            ComboBlood.SelectedItem = patient.BloodGroup;
            txtWeight.Text = patient.Weight.ToString();
            txtAge.Text = patient.Age.ToString();
            
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
                int PhnNo = Int32.Parse(txtPhnNo.Text);
                int age = Int32.Parse(txtAge.Text);
                int w = Int32.Parse(txtWeight.Text);
                DateTime dob = DateTime.Parse(txtDOB.Text);
               
                Patient p;

                if (txtID.Text == "")
                {
                    p = new Patient();
                    context.Patients.Add(p);
                }
                else
                {
                    int id = Int32.Parse(txtID.Text);
                    p = context.Patients.FirstOrDefault(e2 => e2.ID == id);
                   if (p == null)
                    {
                        MetroFramework.MetroMessageBox.Show(this,"Enter Your Real UserName, If you donot know, Contact to ADMIN");
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
