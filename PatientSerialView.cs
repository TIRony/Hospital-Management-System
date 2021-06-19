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
    public partial class PatientSerialView : Form
    {
        HospitalContext2 context = new HospitalContext2();
        public PatientSerialView()
        {
            InitializeComponent();
        }

        private void PatientSerialView_Load(object sender, EventArgs e)
        {
            this.LoadDetails();
        }
        private void LoadDetails()
        {
            var patient = context.PatientSerials.ToList();

            if (txtSearch.Text != null)
            {
                patient = patient.Where(d => (d.PatientName).Contains(txtSearch.Text)).ToList();
            }
            dgvDetails.AutoGenerateColumns = false;
            dgvDetails.DataSource = patient.ToList();
            dgvDetails.Refresh();
            dgvDetails.ClearSelection();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            this.LoadDetails();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            this.LoadDetails();
        }
    }
}
