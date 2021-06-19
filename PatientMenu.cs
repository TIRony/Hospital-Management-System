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
    public partial class PatientMenu : Form
    {
        public PatientMenu()
        {
            InitializeComponent();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            LogInUser pm = new LogInUser();

            pm.Show();
            this.Close();
        }

        private void PatientMenu_Load(object sender, EventArgs e)
        {
            Image i = new Bitmap(@"C:\Users\rony1\Pictures\Hospital\Hospital1.jpg");
            this.PatientMenuPanel.BackgroundImage = i;
            labelWelcome.Text = "Welcome," + LoginHelper.LogIn.UserName;
        }

        private void mySelfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PatientItSelf erm = new PatientItSelf();
            erm.TopLevel = false;
            erm.AutoScroll = true;
            erm.FormBorderStyle = FormBorderStyle.None;
            erm.Dock = DockStyle.Fill;
            this.PatientMenuPanel.Controls.Clear();
            this.PatientMenuPanel.Controls.Add(erm);
            erm.Show();
        }
        private void manageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PatientViewReport erm = new PatientViewReport();
            erm.TopLevel = false;
            erm.AutoScroll = true;
            erm.FormBorderStyle = FormBorderStyle.None;
            erm.Dock = DockStyle.Fill;
            this.PatientMenuPanel.Controls.Clear();
            this.PatientMenuPanel.Controls.Add(erm);
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
                this.PatientMenuPanel.BackgroundImage = i;
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message);

            }
        }

        private void serialQueueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PatientSerialView erm = new PatientSerialView();
            erm.TopLevel = false;
            erm.AutoScroll = true;
            erm.FormBorderStyle = FormBorderStyle.None;
            erm.Dock = DockStyle.Fill;
            this.PatientMenuPanel.Controls.Clear();
            this.PatientMenuPanel.Controls.Add(erm);
            erm.Show();
        }
    }
}
