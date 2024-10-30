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
            _hospital.AddPersona<Medico>(new Medico());
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

        private void btnGenerico_Click(object sender, EventArgs e)
        {
           new PersonaForm<Medico>(_hospital.GetPersonas<Medico>()).Show();
        }
    }
}
