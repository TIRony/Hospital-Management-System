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
    public partial class EmployeeDoctorView : Form
    {
        HospitalContext2 context = new HospitalContext2();
        public EmployeeDoctorView()
        {
            InitializeComponent();
        }

        private void EmployeeDoctorView_Load(object sender, EventArgs e)
        {
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

        private void searchButton_Click(object sender, EventArgs e)
        {
            this.LoadDetails();
        }
    }
}
