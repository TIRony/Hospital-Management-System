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
    public partial class TreatPatient : Form
    {
        HospitalContext2 context = new HospitalContext2();
        public TreatPatient()
        {
            InitializeComponent();
        }

        private void TreatPatient_Load(object sender, EventArgs e)
        {
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
            this.LoadDetails();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            this.LoadDetails();
        }
    }
}
