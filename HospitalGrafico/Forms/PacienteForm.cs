using HospitalGrafico.Forms;
using HospitalModel;
using HospitalModel.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalGrafico
{
    public partial class PacienteForm : Form
    {
        private Hospital _hospital;

        public PacienteForm(Hospital hospital)
        {
            _hospital = hospital;
            InitializeComponent();
            InicializarComboBox();
            RefrescarLista();
        }
        private void InicializarComboBox()
        {
            cbxMedico.DataSource=_hospital.GetPersonas<Medico>().Select(x=>x.Name).ToList();
        }
        private void butListar_Click(object sender, System.EventArgs e)
        {
            RefrescarLista();
        }
        private void RefrescarLista()
        {
            dgvPaciente.DataSource = _hospital.GetPersonas<Paciente>();
        }
        private void btnCrear_Click(object sender, System.EventArgs e)
        {
            string medicoSeleccionado= (string)cbxMedico.SelectedItem;
            if (cbxMedico.SelectedItem!=null)
            {
                Medico medico = _hospital.GetPersona<Medico>(medicoSeleccionado);
                Paciente paciente= new Paciente(medico);
                PersonaForm<Paciente> personaForm = new PersonaForm<Paciente>(paciente);
                personaForm.ShowDialog();
                if (personaForm.Success)
                {
                    _hospital.AddPersona(paciente);
                    RefrescarLista();
                }
                return;
            }
            MessageBox.Show("Selecciona un medico");
        }

        private void btnEliminar_Click(object sender, System.EventArgs e)
        {
            foreach (DataGridViewRow row in dgvPaciente.SelectedRows)
            {
                Paciente medicoEliminar = row.DataBoundItem as Paciente;

                _hospital.EliminarPersona<Paciente>(medicoEliminar);
            }

            RefrescarLista();
        }

        private void btnCitas_Click(object sender, EventArgs e)
        {
            if (dgvPaciente.SelectedRows.Count==0)
            {
                MessageBox.Show("Seleccione un paciente");
                return;
            }
            Paciente paciente = dgvPaciente.SelectedRows[0].DataBoundItem as Paciente;            
            CitaForm citaForm = new CitaForm(paciente);
            citaForm.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvPaciente.SelectedRows.Count != 0)
            {
                Paciente pacienteEditar = dgvPaciente.SelectedRows[0].DataBoundItem as Paciente;
                PersonaForm<Paciente> persona = new PersonaForm<Paciente>(pacienteEditar);
                persona.ShowDialog();
                if (persona.Success)
                    RefrescarLista();
            }
            else
                MessageBox.Show("Selecciona un solo paciente");

        }
    }
}
