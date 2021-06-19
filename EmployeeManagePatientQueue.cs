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
    public partial class EmployeeManagePatientQueue : Form
    {
        HospitalContext2 context = new HospitalContext2();
        public EmployeeManagePatientQueue()
        {
            InitializeComponent();
        }

        private void EmployeeManagePatientQueue_Load(object sender, EventArgs e)
        {
            this.Init();
        }
        private void Init()
        {
            txtSearch.Text = txtPatientName.Text= txtSerialNumber.Text = txtTime.Text = "";
            

            dgvDetails.ClearSelection();
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

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            this.Init();
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
            var patient = context.PatientSerials.FirstOrDefault(d => d.SerialNumber == id);

            if (patient == null)
            {
                this.Init();
                return;
            }
            txtSerialNumber.Text = patient.SerialNumber.ToString();
            txtPatientName.Text = patient.PatientName;
            txtTime.Text = patient.Time;

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            this.LoadDetails();
        }

        private void buttonSet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPatientName.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Invalid");
                return;
            }
            try
            {
                //int serial = Int32.Parse(txtSerialNumber.Text);
                PatientSerial p;

                if (txtSerialNumber.Text == "")
                {
                    p = new PatientSerial();
                    context.PatientSerials.Add(p);
                }
                else
                {
                    int id = Int32.Parse(txtSerialNumber.Text);
                    p = context.PatientSerials.FirstOrDefault(e2 => e2.SerialNumber == id);
                    if (p == null)
                    {
                        this.Init();
                        return;
                    }
                }
                //p.SerialNumber = serial;
                p.PatientName = txtPatientName.Text;
                p.Time = txtTime.Text;


                context.SaveChanges();
                
                this.LoadDetails();
                this.loadData(p.SerialNumber);
                dgvDetails.ClearSelection();
                MetroFramework.MetroMessageBox.Show(this, "Update Done");
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message);
            }
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSerialNumber.Text == "")
                {
                    MetroFramework.MetroMessageBox.Show(this, "Please Select a Row First");
                    return;
                }
                int id = Int32.Parse(txtSerialNumber.Text);

                var patient = context.PatientSerials.FirstOrDefault(p => p.SerialNumber == id);
                if (patient == null)
                {
                    this.Init();
                    return;
                }
                context.PatientSerials.Remove(patient);
                context.SaveChanges();
               
                this.LoadDetails();
                this.Init();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message);
            }
        }
    }
}
