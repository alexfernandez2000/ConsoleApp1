namespace HospitalGrafico
{
    partial class AdministrativoForm
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
            this.dgvAdministrativo = new System.Windows.Forms.DataGridView();
            this.butListar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdministrativo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(322, 79);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 11;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(241, 79);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(75, 23);
            this.btnCrear.TabIndex = 10;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // dgvAdministrativo
            // 
            this.dgvAdministrativo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdministrativo.Location = new System.Drawing.Point(37, 146);
            this.dgvAdministrativo.Name = "dgvAdministrativo";
            this.dgvAdministrativo.RowHeadersWidth = 51;
            this.dgvAdministrativo.RowTemplate.Height = 24;
            this.dgvAdministrativo.Size = new System.Drawing.Size(726, 225);
            this.dgvAdministrativo.TabIndex = 9;
            // 
            // butListar
            // 
            this.butListar.Location = new System.Drawing.Point(160, 79);
            this.butListar.Name = "butListar";
            this.butListar.Size = new System.Drawing.Size(75, 23);
            this.butListar.TabIndex = 8;
            this.butListar.Text = "Listar";
            this.butListar.UseVisualStyleBackColor = true;
            this.butListar.Click += new System.EventHandler(this.butListar_Click);
            // 
            // AdministrativoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.dgvAdministrativo);
            this.Controls.Add(this.butListar);
            this.Name = "AdministrativoForm";
            this.Text = "AdministrativoForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdministrativo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.DataGridView dgvAdministrativo;
        private System.Windows.Forms.Button butListar;
    }
}