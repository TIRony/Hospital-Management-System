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
    public partial class EmployeePatientManage : Form
    {
        HospitalContext2 context = new HospitalContext2();
        public EmployeePatientManage()
        {
            InitializeComponent();
        }

        private void EmployeePatientManage_Load(object sender, EventArgs e)
        {
            this.Init();
        }
        private void Init()
        {
            txtSearch.Text = txtID.Text = txtUserName.Text = txtPhnNo.Text = txtMail.Text = txtDOB.Text = txtAddress.Text =txtWeight.Text=txtAge.Text= "";
            PatientRadioPanel = null;
            RadioMale.Checked = false;
            RadioFemale.Checked = false;
            ComboBlood.SelectedItem = null;

            dgvDetails.ClearSelection();
            this.LoadDetails();
        }
        private void LoadDetails()
        {
            var patient = context.Patients.ToList();

            if (txtSearch.Text != null)
            {
                patient = patient.Where(d => (d.UserName).Contains(txtSearch.Text)).ToList();
            }
            dgvDetails.AutoGenerateColumns = false;
            dgvDetails.DataSource = patient.ToList();
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
            txtSearch.Text = txtID.Text = txtUserName.Text = txtPhnNo.Text = txtMail.Text = txtDOB.Text = txtAddress.Text = txtWeight.Text = txtAge.Text = "";
            PatientRadioPanel= null;
            RadioMale.Checked = false;
            RadioFemale.Checked = false;
            ComboBlood.SelectedItem = null;
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
            var patient = context.Patients.FirstOrDefault(d => d.ID == id);

            if (patient == null)
            {
                this.New();
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
                        this.Init();
                        return;
                    }
                }
                if (RadioMale.Checked == true)
                {
                    p.Gender = "Male";
                }
                else {
                    p.Gender = "Female";
                }
                p.UserName = txtUserName.Text;
                p.Email = txtMail.Text;
                p.Address = txtAddress.Text;
                p.DOB = dob;
                p.PhnNo = PhnNo;
                p.Age = age;
                p.Weight = w;
                p.BloodGroup = ComboBlood.SelectedItem.ToString();


                context.SaveChanges();
                this.updateLogin();
                this.LoadDetails();
                this.loadData(p.ID);
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
            l.UserType = "patient";
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
            Report r = new Report();
            int reportid = Int32.Parse(txtID.Text);
            var report = context.Reports.FirstOrDefault(re => re.PatientID == reportid);
            //if (r.PatientID == reportid)
            {
                this.ReportDelete();
            }
            try
            {
                if (txtID.Text == "")
                {
                    MetroFramework.MetroMessageBox.Show(this, "Please Select a Row First");
                    return;
                }
                int id = Int32.Parse(txtID.Text);

                var patient = context.Patients.FirstOrDefault(p => p.ID == id);
                if (patient == null)
                {
                    this.Init();
                    return;
                }
                context.Patients.Remove(patient);
                context.SaveChanges();
                this.deleteLogin();
                this.LoadDetails();
                this.Init();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message);
            }
        }
        private void deleteLogin()
        {
            LogIn l = new LogIn();
            var patient = context.LogIns.FirstOrDefault(e => e.UserName == txtUserName.Text);
            if (patient == null)
            {
                MetroFramework.MetroMessageBox.Show(this, "Delete success!, But this EMPLOYEE has no data in the login database!");
                return;
            }
            context.LogIns.Remove(patient);
            context.SaveChanges();
            MetroFramework.MetroMessageBox.Show(this, "Delete success! And also delete from LOGIN system as well.");

        }
        private void ReportDelete()
        {
            Report r = new Report();
            int reportid = Int32.Parse(txtID.Text);
            var report = context.Reports.FirstOrDefault(re => re.PatientID == reportid);
            if (report == null)
            {
                MetroFramework.MetroMessageBox.Show(this, "Delete success!, But this Patient has no REPORT! ");
                return;
            }
            context.Reports.Remove(report);
            context.SaveChanges();
            MetroFramework.MetroMessageBox.Show(this, "Delete success! And also delete the REPORT of this PATIENT");
        }
        private void buttonAuto_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int pass = r.Next(50) + 1000;
            txtPassword.Text = pass.ToString();
        }
    }
}
