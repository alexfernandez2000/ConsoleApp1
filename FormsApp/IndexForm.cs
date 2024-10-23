using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsApp
{
    public partial class IndexForm : Form
    {
        public IndexForm()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = lbDiasSemana.SelectedItem.ToString();
        }

        private void btnBootstrap_Click(object sender, EventArgs e)
        {
            new BootstrapForm().Show();
        }
    }
}
