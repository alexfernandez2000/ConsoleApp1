namespace EmployeesForm
{
    partial class StarterForm
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
            this.btnJob = new System.Windows.Forms.Button();
            this.btnEmploye = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnJob
            // 
            this.btnJob.Location = new System.Drawing.Point(107, 81);
            this.btnJob.Name = "btnJob";
            this.btnJob.Size = new System.Drawing.Size(75, 23);
            this.btnJob.TabIndex = 0;
            this.btnJob.Text = "Jobs";
            this.btnJob.UseVisualStyleBackColor = true;
            this.btnJob.Click += new System.EventHandler(this.btnJob_Click);
            // 
            // btnEmploye
            // 
            this.btnEmploye.Location = new System.Drawing.Point(237, 81);
            this.btnEmploye.Name = "btnEmploye";
            this.btnEmploye.Size = new System.Drawing.Size(75, 23);
            this.btnEmploye.TabIndex = 1;
            this.btnEmploye.Text = "Employees";
            this.btnEmploye.UseVisualStyleBackColor = true;
            this.btnEmploye.Click += new System.EventHandler(this.btnEmploye_Click);
            // 
            // StarterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEmploye);
            this.Controls.Add(this.btnJob);
            this.Name = "StarterForm";
            this.Text = "EditJob";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnJob;
        private System.Windows.Forms.Button btnEmploye;
    }
}