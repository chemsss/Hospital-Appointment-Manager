namespace assignment2
{
    partial class Appoint_Manag_Form
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
            this.Appoint_Manag_groupBox = new System.Windows.Forms.GroupBox();
            this.appointAdd_button = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
            this.AppointNew_button = new System.Windows.Forms.Button();
            this.appointment_groupBox = new System.Windows.Forms.GroupBox();
            this.appointTime_maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.appointDate_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.appointTime_label = new System.Windows.Forms.Label();
            this.appointDate_label = new System.Windows.Forms.Label();
            this.doctor_groupBox = new System.Windows.Forms.GroupBox();
            this.doctorCode_comboBox = new System.Windows.Forms.ComboBox();
            this.doctorName_textBox = new System.Windows.Forms.TextBox();
            this.doctorSpeciality_textBox = new System.Windows.Forms.TextBox();
            this.doctorSpeciality_label = new System.Windows.Forms.Label();
            this.doctorName_label = new System.Windows.Forms.Label();
            this.doctorCode_label = new System.Windows.Forms.Label();
            this.patient_groupBox = new System.Windows.Forms.GroupBox();
            this.patientMale_radioButton = new System.Windows.Forms.RadioButton();
            this.patientFemale_radioButton = new System.Windows.Forms.RadioButton();
            this.patientName_textBox = new System.Windows.Forms.TextBox();
            this.patientCode_comboBox = new System.Windows.Forms.ComboBox();
            this.patientGender_label = new System.Windows.Forms.Label();
            this.patientName_label = new System.Windows.Forms.Label();
            this.patientCode_label = new System.Windows.Forms.Label();
            this.Appoint_Manag_groupBox.SuspendLayout();
            this.appointment_groupBox.SuspendLayout();
            this.doctor_groupBox.SuspendLayout();
            this.patient_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Appoint_Manag_groupBox
            // 
            this.Appoint_Manag_groupBox.Controls.Add(this.appointAdd_button);
            this.Appoint_Manag_groupBox.Controls.Add(this.exit_button);
            this.Appoint_Manag_groupBox.Controls.Add(this.AppointNew_button);
            this.Appoint_Manag_groupBox.Controls.Add(this.appointment_groupBox);
            this.Appoint_Manag_groupBox.Controls.Add(this.doctor_groupBox);
            this.Appoint_Manag_groupBox.Controls.Add(this.patient_groupBox);
            this.Appoint_Manag_groupBox.Location = new System.Drawing.Point(12, 12);
            this.Appoint_Manag_groupBox.Name = "Appoint_Manag_groupBox";
            this.Appoint_Manag_groupBox.Size = new System.Drawing.Size(776, 426);
            this.Appoint_Manag_groupBox.TabIndex = 0;
            this.Appoint_Manag_groupBox.TabStop = false;
            this.Appoint_Manag_groupBox.Text = "Appointement Management";
            // 
            // appointAdd_button
            // 
            this.appointAdd_button.Location = new System.Drawing.Point(569, 299);
            this.appointAdd_button.Name = "appointAdd_button";
            this.appointAdd_button.Size = new System.Drawing.Size(166, 23);
            this.appointAdd_button.TabIndex = 6;
            this.appointAdd_button.Text = "Add Appointment";
            this.appointAdd_button.UseVisualStyleBackColor = true;
            this.appointAdd_button.Click += new System.EventHandler(this.appointAdd_button_Click);
            // 
            // exit_button
            // 
            this.exit_button.Location = new System.Drawing.Point(569, 358);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(166, 23);
            this.exit_button.TabIndex = 5;
            this.exit_button.Text = "Exit";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // AppointNew_button
            // 
            this.AppointNew_button.Location = new System.Drawing.Point(569, 328);
            this.AppointNew_button.Name = "AppointNew_button";
            this.AppointNew_button.Size = new System.Drawing.Size(166, 23);
            this.AppointNew_button.TabIndex = 4;
            this.AppointNew_button.Text = "New";
            this.AppointNew_button.UseVisualStyleBackColor = true;
            this.AppointNew_button.Click += new System.EventHandler(this.AppointNew_button_Click);
            // 
            // appointment_groupBox
            // 
            this.appointment_groupBox.Controls.Add(this.appointTime_maskedTextBox);
            this.appointment_groupBox.Controls.Add(this.appointDate_dateTimePicker);
            this.appointment_groupBox.Controls.Add(this.appointTime_label);
            this.appointment_groupBox.Controls.Add(this.appointDate_label);
            this.appointment_groupBox.Location = new System.Drawing.Point(40, 277);
            this.appointment_groupBox.Name = "appointment_groupBox";
            this.appointment_groupBox.Size = new System.Drawing.Size(439, 133);
            this.appointment_groupBox.TabIndex = 2;
            this.appointment_groupBox.TabStop = false;
            // 
            // appointTime_maskedTextBox
            // 
            this.appointTime_maskedTextBox.Location = new System.Drawing.Point(143, 78);
            this.appointTime_maskedTextBox.Mask = "00:00";
            this.appointTime_maskedTextBox.Name = "appointTime_maskedTextBox";
            this.appointTime_maskedTextBox.Size = new System.Drawing.Size(200, 23);
            this.appointTime_maskedTextBox.TabIndex = 3;
            this.appointTime_maskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // appointDate_dateTimePicker
            // 
            this.appointDate_dateTimePicker.Location = new System.Drawing.Point(143, 34);
            this.appointDate_dateTimePicker.Name = "appointDate_dateTimePicker";
            this.appointDate_dateTimePicker.Size = new System.Drawing.Size(200, 23);
            this.appointDate_dateTimePicker.TabIndex = 2;
            // 
            // appointTime_label
            // 
            this.appointTime_label.AutoSize = true;
            this.appointTime_label.Location = new System.Drawing.Point(20, 81);
            this.appointTime_label.Name = "appointTime_label";
            this.appointTime_label.Size = new System.Drawing.Size(107, 15);
            this.appointTime_label.TabIndex = 1;
            this.appointTime_label.Text = "Appointment Time";
            // 
            // appointDate_label
            // 
            this.appointDate_label.AutoSize = true;
            this.appointDate_label.Location = new System.Drawing.Point(20, 40);
            this.appointDate_label.Name = "appointDate_label";
            this.appointDate_label.Size = new System.Drawing.Size(105, 15);
            this.appointDate_label.TabIndex = 0;
            this.appointDate_label.Text = "Appointment Date";
            // 
            // doctor_groupBox
            // 
            this.doctor_groupBox.Controls.Add(this.doctorCode_comboBox);
            this.doctor_groupBox.Controls.Add(this.doctorName_textBox);
            this.doctor_groupBox.Controls.Add(this.doctorSpeciality_textBox);
            this.doctor_groupBox.Controls.Add(this.doctorSpeciality_label);
            this.doctor_groupBox.Controls.Add(this.doctorName_label);
            this.doctor_groupBox.Controls.Add(this.doctorCode_label);
            this.doctor_groupBox.Location = new System.Drawing.Point(406, 54);
            this.doctor_groupBox.Name = "doctor_groupBox";
            this.doctor_groupBox.Size = new System.Drawing.Size(329, 217);
            this.doctor_groupBox.TabIndex = 1;
            this.doctor_groupBox.TabStop = false;
            // 
            // doctorCode_comboBox
            // 
            this.doctorCode_comboBox.FormattingEnabled = true;
            this.doctorCode_comboBox.Location = new System.Drawing.Point(163, 39);
            this.doctorCode_comboBox.Name = "doctorCode_comboBox";
            this.doctorCode_comboBox.Size = new System.Drawing.Size(121, 23);
            this.doctorCode_comboBox.TabIndex = 5;
            this.doctorCode_comboBox.SelectedIndexChanged += new System.EventHandler(this.doctorCode_SelectedIndexChanged);
            this.get_doctors();
            // 
            // doctorName_textBox
            // 
            this.doctorName_textBox.Location = new System.Drawing.Point(163, 69);
            this.doctorName_textBox.Name = "doctorName_textBox";
            this.doctorName_textBox.Size = new System.Drawing.Size(121, 23);
            this.doctorName_textBox.TabIndex = 4;
            // 
            // doctorSpeciality_textBox
            // 
            this.doctorSpeciality_textBox.Location = new System.Drawing.Point(163, 129);
            this.doctorSpeciality_textBox.Name = "doctorSpeciality_textBox";
            this.doctorSpeciality_textBox.Size = new System.Drawing.Size(121, 23);
            this.doctorSpeciality_textBox.TabIndex = 3;
            // 
            // doctorSpeciality_label
            // 
            this.doctorSpeciality_label.AutoSize = true;
            this.doctorSpeciality_label.Location = new System.Drawing.Point(51, 133);
            this.doctorSpeciality_label.Name = "doctorSpeciality_label";
            this.doctorSpeciality_label.Size = new System.Drawing.Size(96, 15);
            this.doctorSpeciality_label.TabIndex = 2;
            this.doctorSpeciality_label.Text = "Doctor Speciality";
            // 
            // doctorName_label
            // 
            this.doctorName_label.AutoSize = true;
            this.doctorName_label.Location = new System.Drawing.Point(51, 72);
            this.doctorName_label.Name = "doctorName_label";
            this.doctorName_label.Size = new System.Drawing.Size(78, 15);
            this.doctorName_label.TabIndex = 1;
            this.doctorName_label.Text = "Doctor Name";
            // 
            // doctorCode_label
            // 
            this.doctorCode_label.AutoSize = true;
            this.doctorCode_label.Location = new System.Drawing.Point(51, 42);
            this.doctorCode_label.Name = "doctorCode_label";
            this.doctorCode_label.Size = new System.Drawing.Size(74, 15);
            this.doctorCode_label.TabIndex = 0;
            this.doctorCode_label.Text = "Doctor Code";
            // 
            // patient_groupBox
            // 
            this.patient_groupBox.Controls.Add(this.patientMale_radioButton);
            this.patient_groupBox.Controls.Add(this.patientFemale_radioButton);
            this.patient_groupBox.Controls.Add(this.patientName_textBox);
            this.patient_groupBox.Controls.Add(this.patientCode_comboBox);
            this.patient_groupBox.Controls.Add(this.patientGender_label);
            this.patient_groupBox.Controls.Add(this.patientName_label);
            this.patient_groupBox.Controls.Add(this.patientCode_label);
            this.patient_groupBox.Location = new System.Drawing.Point(40, 54);
            this.patient_groupBox.Name = "patient_groupBox";
            this.patient_groupBox.Size = new System.Drawing.Size(329, 217);
            this.patient_groupBox.TabIndex = 0;
            this.patient_groupBox.TabStop = false;
            // 
            // patientMale_radioButton
            // 
            this.patientMale_radioButton.AutoSize = true;
            this.patientMale_radioButton.Location = new System.Drawing.Point(143, 158);
            this.patientMale_radioButton.Name = "patientMale_radioButton";
            this.patientMale_radioButton.Size = new System.Drawing.Size(36, 19);
            this.patientMale_radioButton.TabIndex = 6;
            this.patientMale_radioButton.TabStop = true;
            this.patientMale_radioButton.Text = "M";
            this.patientMale_radioButton.UseVisualStyleBackColor = true;
            // 
            // patientFemale_radioButton
            // 
            this.patientFemale_radioButton.AutoSize = true;
            this.patientFemale_radioButton.Location = new System.Drawing.Point(143, 133);
            this.patientFemale_radioButton.Name = "patientFemale_radioButton";
            this.patientFemale_radioButton.Size = new System.Drawing.Size(31, 19);
            this.patientFemale_radioButton.TabIndex = 5;
            this.patientFemale_radioButton.TabStop = true;
            this.patientFemale_radioButton.Text = "F";
            this.patientFemale_radioButton.UseVisualStyleBackColor = true;
            // 
            // patientName_textBox
            // 
            this.patientName_textBox.Location = new System.Drawing.Point(143, 72);
            this.patientName_textBox.Name = "patientName_textBox";
            this.patientName_textBox.Size = new System.Drawing.Size(121, 23);
            this.patientName_textBox.TabIndex = 4;
            // 
            // patientCode_comboBox
            // 
            this.patientCode_comboBox.FormattingEnabled = true;
            this.patientCode_comboBox.Location = new System.Drawing.Point(143, 39);
            this.patientCode_comboBox.Name = "patientCode_comboBox";
            this.patientCode_comboBox.Size = new System.Drawing.Size(121, 23);
            this.patientCode_comboBox.TabIndex = 3;
            this.patientCode_comboBox.SelectedIndexChanged += new System.EventHandler(this.patientCode_comboBox_SelectedIndexChanged);
            this.get_patients();
            // 
            // patientGender_label
            // 
            this.patientGender_label.AutoSize = true;
            this.patientGender_label.Location = new System.Drawing.Point(40, 135);
            this.patientGender_label.Name = "patientGender_label";
            this.patientGender_label.Size = new System.Drawing.Size(85, 15);
            this.patientGender_label.TabIndex = 2;
            this.patientGender_label.Text = "Patient Gender";
            // 
            // patientName_label
            // 
            this.patientName_label.AutoSize = true;
            this.patientName_label.Location = new System.Drawing.Point(40, 75);
            this.patientName_label.Name = "patientName_label";
            this.patientName_label.Size = new System.Drawing.Size(79, 15);
            this.patientName_label.TabIndex = 1;
            this.patientName_label.Text = "Patient Name";
            // 
            // patientCode_label
            // 
            this.patientCode_label.AutoSize = true;
            this.patientCode_label.Location = new System.Drawing.Point(40, 42);
            this.patientCode_label.Name = "patientCode_label";
            this.patientCode_label.Size = new System.Drawing.Size(75, 15);
            this.patientCode_label.TabIndex = 0;
            this.patientCode_label.Text = "Patient Code";
            // 
            // Appoint_Manag_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Appoint_Manag_groupBox);
            this.Name = "Appoint_Manag_Form";
            this.Text = "Appointment_Management";
            this.Appoint_Manag_groupBox.ResumeLayout(false);
            this.appointment_groupBox.ResumeLayout(false);
            this.appointment_groupBox.PerformLayout();
            this.doctor_groupBox.ResumeLayout(false);
            this.doctor_groupBox.PerformLayout();
            this.patient_groupBox.ResumeLayout(false);
            this.patient_groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Appoint_Manag_groupBox;
        private System.Windows.Forms.GroupBox appointment_groupBox;
        private System.Windows.Forms.GroupBox doctor_groupBox;
        private System.Windows.Forms.GroupBox patient_groupBox;
        private System.Windows.Forms.RadioButton patientMale_radioButton;
        private System.Windows.Forms.RadioButton patientFemale_radioButton;
        private System.Windows.Forms.TextBox patientName_textBox;
        private System.Windows.Forms.ComboBox patientCode_comboBox;
        private System.Windows.Forms.Label patientGender_label;
        private System.Windows.Forms.Label patientName_label;
        private System.Windows.Forms.Label patientCode_label;
        private System.Windows.Forms.ComboBox doctorCode_comboBox;
        private System.Windows.Forms.TextBox doctorName_textBox;
        private System.Windows.Forms.TextBox doctorSpeciality_textBox;
        private System.Windows.Forms.Label doctorSpeciality_label;
        private System.Windows.Forms.Label doctorName_label;
        private System.Windows.Forms.Label doctorCode_label;
        private System.Windows.Forms.DateTimePicker appointDate_dateTimePicker;
        private System.Windows.Forms.Label appointTime_label;
        private System.Windows.Forms.Label appointDate_label;
        private System.Windows.Forms.Button appointAdd_button;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Button AppointNew_button;
        private System.Windows.Forms.MaskedTextBox appointTime_maskedTextBox;
    }
}