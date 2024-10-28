using HospitalModel.Clases;
using System;
using System.Windows.Forms;
namespace HospitalGrafico
{
    public partial class HospitalForm : Form
    {
        private Hospital _hospital;
        public HospitalForm()
        {
            _hospital = new Hospital();
            InitializeComponent();
        }
        private void btnMedicos_Click(object sender, EventArgs e)
        {
            MedicoForm medicoForm = new MedicoForm(_hospital);
            medicoForm.TopLevel = false;
            medicoForm.FormBorderStyle = FormBorderStyle.None; 
            medicoForm.Dock = DockStyle.Fill;
            panForm.Controls.Add(medicoForm);
            medicoForm.Show();
        }
    }
}
