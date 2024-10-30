using System;
using System.Collections.Generic;
using System.Windows.Forms;
using HospitalGrafico.Forms;
using HospitalModel;
using HospitalModel.Clases;

namespace HospitalGrafico
{
    public partial class MedicoForm : Form
    {
        private Hospital _hospital;

        public MedicoForm(Hospital hospital)
        {
            _hospital = hospital;
            InitializeComponent();
            RefrescarLista();
        }
        private void butListar_Click(object sender, System.EventArgs e)
        {
            RefrescarLista();
        }
        private void RefrescarLista()
        {
            dgvMedicos.DataSource = _hospital.GetPersonas<Medico>();
        }
        private void btnCrear_Click(object sender, System.EventArgs e)
        {
            Medico medico = new Medico();
            PersonaForm<Medico> persona = new PersonaForm<Medico>(medico);
            persona.ShowDialog();
            if (persona.Success)
                _hospital.AddPersona<Medico>(medico);
            RefrescarLista();
        }

        private void btnEliminar_Click(object sender, System.EventArgs e)
        {
            foreach (DataGridViewRow row in dgvMedicos.SelectedRows)
            {
                Medico medicoEliminar = row.DataBoundItem as Medico;
                _hospital.EliminarPersona<Medico>(medicoEliminar);
            }
            RefrescarLista();

        }

        private void btnCitas_Click(object sender, EventArgs e)
        {
            if (dgvMedicos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un medico");
                return;
            }
            Medico medico = dgvMedicos.SelectedRows[0].DataBoundItem as Medico;
            CitaForm citaForm = new CitaForm(medico);
            citaForm.Show();
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvMedicos.SelectedRows.Count != 0)
            {
                Medico medicoEditar = dgvMedicos.SelectedRows[0].DataBoundItem as Medico;
                PersonaForm<Medico> persona = new PersonaForm<Medico>(medicoEditar);
                persona.ShowDialog();
                if (persona.Success)
                    RefrescarLista();
            }
            else
                MessageBox.Show("Selecciona un solo medico");
        }
    }
}
