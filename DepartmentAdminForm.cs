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
    public partial class DepartmentAdminForm : Form
    {
        HospitalContext2 context = new HospitalContext2();
        public DepartmentAdminForm()
        {
            InitializeComponent();
        }

        private void Init()
        {
            txtSearch.Text = txtDeptID.Text =txtDeptName.Text= "";

            //AdminDeptCombo.DataSource = context.Departments.ToList();
            //AdminDeptCombo.DisplayMember = "Name";
            //AdminDeptCombo.SelectedItem = null;

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

        private void DepartmentAdminForm_Load(object sender, EventArgs e)
        {
            this.Init();
        }
        private void New()
        {
            txtSearch.Text = txtDeptID.Text=txtDeptName.Text ="";
            //AdminDeptCombo.SelectedItem = null;
            dgvDetails.ClearSelection();

        }
        private void loadData(int id)
        {
            var dept = context.Departments.FirstOrDefault(d => d.ID == id);

            if (dept == null)
            {
                this.New();
                return;
            }
            txtDeptID.Text = dept.ID.ToString();
            txtDeptName.Text = dept.Name;
            //AdminDeptCombo.SelectedText = dept.Name.ToString();
        }
            
        private void dgvDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                String id = dgvDetails.Rows[e.RowIndex].Cells[0].Value.ToString();
                this.loadData(Int32.Parse(id));
            }
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            this.New();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            this.Init();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            this.LoadDetails();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDeptName.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Invalid");
                return;
            }
            else if (string.IsNullOrEmpty(txtDeptID.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Invalid");
                return;
            }
            try
            {
                int id = Int32.Parse(txtDeptID.Text);
                Department dept = new Department();

                context.Departments.Add(dept);

                dept.ID = id;
                dept.Name = txtDeptName.Text;

                context.SaveChanges();
                this.LoadDetails();
                this.loadData(dept.ID);
                dgvDetails.ClearSelection();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            this.DoctorDelete();
            
        }
        private void DepartmentHasDoctor()
        {
            try
            {
                if (txtDeptID.Text == "")
                {
                    MetroFramework.MetroMessageBox.Show(this, "Please Select a Row First");
                    return;
                }
                int id = Int32.Parse(txtDeptID.Text);
                var dept = context.Departments.FirstOrDefault(d => d.ID == id);
                if (dept == null)
                {
                    this.Init();
                    return;
                }
                context.Departments.Remove(dept);
                context.SaveChanges();

                this.LoadDetails();
                this.Init();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message);
            }
        }
        private void DoctorDelete()
        {
            Doctor d = new Doctor();
            int deptid = Int32.Parse(txtDeptID.Text);
            var doctor = context.Doctors.FirstOrDefault(re => re.DeptID == deptid);
            if (doctor == null)
            {
                this.DepartmentHasDoctor();
                MetroFramework.MetroMessageBox.Show(this, "Delete success!, But this DEPARTMENT has no DOCTOR! ");
                return;
            }
            else
            {
                //context.Doctors.Remove(doctor);
                //context.SaveChanges();
                MetroFramework.MetroMessageBox.Show(this, "To delete the department First You have to delete DOCTOR'S of this DEPARTMENT");
                return;
                //this.DeleteLogin();
            }
 
        }
        /*private void DeleteLogin()
        {
            LogIn l = new LogIn();
            Doctor d = new Doctor();
            var  doctor= context.LogIns.FirstOrDefault(e => e.UserName == );
            if (doctor == null)
            {
                MetroFramework.MetroMessageBox.Show(this, "Delete success!, But this DOCTOR has no data in the login database!");
                return;
            }
            context.LogIns.Remove(doctor);
            context.SaveChanges();
            MetroFramework.MetroMessageBox.Show(this, "Delete success! And also delete from LOGIN system as well.");
        }*/
    }
}