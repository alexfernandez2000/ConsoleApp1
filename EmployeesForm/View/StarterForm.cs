using System;
using System.Windows.Forms;

namespace EmployeesForm
{
    public partial class StarterForm : Form
    {
        public StarterForm()
        {
            InitializeComponent();
        }

        private void btnJob_Click(object sender, EventArgs e)
        {
            JobForm jobForm = new JobForm();

            jobForm.ShowDialog();

        }
        private void btnEmploye_Click(object sender, EventArgs e)
        {
            EmployeForm employeForm = new EmployeForm();
            employeForm.ShowDialog();
        }

    }
}
