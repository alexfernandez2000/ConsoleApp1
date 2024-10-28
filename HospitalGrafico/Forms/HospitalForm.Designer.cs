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
            this.btnCitas = new System.Windows.Forms.Button();
            this.btnMedicos = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.panForm = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCitas
            // 
            this.btnCitas.Location = new System.Drawing.Point(590, 12);
            this.btnCitas.Name = "btnCitas";
            this.btnCitas.Size = new System.Drawing.Size(95, 59);
            this.btnCitas.TabIndex = 0;
            this.btnCitas.Text = "Citas";
            this.btnCitas.UseVisualStyleBackColor = true;
            // 
            // btnMedicos
            // 
            this.btnMedicos.Location = new System.Drawing.Point(259, 12);
            this.btnMedicos.Name = "btnMedicos";
            this.btnMedicos.Size = new System.Drawing.Size(95, 59);
            this.btnMedicos.TabIndex = 1;
            this.btnMedicos.Text = "Medicos";
            this.btnMedicos.UseVisualStyleBackColor = true;
            this.btnMedicos.Click += new System.EventHandler(this.btnMedicos_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(360, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 59);
            this.button2.TabIndex = 2;
            this.button2.Text = "Administrativo";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(475, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 59);
            this.button3.TabIndex = 3;
            this.button3.Text = "Paciente";
            this.button3.UseVisualStyleBackColor = true;
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
            // Hospital
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panForm);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnMedicos);
            this.Controls.Add(this.btnCitas);
            this.Name = "Hospital";
            this.Text = "Hospital";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCitas;
        private System.Windows.Forms.Button btnMedicos;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Panel panForm;
    }
}

