namespace HospitalGrafico.Forms
{
    partial class CitaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvCita = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.butListar = new System.Windows.Forms.Button();
            this.cbxPacientes = new System.Windows.Forms.ComboBox();
            this.lblPacientes = new System.Windows.Forms.Label();
            this.dtpFechaCita = new System.Windows.Forms.DateTimePicker();
            this.lblFechaCita = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCita)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCita
            // 
            this.dgvCita.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCita.Location = new System.Drawing.Point(37, 113);
            this.dgvCita.Name = "dgvCita";
            this.dgvCita.RowHeadersWidth = 51;
            this.dgvCita.RowTemplate.Height = 24;
            this.dgvCita.Size = new System.Drawing.Size(726, 225);
            this.dgvCita.TabIndex = 6;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(201, 67);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 14;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.butCancelarCita_Click);
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(120, 67);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(75, 23);
            this.btnCrear.TabIndex = 13;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // butListar
            // 
            this.butListar.Location = new System.Drawing.Point(39, 67);
            this.butListar.Name = "butListar";
            this.butListar.Size = new System.Drawing.Size(75, 23);
            this.butListar.TabIndex = 12;
            this.butListar.Text = "Listar";
            this.butListar.UseVisualStyleBackColor = true;
            this.butListar.Click += new System.EventHandler(this.butListar_Click);
            // 
            // cbxPacientes
            // 
            this.cbxPacientes.FormattingEnabled = true;
            this.cbxPacientes.Location = new System.Drawing.Point(642, 66);
            this.cbxPacientes.Name = "cbxPacientes";
            this.cbxPacientes.Size = new System.Drawing.Size(121, 24);
            this.cbxPacientes.TabIndex = 16;
            // 
            // lblPacientes
            // 
            this.lblPacientes.AutoSize = true;
            this.lblPacientes.Location = new System.Drawing.Point(639, 35);
            this.lblPacientes.Name = "lblPacientes";
            this.lblPacientes.Size = new System.Drawing.Size(67, 16);
            this.lblPacientes.TabIndex = 17;
            this.lblPacientes.Text = "Pacientes";
            // 
            // dtpFechaCita
            // 
            this.dtpFechaCita.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaCita.Location = new System.Drawing.Point(295, 68);
            this.dtpFechaCita.Name = "dtpFechaCita";
            this.dtpFechaCita.Size = new System.Drawing.Size(200, 22);
            this.dtpFechaCita.TabIndex = 18;
            // 
            // lblFechaCita
            // 
            this.lblFechaCita.AutoSize = true;
            this.lblFechaCita.Location = new System.Drawing.Point(292, 35);
            this.lblFechaCita.Name = "lblFechaCita";
            this.lblFechaCita.Size = new System.Drawing.Size(69, 16);
            this.lblFechaCita.TabIndex = 19;
            this.lblFechaCita.Text = "Fecha cita";
            // 
            // CitaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblFechaCita);
            this.Controls.Add(this.dtpFechaCita);
            this.Controls.Add(this.lblPacientes);
            this.Controls.Add(this.cbxPacientes);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.butListar);
            this.Controls.Add(this.dgvCita);
            this.Name = "CitaForm";
            this.Text = "CitaForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCita)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCita;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button butListar;
        private System.Windows.Forms.ComboBox cbxPacientes;
        private System.Windows.Forms.Label lblPacientes;
        private System.Windows.Forms.DateTimePicker dtpFechaCita;
        private System.Windows.Forms.Label lblFechaCita;
    }
}