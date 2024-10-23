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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void ShowAlgo(object sender, EventArgs e)
        {
        }
        private void DateTimeValueChanged(object sender, EventArgs e)
        {
            dtStartDate.Format = DateTimePickerFormat.Short;
        }

        private void Submit(object sender, EventArgs e)
        {
            if (txtTitle.Text!="" && txtDescription.Text!="" && clbEnvironment.CheckedItems!=null) 
            {
                string environmentText="";
                clbEnvironment.CheckedItems.OfType<object>()
                            .Select(item => item.ToString())
                            .ToList().ForEach(item=> environmentText+=$"{item.ToString()} |");


                MessageBox.Show($@"
Title: {txtTitle.Text}
Location: {cbLocation.SelectedItem ??"" .ToString()}
Type: {cbType.SelectedItem ?? "".ToString()}
Criticity: {cbCriticity.SelectedItem ?? "".ToString()}
Environment: {environmentText}
Description: {txtDescription.Text.ToString()}
Start Date: {dtStartDate.Text ?? "".ToString()}
Duration: {numDuration.Value.ToString()} H
Status: {cbStatus.SelectedItem ?? "".ToString()}
Percent complete: {numPercentCompleted.Value.ToString()}%
");
            }
        }
    }
}
