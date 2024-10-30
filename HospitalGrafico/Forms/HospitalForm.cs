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
            ShowForm(medicoForm);
        }

        private void btnAdministrativo_Click(object sender, EventArgs e)
        {
            AdministrativoForm administrativoForm=new AdministrativoForm(_hospital);
            ShowForm(administrativoForm);
        }
        private void btnPaciente_Click(object sender, EventArgs e)
        {
            PacienteForm pacienteForm = new PacienteForm(_hospital);
            ShowForm(pacienteForm);
        }

        private void btnCitas_Click(object sender, EventArgs e)
        {

        }
        private void ShowForm(Form form)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panForm.Controls.Clear();
            panForm.Controls.Add(form);
            form.Show();
        }

    }
}
