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
    }
}
