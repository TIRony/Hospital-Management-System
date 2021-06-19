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
    public partial class EmployeeViewDepartment : Form
    {
        HospitalContext2 context = new HospitalContext2();
        public EmployeeViewDepartment()
        {
            InitializeComponent();
        }

        private void EmployeeViewDepartment_Load(object sender, EventArgs e)
        {
            this.LoadDetails();
        }
        private void LoadDetails()
        {
            var dept = context.Departments.ToList();

            if (txtSearch.Text != "")
            {
                dept = dept.Where(d => (d.Name).Contains(txtSearch.Text)).ToList();
            }
            dgvDetails.AutoGenerateColumns = false;
            dgvDetails.DataSource = dept.ToList();
            dgvDetails.Refresh();
            dgvDetails.ClearSelection();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            this.LoadDetails();
        }

    }
}
