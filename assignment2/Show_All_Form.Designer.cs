namespace assignment2
{
    partial class Show_All_Form
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
            this.choice_groupBox = new System.Windows.Forms.GroupBox();
            this.doctors_radioButton = new System.Windows.Forms.RadioButton();
            this.patients_radioButton = new System.Windows.Forms.RadioButton();
            this.appoint_radioButton = new System.Windows.Forms.RadioButton();
            this.choice_dataGridView = new System.Windows.Forms.DataGridView();
            this.choice_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.choice_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // choice_groupBox
            // 
            this.choice_groupBox.Controls.Add(this.appoint_radioButton);
            this.choice_groupBox.Controls.Add(this.patients_radioButton);
            this.choice_groupBox.Controls.Add(this.doctors_radioButton);
            this.choice_groupBox.Location = new System.Drawing.Point(48, 66);
            this.choice_groupBox.Name = "choice_groupBox";
            this.choice_groupBox.Size = new System.Drawing.Size(696, 136);
            this.choice_groupBox.TabIndex = 0;
            this.choice_groupBox.TabStop = false;
            this.choice_groupBox.Text = "Choice";
            // 
            // doctors_radioButton
            // 
            this.doctors_radioButton.AutoSize = true;
            this.doctors_radioButton.Location = new System.Drawing.Point(45, 62);
            this.doctors_radioButton.Name = "doctors_radioButton";
            this.doctors_radioButton.Size = new System.Drawing.Size(102, 19);
            this.doctors_radioButton.TabIndex = 1;
            this.doctors_radioButton.TabStop = true;
            this.doctors_radioButton.Text = "All the doctors";
            this.doctors_radioButton.UseVisualStyleBackColor = true;
            this.doctors_radioButton.CheckedChanged += new System.EventHandler(this.doctors_radioButton_CheckedChanged);
            // 
            // patients_radioButton
            // 
            this.patients_radioButton.AutoSize = true;
            this.patients_radioButton.Location = new System.Drawing.Point(296, 62);
            this.patients_radioButton.Name = "patients_radioButton";
            this.patients_radioButton.Size = new System.Drawing.Size(104, 19);
            this.patients_radioButton.TabIndex = 2;
            this.patients_radioButton.TabStop = true;
            this.patients_radioButton.Text = "All the patients";
            this.patients_radioButton.UseVisualStyleBackColor = true;
            this.patients_radioButton.CheckedChanged += new System.EventHandler(this.patients_radioButton_CheckedChanged);
            // 
            // appoint_radioButton
            // 
            this.appoint_radioButton.AutoSize = true;
            this.appoint_radioButton.Location = new System.Drawing.Point(530, 62);
            this.appoint_radioButton.Name = "appoint_radioButton";
            this.appoint_radioButton.Size = new System.Drawing.Size(136, 19);
            this.appoint_radioButton.TabIndex = 1;
            this.appoint_radioButton.TabStop = true;
            this.appoint_radioButton.Text = "All the appointments";
            this.appoint_radioButton.UseVisualStyleBackColor = true;
            this.appoint_radioButton.CheckedChanged += new System.EventHandler(this.appoint_radioButton_CheckedChanged);
            // 
            // choice_dataGridView
            // 
            this.choice_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.choice_dataGridView.Location = new System.Drawing.Point(48, 234);
            this.choice_dataGridView.Name = "choice_dataGridView";
            this.choice_dataGridView.RowTemplate.Height = 25;
            this.choice_dataGridView.Size = new System.Drawing.Size(696, 175);
            this.choice_dataGridView.TabIndex = 1;
            // 
            // Show_All_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.choice_dataGridView);
            this.Controls.Add(this.choice_groupBox);
            this.Name = "Show_All_Form";
            this.Text = "Show_All";
            this.choice_groupBox.ResumeLayout(false);
            this.choice_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.choice_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox choice_groupBox;
        private System.Windows.Forms.RadioButton appoint_radioButton;
        private System.Windows.Forms.RadioButton patients_radioButton;
        private System.Windows.Forms.RadioButton doctors_radioButton;
        private System.Windows.Forms.DataGridView choice_dataGridView;
    }
}