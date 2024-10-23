using System;

namespace FormsApp
{
    partial class BootstrapForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblEnvironment = new System.Windows.Forms.Label();
            this.lblCriticity = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblPercent = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.cbCriticity = new System.Windows.Forms.ComboBox();
            this.clbEnvironment = new System.Windows.Forms.CheckedListBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.dtStartDate = new System.Windows.Forms.DateTimePicker();
            this.numDuration = new System.Windows.Forms.NumericUpDown();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.numPercentCompleted = new System.Windows.Forms.NumericUpDown();
            this.cbSendEmail = new System.Windows.Forms.CheckBox();
            this.btCancel = new System.Windows.Forms.Button();
            this.btSubmit = new System.Windows.Forms.Button();
            this.cbLocation = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPercentCompleted)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(144, 68);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(33, 16);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(91, 150);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(39, 16);
            this.lblType.TabIndex = 1;
            this.lblType.Text = "Type";
            // 
            // lblEnvironment
            // 
            this.lblEnvironment.AutoSize = true;
            this.lblEnvironment.Location = new System.Drawing.Point(425, 150);
            this.lblEnvironment.Name = "lblEnvironment";
            this.lblEnvironment.Size = new System.Drawing.Size(81, 16);
            this.lblEnvironment.TabIndex = 2;
            this.lblEnvironment.Text = "Environment";
            // 
            // lblCriticity
            // 
            this.lblCriticity.AutoSize = true;
            this.lblCriticity.Location = new System.Drawing.Point(266, 150);
            this.lblCriticity.Name = "lblCriticity";
            this.lblCriticity.Size = new System.Drawing.Size(49, 16);
            this.lblCriticity.TabIndex = 3;
            this.lblCriticity.Text = "Criticity";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(93, 238);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(75, 16);
            this.lblDescription.TabIndex = 4;
            this.lblDescription.Text = "Description";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(93, 383);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(64, 16);
            this.lblStartDate.TabIndex = 5;
            this.lblStartDate.Text = "Start date";
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Location = new System.Drawing.Point(266, 383);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(114, 16);
            this.lblDuration.TabIndex = 6;
            this.lblDuration.Text = "Duration (in hours)";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(93, 470);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(44, 16);
            this.lblStatus.TabIndex = 7;
            this.lblStatus.Text = "Status";
            // 
            // lblPercent
            // 
            this.lblPercent.AutoSize = true;
            this.lblPercent.Location = new System.Drawing.Point(266, 470);
            this.lblPercent.Name = "lblPercent";
            this.lblPercent.Size = new System.Drawing.Size(120, 16);
            this.lblPercent.TabIndex = 8;
            this.lblPercent.Text = "Percent completed";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(501, 68);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(58, 16);
            this.lblLocation.TabIndex = 9;
            this.lblLocation.Text = "Location";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(94, 103);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(140, 22);
            this.txtTitle.TabIndex = 10;
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "Incident"});
            this.cbType.Location = new System.Drawing.Point(94, 188);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(121, 24);
            this.cbType.TabIndex = 12;
            // 
            // cbCriticity
            // 
            this.cbCriticity.FormattingEnabled = true;
            this.cbCriticity.Items.AddRange(new object[] {
            "Minor",
            "Major"});
            this.cbCriticity.Location = new System.Drawing.Point(269, 188);
            this.cbCriticity.Name = "cbCriticity";
            this.cbCriticity.Size = new System.Drawing.Size(121, 24);
            this.cbCriticity.TabIndex = 13;
            // 
            // clbEnvironment
            // 
            this.clbEnvironment.FormattingEnabled = true;
            this.clbEnvironment.Items.AddRange(new object[] {
            "Prod",
            "PreProd",
            "Demo"});
            this.clbEnvironment.Location = new System.Drawing.Point(428, 188);
            this.clbEnvironment.Name = "clbEnvironment";
            this.clbEnvironment.Size = new System.Drawing.Size(103, 55);
            this.clbEnvironment.TabIndex = 14;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(94, 272);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(510, 97);
            this.txtDescription.TabIndex = 15;
            // 
            // dtStartDate
            // 
            this.dtStartDate.CustomFormat = " ";
            this.dtStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtStartDate.Location = new System.Drawing.Point(94, 417);
            this.dtStartDate.Name = "dtStartDate";
            this.dtStartDate.Size = new System.Drawing.Size(140, 22);
            this.dtStartDate.TabIndex = 16;
            this.dtStartDate.ValueChanged += new System.EventHandler(this.dtStartDate_ValueChanged);
            this.dtStartDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtStartDate_KeyDown);
            // 
            // numDuration
            // 
            this.numDuration.DecimalPlaces = 2;
            this.numDuration.Location = new System.Drawing.Point(269, 417);
            this.numDuration.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numDuration.Name = "numDuration";
            this.numDuration.Size = new System.Drawing.Size(120, 22);
            this.numDuration.TabIndex = 17;
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Planed"});
            this.cbStatus.Location = new System.Drawing.Point(96, 503);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(121, 24);
            this.cbStatus.TabIndex = 18;
            // 
            // numPercentCompleted
            // 
            this.numPercentCompleted.DecimalPlaces = 2;
            this.numPercentCompleted.Location = new System.Drawing.Point(269, 503);
            this.numPercentCompleted.Name = "numPercentCompleted";
            this.numPercentCompleted.Size = new System.Drawing.Size(120, 22);
            this.numPercentCompleted.TabIndex = 20;
            // 
            // cbSendEmail
            // 
            this.cbSendEmail.AutoSize = true;
            this.cbSendEmail.Location = new System.Drawing.Point(92, 557);
            this.cbSendEmail.Name = "cbSendEmail";
            this.cbSendEmail.Size = new System.Drawing.Size(262, 20);
            this.cbSendEmail.TabIndex = 21;
            this.cbSendEmail.Text = "Check here if you want to send an email";
            this.cbSendEmail.UseVisualStyleBackColor = true;
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(481, 620);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 22;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // btSubmit
            // 
            this.btSubmit.Location = new System.Drawing.Point(581, 620);
            this.btSubmit.Name = "btSubmit";
            this.btSubmit.Size = new System.Drawing.Size(75, 23);
            this.btSubmit.TabIndex = 23;
            this.btSubmit.Text = "Submit";
            this.btSubmit.UseVisualStyleBackColor = true;
            this.btSubmit.Click += new System.EventHandler(this.btnSubmit_Submit);
            // 
            // cbLocation
            // 
            this.cbLocation.FormattingEnabled = true;
            this.cbLocation.Items.AddRange(new object[] {
            "Barcelona",
            "Madrid",
            "Ansalucia"});
            this.cbLocation.Location = new System.Drawing.Point(468, 103);
            this.cbLocation.Name = "cbLocation";
            this.cbLocation.Size = new System.Drawing.Size(121, 24);
            this.cbLocation.TabIndex = 24;
            // 
            // BootstrapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 669);
            this.Controls.Add(this.cbLocation);
            this.Controls.Add(this.btSubmit);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.cbSendEmail);
            this.Controls.Add(this.numPercentCompleted);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.numDuration);
            this.Controls.Add(this.dtStartDate);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.clbEnvironment);
            this.Controls.Add(this.cbCriticity);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lblPercent);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblDuration);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblCriticity);
            this.Controls.Add(this.lblEnvironment);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblTitle);
            this.Name = "BootstrapForm";
            this.Text = "FirstForm";
            ((System.ComponentModel.ISupportInitialize)(this.numDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPercentCompleted)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblEnvironment;
        private System.Windows.Forms.Label lblCriticity;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblPercent;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.ComboBox cbCriticity;
        private System.Windows.Forms.CheckedListBox clbEnvironment;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.DateTimePicker dtStartDate;
        private System.Windows.Forms.NumericUpDown numDuration;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.NumericUpDown numPercentCompleted;
        private System.Windows.Forms.CheckBox cbSendEmail;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btSubmit;
        private System.Windows.Forms.ComboBox cbLocation;
    }
}

