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
    public partial class AdminMenu : Form
    {
        public AdminMenu()
        {
            InitializeComponent();
        }

        private void AdminMenu_Load(object sender, EventArgs e)
        {
            Image i = new Bitmap(@"C:\Users\rony1\Pictures\Hospital\Hospital1.jpg");
            this.adminMenuPanel.BackgroundImage = i;

            labelWelcome.Text = "Welcomee," + LoginHelper.LogIn.UserName;
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
                this.adminMenuPanel.BackgroundImage = i;
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message);

            }
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employee ef = new Employee();
            ef.TopLevel = false;
            ef.AutoScroll = true;
            ef.FormBorderStyle = FormBorderStyle.None;
            ef.Dock = DockStyle.Fill;
            this.adminMenuPanel.Controls.Clear();
            this.adminMenuPanel.Controls.Add(ef);
            ef.Show();
        }

        private void doctorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoctorForm df = new DoctorForm();
            df.TopLevel = false;
            df.AutoScroll = true;
            df.FormBorderStyle = FormBorderStyle.None;
            df.Dock = DockStyle.Fill;
            this.adminMenuPanel.Controls.Clear();
            this.adminMenuPanel.Controls.Add(df);
            df.Show();
        }

        private void departmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DepartmentAdminForm daf = new DepartmentAdminForm();
            daf.TopLevel = false;
            daf.AutoScroll = true;
            daf.FormBorderStyle = FormBorderStyle.None;
            daf.Dock = DockStyle.Fill;
            this.adminMenuPanel.Controls.Clear();
            this.adminMenuPanel.Controls.Add(daf);
            daf.Show();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            LogInUser pm = new LogInUser();

            pm.Show();
            this.Close();
        }

        private void mySelfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminItSelf daf = new AdminItSelf();
            daf.TopLevel = false;
            daf.AutoScroll = true;
            daf.FormBorderStyle = FormBorderStyle.None;
            daf.Dock = DockStyle.Fill;
            this.adminMenuPanel.Controls.Clear();
            this.adminMenuPanel.Controls.Add(daf);
            daf.Show();
        }
    }
}
