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
    public partial class DoctorMenu : Form
    {
        public DoctorMenu()
        {
            InitializeComponent();
        }

        private void patientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreatPatient tp = new TreatPatient();
            tp.TopLevel = false;
            tp.AutoScroll = true;
            tp.FormBorderStyle = FormBorderStyle.None;
            tp.Dock = DockStyle.Fill;
            this.DoctorMenuPanel.Controls.Clear();
            this.DoctorMenuPanel.Controls.Add(tp);
            tp.Show();
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {

            EmployeeReportManage erm = new EmployeeReportManage();
            erm.TopLevel = false;
            erm.AutoScroll = true;
            erm.FormBorderStyle = FormBorderStyle.None;
            erm.Dock = DockStyle.Fill;
            this.DoctorMenuPanel.Controls.Clear();
            this.DoctorMenuPanel.Controls.Add(erm);
            erm.Show();
        }

        private void departmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeViewDepartment erm = new EmployeeViewDepartment();
            erm.TopLevel = false;
            erm.AutoScroll = true;
            erm.FormBorderStyle = FormBorderStyle.None;
            erm.Dock = DockStyle.Fill;
            this.DoctorMenuPanel.Controls.Clear();
            this.DoctorMenuPanel.Controls.Add(erm);
            erm.Show();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            LogInUser pm = new LogInUser();

            pm.Show();
            this.Close();
        }

        private void DoctorMenu_Load(object sender, EventArgs e)
        {
            Image i = new Bitmap(@"C:\Users\rony1\Pictures\Hospital\Hospital1.jpg");
            this.DoctorMenuPanel.BackgroundImage = i;
            labelWelcome.Text = "Welcome," + LoginHelper.LogIn.UserName;
        }

        private void mySelfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoctorItSelf erm = new DoctorItSelf();
            erm.TopLevel = false;
            erm.AutoScroll = true;
            erm.FormBorderStyle = FormBorderStyle.None;
            erm.Dock = DockStyle.Fill;
            this.DoctorMenuPanel.Controls.Clear();
            this.DoctorMenuPanel.Controls.Add(erm);
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
                this.DoctorMenuPanel.BackgroundImage = i;
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message);

            }
        }
    }
}
