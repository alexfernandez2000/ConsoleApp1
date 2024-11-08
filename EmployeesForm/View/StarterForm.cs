using Microsoft.Extensions.DependencyInjection;
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
    public partial class StarterForm : Form
    {
        public StarterForm()
        {
            InitializeComponent();
        }

        private void btnJob_Click(object sender, EventArgs e)
        {
            Application.Run(ServiceProvider.GetRequiredService<JobForm>());

            jobForm.ShowDialog();

        }
        private void btnEmploye_Click(object sender, EventArgs e)
        {
            EmployeForm employeForm = new EmployeForm();
            employeForm.ShowDialog();
        }

    }
}
