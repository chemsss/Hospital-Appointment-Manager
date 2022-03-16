namespace assignment2
{
    partial class Search_Appoint_Form
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
            this.chooseDate_groupBox = new System.Windows.Forms.GroupBox();
            this.cancel_button = new System.Windows.Forms.Button();
            this.ok_button = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.doctor_groupBox = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.doctorName_textBox = new System.Windows.Forms.TextBox();
            this.speciality_label = new System.Windows.Forms.Label();
            this.doctorName_label = new System.Windows.Forms.Label();
            this.patient_groupBox = new System.Windows.Forms.GroupBox();
            this.BirthDate_label = new System.Windows.Forms.Label();
            this.patientName_label = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.patientName_textBox = new System.Windows.Forms.TextBox();
            this.chooseDate_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.doctor_groupBox.SuspendLayout();
            this.patient_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // chooseDate_groupBox
            // 
            this.chooseDate_groupBox.Controls.Add(this.cancel_button);
            this.chooseDate_groupBox.Controls.Add(this.ok_button);
            this.chooseDate_groupBox.Controls.Add(this.dateTimePicker1);
            this.chooseDate_groupBox.Location = new System.Drawing.Point(34, 39);
            this.chooseDate_groupBox.Name = "chooseDate_groupBox";
            this.chooseDate_groupBox.Size = new System.Drawing.Size(722, 136);
            this.chooseDate_groupBox.TabIndex = 0;
            this.chooseDate_groupBox.TabStop = false;
            this.chooseDate_groupBox.Text = "Choose the date";
            // 
            // cancel_button
            // 
            this.cancel_button.Location = new System.Drawing.Point(611, 77);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(75, 23);
            this.cancel_button.TabIndex = 2;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // ok_button
            // 
            this.ok_button.Location = new System.Drawing.Point(611, 48);
            this.ok_button.Name = "ok_button";
            this.ok_button.Size = new System.Drawing.Size(75, 23);
            this.ok_button.TabIndex = 1;
            this.ok_button.Text = "Ok";
            this.ok_button.UseVisualStyleBackColor = true;
            this.ok_button.Click += new System.EventHandler(this.ok_button_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(30, 55);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(34, 198);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(722, 117);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // doctor_groupBox
            // 
            this.doctor_groupBox.Controls.Add(this.textBox2);
            this.doctor_groupBox.Controls.Add(this.doctorName_textBox);
            this.doctor_groupBox.Controls.Add(this.speciality_label);
            this.doctor_groupBox.Controls.Add(this.doctorName_label);
            this.doctor_groupBox.Location = new System.Drawing.Point(34, 338);
            this.doctor_groupBox.Name = "doctor_groupBox";
            this.doctor_groupBox.Size = new System.Drawing.Size(311, 100);
            this.doctor_groupBox.TabIndex = 2;
            this.doctor_groupBox.TabStop = false;
            this.doctor_groupBox.Text = "Doctor";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(79, 56);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(200, 23);
            this.textBox2.TabIndex = 3;
            // 
            // doctorName_textBox
            // 
            this.doctorName_textBox.Location = new System.Drawing.Point(79, 27);
            this.doctorName_textBox.Name = "doctorName_textBox";
            this.doctorName_textBox.Size = new System.Drawing.Size(200, 23);
            this.doctorName_textBox.TabIndex = 2;
            // 
            // speciality_label
            // 
            this.speciality_label.AutoSize = true;
            this.speciality_label.Location = new System.Drawing.Point(16, 59);
            this.speciality_label.Name = "speciality_label";
            this.speciality_label.Size = new System.Drawing.Size(57, 15);
            this.speciality_label.TabIndex = 1;
            this.speciality_label.Text = "Speciality";
            // 
            // doctorName_label
            // 
            this.doctorName_label.AutoSize = true;
            this.doctorName_label.Location = new System.Drawing.Point(16, 30);
            this.doctorName_label.Name = "doctorName_label";
            this.doctorName_label.Size = new System.Drawing.Size(39, 15);
            this.doctorName_label.TabIndex = 0;
            this.doctorName_label.Text = "Name";
            // 
            // patient_groupBox
            // 
            this.patient_groupBox.Controls.Add(this.BirthDate_label);
            this.patient_groupBox.Controls.Add(this.patientName_label);
            this.patient_groupBox.Controls.Add(this.dateTimePicker2);
            this.patient_groupBox.Controls.Add(this.patientName_textBox);
            this.patient_groupBox.Location = new System.Drawing.Point(453, 338);
            this.patient_groupBox.Name = "patient_groupBox";
            this.patient_groupBox.Size = new System.Drawing.Size(303, 100);
            this.patient_groupBox.TabIndex = 3;
            this.patient_groupBox.TabStop = false;
            this.patient_groupBox.Text = "Patient";
            // 
            // BirthDate_label
            // 
            this.BirthDate_label.AutoSize = true;
            this.BirthDate_label.Location = new System.Drawing.Point(31, 64);
            this.BirthDate_label.Name = "BirthDate_label";
            this.BirthDate_label.Size = new System.Drawing.Size(59, 15);
            this.BirthDate_label.TabIndex = 6;
            this.BirthDate_label.Text = "Birth Date";
            // 
            // patientName_label
            // 
            this.patientName_label.AutoSize = true;
            this.patientName_label.Location = new System.Drawing.Point(31, 33);
            this.patientName_label.Name = "patientName_label";
            this.patientName_label.Size = new System.Drawing.Size(39, 15);
            this.patientName_label.TabIndex = 5;
            this.patientName_label.Text = "Name";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(91, 59);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker2.TabIndex = 4;
            // 
            // patientName_textBox
            // 
            this.patientName_textBox.Location = new System.Drawing.Point(91, 30);
            this.patientName_textBox.Name = "patientName_textBox";
            this.patientName_textBox.Size = new System.Drawing.Size(200, 23);
            this.patientName_textBox.TabIndex = 0;
            // 
            // Search_Appoint_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.patient_groupBox);
            this.Controls.Add(this.doctor_groupBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.chooseDate_groupBox);
            this.Name = "Search_Appoint_Form";
            this.Text = "Search_Appointment";
            this.chooseDate_groupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.doctor_groupBox.ResumeLayout(false);
            this.doctor_groupBox.PerformLayout();
            this.patient_groupBox.ResumeLayout(false);
            this.patient_groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox chooseDate_groupBox;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Button ok_button;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox doctor_groupBox;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox doctorName_textBox;
        private System.Windows.Forms.Label speciality_label;
        private System.Windows.Forms.Label doctorName_label;
        private System.Windows.Forms.GroupBox patient_groupBox;
        private System.Windows.Forms.Label BirthDate_label;
        private System.Windows.Forms.Label patientName_label;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.TextBox patientName_textBox;
    }
}