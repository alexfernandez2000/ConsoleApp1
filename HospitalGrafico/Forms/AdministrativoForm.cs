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
    public partial class AdministrativoForm : Form
    {
        private Hospital _hospital;

        public AdministrativoForm(Hospital hospital)
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
            dgvAdministrativo.DataSource = _hospital.GetPersonas<Administrativo>();
        }
        private void btnCrear_Click(object sender, System.EventArgs e)
        {
            _hospital.AddPersona<Administrativo>(new Administrativo());
            RefrescarLista();
        }

        private void btnEliminar_Click(object sender, System.EventArgs e)
        {
            foreach (DataGridViewRow row in dgvAdministrativo.SelectedRows)
            {
                Administrativo administrativoEliminar = row.DataBoundItem as Administrativo;

                _hospital.EliminarPersona<Administrativo>(administrativoEliminar);
            }

            RefrescarLista();
        }
    }
}
