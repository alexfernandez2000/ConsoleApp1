namespace HospitalGrafico
{
    partial class MedicoForm
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
            this.components = new System.ComponentModel.Container();
            this.butListar = new System.Windows.Forms.Button();
            this.dgvMedicos = new System.Windows.Forms.DataGridView();
            this.medicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCitas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // butListar
            // 
            this.butListar.Location = new System.Drawing.Point(148, 102);
            this.butListar.Name = "butListar";
            this.butListar.Size = new System.Drawing.Size(75, 23);
            this.butListar.TabIndex = 1;
            this.butListar.Text = "Listar";
            this.butListar.UseVisualStyleBackColor = true;
            this.butListar.Click += new System.EventHandler(this.butListar_Click);
            // 
            // dgvMedicos
            // 
            this.dgvMedicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicos.Location = new System.Drawing.Point(25, 169);
            this.dgvMedicos.Name = "dgvMedicos";
            this.dgvMedicos.RowHeadersWidth = 51;
            this.dgvMedicos.RowTemplate.Height = 24;
            this.dgvMedicos.Size = new System.Drawing.Size(726, 225);
            this.dgvMedicos.TabIndex = 5;
            // 
            // medicoBindingSource
            // 
            this.medicoBindingSource.DataSource = typeof(HospitalModel.Medico);
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(229, 102);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(75, 23);
            this.btnCrear.TabIndex = 6;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(310, 102);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCitas
            // 
            this.btnCitas.Location = new System.Drawing.Point(676, 102);
            this.btnCitas.Name = "btnCitas";
            this.btnCitas.Size = new System.Drawing.Size(75, 23);
            this.btnCitas.TabIndex = 20;
            this.btnCitas.Text = "Citas";
            this.btnCitas.UseVisualStyleBackColor = true;
            this.btnCitas.Click += new System.EventHandler(this.btnCitas_Click);
            // 
            // MedicoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCitas);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.dgvMedicos);
            this.Controls.Add(this.butListar);
            this.Name = "MedicoForm";
            this.Text = "MedicoForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button butListar;
        private System.Windows.Forms.BindingSource medicoBindingSource;
        private System.Windows.Forms.DataGridView dgvMedicos;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCitas;
    }
}