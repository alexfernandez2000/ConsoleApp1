namespace EmployeesForm
{
    partial class JobForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbConnection = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.btAdd = new System.Windows.Forms.Button();
            this.tbMaxSalary = new System.Windows.Forms.TextBox();
            this.tbMinSalary = new System.Windows.Forms.TextBox();
            this.btGetAll = new System.Windows.Forms.Button();
            this.dgvJob = new System.Windows.Forms.DataGridView();
            this.btnEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJob)).BeginInit();
            this.SuspendLayout();
            // 
            // lbConnection
            // 
            this.lbConnection.AutoSize = true;
            this.lbConnection.Location = new System.Drawing.Point(15, 80);
            this.lbConnection.Name = "lbConnection";
            this.lbConnection.Size = new System.Drawing.Size(56, 13);
            this.lbConnection.TabIndex = 2;
            this.lbConnection.Text = "MaxSalary";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "MinSalary";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Title";
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(112, 21);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(100, 20);
            this.tbTitle.TabIndex = 5;
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(112, 124);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 23);
            this.btAdd.TabIndex = 1;
            this.btAdd.Text = "Add";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // tbMaxSalary
            // 
            this.tbMaxSalary.Location = new System.Drawing.Point(112, 77);
            this.tbMaxSalary.Name = "tbMaxSalary";
            this.tbMaxSalary.Size = new System.Drawing.Size(100, 20);
            this.tbMaxSalary.TabIndex = 6;
            // 
            // tbMinSalary
            // 
            this.tbMinSalary.Location = new System.Drawing.Point(112, 51);
            this.tbMinSalary.Name = "tbMinSalary";
            this.tbMinSalary.Size = new System.Drawing.Size(100, 20);
            this.tbMinSalary.TabIndex = 7;
            // 
            // btGetAll
            // 
            this.btGetAll.Location = new System.Drawing.Point(455, 284);
            this.btGetAll.Name = "btGetAll";
            this.btGetAll.Size = new System.Drawing.Size(75, 23);
            this.btGetAll.TabIndex = 8;
            this.btGetAll.Text = "GetAll";
            this.btGetAll.UseVisualStyleBackColor = true;
            this.btGetAll.Click += new System.EventHandler(this.btGetAll_Click);
            // 
            // dgvJob
            // 
            this.dgvJob.AllowUserToAddRows = false;
            this.dgvJob.AllowUserToDeleteRows = false;
            this.dgvJob.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJob.Location = new System.Drawing.Point(260, 21);
            this.dgvJob.Name = "dgvJob";
            this.dgvJob.ReadOnly = true;
            this.dgvJob.Size = new System.Drawing.Size(511, 240);
            this.dgvJob.TabIndex = 9;
            this.dgvJob.SelectionChanged += new System.EventHandler(this.dgvJob_SelectionChanged);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(361, 284);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 10;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.dgvJob);
            this.Controls.Add(this.btGetAll);
            this.Controls.Add(this.tbMinSalary);
            this.Controls.Add(this.tbMaxSalary);
            this.Controls.Add(this.tbTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbConnection);
            this.Controls.Add(this.btAdd);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvJob)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbConnection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.TextBox tbMaxSalary;
        private System.Windows.Forms.TextBox tbMinSalary;
        private System.Windows.Forms.Button btGetAll;
        private System.Windows.Forms.DataGridView dgvJob;
        private System.Windows.Forms.Button btnEdit;
    }
}

