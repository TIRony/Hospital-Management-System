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
    public partial class EmployeeReportManage : Form
    {
        HospitalContext2 context = new HospitalContext2();
        public EmployeeReportManage()
        {
            InitializeComponent();
        }
        private void EmployeeReportManage_Load(object sender, EventArgs e)
        {
            this.Init();
        }
        private void Init()
        {
            txtSearch.Text = txtID.Text = txtReportDate.Text = txtPatientID.Text = txtDrug.Text = txtLabResult.Text = txtLabResult.Text = txtPatientName.Text="";

            this.LoadDetails();
        }
        private void LoadDetails()
        {
            var report = context.Reports.ToList();
            if (txtSearch.Text != null)
            {
                report = report.Where(d => (d.PatientName).Contains(txtSearch.Text)).ToList();
            }
            dgvDetails.AutoGenerateColumns = false;
            dgvDetails.DataSource = report.ToList();
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
            txtSearch.Text = txtID.Text = txtReportDate.Text = txtPatientID.Text = txtDrug.Text = txtLabResult.Text = txtLabResult.Text =txtPatientName.Text= "";
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
            var report = context.Reports.FirstOrDefault(d => d.ID == id);

            if (report == null)
            {
                this.New();
                return;
            }
            txtID.Text = report.ID.ToString();
            txtPatientName.Text = report.PatientName;
            txtReportDate.Text = report.ReportDate.ToString();
            txtPatientID.Text = report.PatientID.ToString();
            txtDrug.Text = report.Drugs;
            txtLabResult.Text = report.LabResult;
            
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            this.LoadDetails();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                int PatientID = Int32.Parse(txtPatientID.Text);
                DateTime dt = DateTime.Parse(txtReportDate.Text);
                Report re;

                if (txtID.Text == "")
                {
                    re = new Report();
                    context.Reports.Add(re);
                }
                else
                {
                    int id = Int32.Parse(txtID.Text);
                    re = context.Reports.FirstOrDefault(r => r.ID == id);
                    if (re == null)
                    {
                        this.Init();
                        return;
                    }
                }
                re.ReportDate = dt;
                re.PatientName = txtPatientName.Text;
                re.Drugs = txtDrug.Text;
                re.PatientID = PatientID;
                re.LabResult= txtLabResult.Text;

                context.SaveChanges();
                this.LoadDetails();
                this.loadData(re.ID);
                MetroFramework.MetroMessageBox.Show(this, "Update success!");
                dgvDetails.ClearSelection();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message);
            }
        }
        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtID.Text == "")
                {
                    MetroFramework.MetroMessageBox.Show(this, "Please Select a Row First");
                    return;
                }
                int id = Int32.Parse(txtID.Text);

                var report = context.Reports.FirstOrDefault(r => r.ID == id);
                if (report == null)
                {
                    this.Init();
                    return;
                }
                context.Reports.Remove(report);
                context.SaveChanges();
                MetroFramework.MetroMessageBox.Show(this, "Delete success!");
                this.LoadDetails();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message);
            }
        }
    }
}
