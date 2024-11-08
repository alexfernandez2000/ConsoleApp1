using EmployeesForm.BBDDConection;
using EmployeesForm.Model;
using EmployeesForm.Model.BBDDConection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeesForm
{
    public partial class EmployeForm : Form
    {
        private DalEmploye _dalEmploye;
        private DalJob _dalJob;
        private DalDepartment _dalDepartment;
        public EmployeForm()
        {
            InitializeComponent();
            _dalEmploye = new DalEmploye();
            _dalJob = new DalJob();
            _dalDepartment = new DalDepartment();
            InitializeCB();
        }

        private void InitializeCB()
        {
            cbDepartment.Items.AddRange(_dalDepartment.GetAll().ToArray());
            cbDepartment.DisplayMember = "department_name";
            cbJob.Items.AddRange(_dalJob.GetAll().ToArray());
            cbJob.DisplayMember = "job_title";
            cbManager.Items.AddRange(_dalEmploye.GetAll().ToArray());
            cbManager.DisplayMember = "first_name";
        }
        private void btnList_Click(object sender, EventArgs e)
        {
            RefrescarLista();
        }
        private void RefrescarLista()
        {
            dgvEmployees.DataSource = _dalEmploye.GetAll();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            
            if (dgvEmployees.SelectedRows.Count != 0)
            {
                employee selectedEmploye = dgvEmployees.SelectedRows[0].DataBoundItem as employee;
                employee formEmploye = GetEmployeData();
                if (formEmploye == null)
                    return;
                formEmploye.employee_id = selectedEmploye.employee_id;
                _dalEmploye.Update(formEmploye);
            }
        }

        private employee GetEmployeData()
        {
            if (cbJob.SelectedItem != null && tbLastName.Text.Length>0 && tbEmail.Text.Length>0 && dtHireDate.Value!=null)
            {
                employee employe = new employee();
                employe.first_name = tbFirstName.Text;
                employe.last_name = tbLastName.Text;
                employe.email = tbEmail.Text;
                employe.phone_number = tbPhoneNumber.Text;
                employe.hire_date = dtHireDate.Value;
                employe.job_id = ((job)cbJob.SelectedItem).job_id;
                employe.salary = numSalary.Value;
                employe.manager_id = ((employee)cbManager.SelectedItem) == null ? null : (int?)((employee)cbManager.SelectedItem).employee_id;
                employe.department_id = ((department)cbDepartment.SelectedItem) == null ? null : (int?)((department)cbDepartment.SelectedItem).department_id;
                return employe;
            }
            MessageBox.Show("Missing data");
            return null;
        }
        private void SetEmployeData(employee employe)
        {
            tbFirstName.Text = employe.first_name;
            tbLastName.Text = employe.last_name;
            tbEmail.Text = employe.email;
            tbPhoneNumber.Text = employe.phone_number;
            dtHireDate.Value = employe.hire_date;
            cbJob.SelectedItem = cbJob.Items.OfType<job>().Where(x=>x.job_id==employe.job_id).FirstOrDefault();
            numSalary.Value = employe.salary;
            if (employe.manager_id != null)
                cbManager.SelectedItem = cbManager.Items.OfType<employee>().Where(x => x.employee_id == employe.manager_id).FirstOrDefault();
            if (employe.department_id != null)
                cbDepartment.SelectedItem = cbDepartment.Items.OfType<department>().Where(x => x.department_id == employe.department_id).FirstOrDefault();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            employee formEmploye = GetEmployeData();
            _dalEmploye.Insert(formEmploye);
        }

        private void dgvEmployees_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvEmployees.SelectedRows.Count != 0)
            {
                employee employeEditar = dgvEmployees.SelectedRows[0].DataBoundItem as employee;
                SetEmployeData(employeEditar);
            }

        }
    }
}
