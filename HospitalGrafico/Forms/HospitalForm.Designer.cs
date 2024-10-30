namespace HospitalGrafico
{
    partial class HospitalForm
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
            this.btnMedicos = new System.Windows.Forms.Button();
            this.btnAdministrativo = new System.Windows.Forms.Button();
            this.btnPaciente = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.panForm = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMedicos
            // 
            this.btnMedicos.Location = new System.Drawing.Point(233, 12);
            this.btnMedicos.Name = "btnMedicos";
            this.btnMedicos.Size = new System.Drawing.Size(95, 59);
            this.btnMedicos.TabIndex = 1;
            this.btnMedicos.Text = "Medicos";
            this.btnMedicos.UseVisualStyleBackColor = true;
            this.btnMedicos.Click += new System.EventHandler(this.btnMedicos_Click);
            // 
            // btnAdministrativo
            // 
            this.btnAdministrativo.Location = new System.Drawing.Point(334, 12);
            this.btnAdministrativo.Name = "btnAdministrativo";
            this.btnAdministrativo.Size = new System.Drawing.Size(109, 59);
            this.btnAdministrativo.TabIndex = 2;
            this.btnAdministrativo.Text = "Administrativo";
            this.btnAdministrativo.UseVisualStyleBackColor = true;
            this.btnAdministrativo.Click += new System.EventHandler(this.btnAdministrativo_Click);
            // 
            // btnPaciente
            // 
            this.btnPaciente.Location = new System.Drawing.Point(449, 12);
            this.btnPaciente.Name = "btnPaciente";
            this.btnPaciente.Size = new System.Drawing.Size(109, 59);
            this.btnPaciente.TabIndex = 3;
            this.btnPaciente.Text = "Paciente";
            this.btnPaciente.UseVisualStyleBackColor = true;
            this.btnPaciente.Click += new System.EventHandler(this.btnPaciente_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // panForm
            // 
            this.panForm.Location = new System.Drawing.Point(1, 90);
            this.panForm.Name = "panForm";
            this.panForm.Size = new System.Drawing.Size(799, 363);
            this.panForm.TabIndex = 4;
            // 
            // HospitalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panForm);
            this.Controls.Add(this.btnPaciente);
            this.Controls.Add(this.btnAdministrativo);
            this.Controls.Add(this.btnMedicos);
            this.Name = "HospitalForm";
            this.Text = "Hospital";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnMedicos;
        private System.Windows.Forms.Button btnAdministrativo;
        private System.Windows.Forms.Button btnPaciente;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Panel panForm;
    }
}

