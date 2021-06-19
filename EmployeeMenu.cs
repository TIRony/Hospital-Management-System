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
    public partial class EmployeeMenu : Form
    {
        public EmployeeMenu()
        {
            InitializeComponent();
        }

        private void patientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeePatientManage epm = new EmployeePatientManage();
            epm.TopLevel = false;
            epm.AutoScroll = true;
            epm.FormBorderStyle = FormBorderStyle.None;
            epm.Dock = DockStyle.Fill;
            this.employeeMenuPanel.Controls.Clear();
            this.employeeMenuPanel.Controls.Add(epm);
            epm.Show();
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeReportManage erm = new EmployeeReportManage();
            erm.TopLevel = false;
            erm.AutoScroll = true;
            erm.FormBorderStyle = FormBorderStyle.None;
            erm.Dock = DockStyle.Fill;
            this.employeeMenuPanel.Controls.Clear();
            this.employeeMenuPanel.Controls.Add(erm);
            erm.Show();
        }

        private void doctorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeDoctorView erm = new EmployeeDoctorView();
            erm.TopLevel = false;
            erm.AutoScroll = true;
            erm.FormBorderStyle = FormBorderStyle.None;
            erm.Dock = DockStyle.Fill;
            this.employeeMenuPanel.Controls.Clear();
            this.employeeMenuPanel.Controls.Add(erm);
            erm.Show();
        }

        private void deptartmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeViewDepartment erm = new EmployeeViewDepartment();
            erm.TopLevel = false;
            erm.AutoScroll = true;
            erm.FormBorderStyle = FormBorderStyle.None;
            erm.Dock = DockStyle.Fill;
            this.employeeMenuPanel.Controls.Clear();
            this.employeeMenuPanel.Controls.Add(erm);
            erm.Show();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            LogInUser pm = new LogInUser();

            pm.Show();
            this.Close();
        }

        private void EmployeeMenu_Load(object sender, EventArgs e)
        {
            Image i = new Bitmap(@"C:\Users\rony1\Pictures\Hospital\Hospital1.jpg");
            this.employeeMenuPanel.BackgroundImage = i;
            labelWelcome.Text = "Welcome," + LoginHelper.LogIn.UserName;
        }

        private void mySelfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeItSelf erm = new EmployeeItSelf();
            erm.TopLevel = false;
            erm.AutoScroll = true;
            erm.FormBorderStyle = FormBorderStyle.None;
            erm.Dock = DockStyle.Fill;
            this.employeeMenuPanel.Controls.Clear();
            this.employeeMenuPanel.Controls.Add(erm);
            erm.Show();
        }

        private void BackImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            if (op.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string imageName = op.FileName;
                txtbackImage.Text = imageName;
            }
        }

        private void buttonImageSave_Click(object sender, EventArgs e)
        {
            try
            {
                Image i = new Bitmap(txtbackImage.Text);
                this.employeeMenuPanel.BackgroundImage = i;
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message);

            }
        }

        private void patientQueueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeManagePatientQueue erm = new EmployeeManagePatientQueue();
            erm.TopLevel = false;
            erm.AutoScroll = true;
            erm.FormBorderStyle = FormBorderStyle.None;
            erm.Dock = DockStyle.Fill;
            this.employeeMenuPanel.Controls.Clear();
            this.employeeMenuPanel.Controls.Add(erm);
            erm.Show();
        }
    }
}
