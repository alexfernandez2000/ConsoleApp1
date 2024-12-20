﻿using System;
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
    public partial class BootstrapForm : Form
    {
        public BootstrapForm()
        {
            InitializeComponent();
        }
        private void btnSubmit_Submit(object sender, EventArgs e)
        {
            if (txtTitle.Text!="" && txtDescription.Text!="" && clbEnvironment.CheckedItems!=null) 
            {
                string environmentText="";
                clbEnvironment.CheckedItems.OfType<object>()
                            .Select(item => item.ToString())
                            .ToList().ForEach(item=> environmentText+=$"{item.ToString()} |");


                MessageBox.Show($@"
Title: {txtTitle.Text}
Location: {cbLocation.SelectedItem}
Type: {cbType.SelectedItem}
Criticity: {cbCriticity.SelectedItem}
Environment: {environmentText}
Description: {txtDescription.Text.ToString()}
Start Date: {dtStartDate.Text}
Duration: {numDuration.Value.ToString()} H
Status: {cbStatus.SelectedItem}
Percent complete: {numPercentCompleted.Value.ToString()}%
");
            }
        }
        private void dtStartDate_ValueChanged(object sender, EventArgs e)
        {
            dtStartDate.Format = DateTimePickerFormat.Short;
        }

        private void dtStartDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Back || e.KeyCode==Keys.Delete)
            {
                dtStartDate.CustomFormat = "  ";
                dtStartDate.Format = DateTimePickerFormat.Custom;
            }
        }
    }
}
