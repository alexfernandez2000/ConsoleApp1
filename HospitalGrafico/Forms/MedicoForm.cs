using System.Collections.Generic;
using System.Windows.Forms;
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
            _hospital.AddMedico();
            RefrescarLista();
        }

        private void btnEliminar_Click(object sender, System.EventArgs e)
        {
            foreach (DataGridViewRow row in dgvMedicos.SelectedRows)
            {
                Medico medicoEliminar = row.DataBoundItem as Medico;

                _hospital.EliminarMedico(medicoEliminar);
                RefrescarLista();
            }
        }
    }
}
