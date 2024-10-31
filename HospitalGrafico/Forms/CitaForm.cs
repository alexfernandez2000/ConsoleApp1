using HospitalModel;
using HospitalModel.Clases;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace HospitalGrafico.Forms
{
    public partial class CitaForm : Form
    {
        Medico _medico;
        Paciente _paciente;
        public CitaForm(Medico medico)
        {
            _medico = medico;
            InitializeComponent();
            CargarComboBox();
            RefrescarLista();
        }
        public CitaForm(Paciente paciente)
        {
            _paciente = paciente;
            InitializeComponent();
            CargarComboBox();
        }


        private void CargarComboBox()
        {
            if (_medico == null)
            {
                cbxPacientes.Hide();
                btnCrear.Hide();
                btnEliminar.Hide();
                lblPacientes.Hide();
                lblFechaCita.Hide();
                dtpFechaCita.Hide();
                dgvCita.ReadOnly = true;
            }
            else
                cbxPacientes.DataSource = _medico.ListaPacientes.Select(x => x.Name).ToList();
        }

        private void butListar_Click(object sender, System.EventArgs e)
        {
            RefrescarLista();
        }
        private void RefrescarLista()
        {
            if (_medico != null)
                dgvCita.DataSource = _medico.ListaCitas;
            else
                dgvCita.DataSource = _paciente.ListaCitas;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (_medico != null)
            {
                if (cbxPacientes.SelectedValue != null)
                {
                    Paciente paciente = _medico.ListaPacientes.Where(x=> x.Name == cbxPacientes.Text).First();
                    new Cita(_medico, paciente, DateTime.Now, false);
                    RefrescarLista();
                }
                else
                {
                    MessageBox.Show("Selecciona un paciente para asignarle cita");
                    return;
                }

            }
        }

        private void butCancelarCita_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvCita.SelectedRows)
                {
                    Cita cita = row.DataBoundItem as Cita;
                    cita.CancelarCita();
                }
                RefrescarLista();
        }
    }
}
