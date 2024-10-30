namespace HospitalGrafico
{
    partial class PacienteForm
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
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.dgvPaciente = new System.Windows.Forms.DataGridView();
            this.butListar = new System.Windows.Forms.Button();
            this.btnCitas = new System.Windows.Forms.Button();
            this.cbxMedico = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaciente)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(282, 80);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 11;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(120, 80);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(75, 23);
            this.btnCrear.TabIndex = 10;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // dgvPaciente
            // 
            this.dgvPaciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPaciente.Location = new System.Drawing.Point(37, 146);
            this.dgvPaciente.Name = "dgvPaciente";
            this.dgvPaciente.RowHeadersWidth = 51;
            this.dgvPaciente.RowTemplate.Height = 24;
            this.dgvPaciente.Size = new System.Drawing.Size(726, 225);
            this.dgvPaciente.TabIndex = 9;
            // 
            // butListar
            // 
            this.butListar.Location = new System.Drawing.Point(39, 80);
            this.butListar.Name = "butListar";
            this.butListar.Size = new System.Drawing.Size(75, 23);
            this.butListar.TabIndex = 8;
            this.butListar.Text = "Listar";
            this.butListar.UseVisualStyleBackColor = true;
            this.butListar.Click += new System.EventHandler(this.butListar_Click);
            // 
            // btnCitas
            // 
            this.btnCitas.Location = new System.Drawing.Point(688, 79);
            this.btnCitas.Name = "btnCitas";
            this.btnCitas.Size = new System.Drawing.Size(75, 23);
            this.btnCitas.TabIndex = 19;
            this.btnCitas.Text = "Citas";
            this.btnCitas.UseVisualStyleBackColor = true;
            this.btnCitas.Click += new System.EventHandler(this.btnCitas_Click);
            // 
            // cbxMedico
            // 
            this.cbxMedico.FormattingEnabled = true;
            this.cbxMedico.Location = new System.Drawing.Point(438, 79);
            this.cbxMedico.Name = "cbxMedico";
            this.cbxMedico.Size = new System.Drawing.Size(121, 24);
            this.cbxMedico.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(435, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Medico asignado";
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(201, 80);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 23;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // PacienteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxMedico);
            this.Controls.Add(this.btnCitas);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.dgvPaciente);
            this.Controls.Add(this.butListar);
            this.Name = "PacienteForm";
            this.Text = "PacienteForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaciente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.DataGridView dgvPaciente;
        private System.Windows.Forms.Button butListar;
        private System.Windows.Forms.Button btnCitas;
        private System.Windows.Forms.ComboBox cbxMedico;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEditar;
    }
}