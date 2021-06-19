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
    public partial class PatientViewReport : Form
    {
        HospitalContext2 Context = new HospitalContext2();
        public PatientViewReport()
        {
            InitializeComponent();
        }

        private void PatientViewReport_Load(object sender, EventArgs e)
        {
            this.LoadData();
        }
        private void LoadData()
        {
            var report = Context.Reports.FirstOrDefault(e => e.PatientName == LoginHelper.LogIn.UserName);
            if (report == null)
            {
                MetroFramework.MetroMessageBox.Show(this, "You have no REPORT yet");
                return;
            }
            txtID.Text = report.ID.ToString();
            txtPatientName.Text= report.PatientName;
            txtPatientID.Text = report.PatientID.ToString();
            txtDrug.Text= report.Drugs;
            txtReportDate.Text= report.ReportDate.ToString();
            txtLabResult.Text = report.LabResult;
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            this.LoadData();
        }
    }
}
