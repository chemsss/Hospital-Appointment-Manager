using System.Windows.Forms;

namespace assignment2
{
    partial class Doc_Manag_Form
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

        //DbConnection
        private string DbConnection;
        public Doc_Manag_Form(string dbConnection)
        {
            this.DbConnection = dbConnection;
        }



        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.doc_manag_groupbox = new System.Windows.Forms.GroupBox();
            this.code_label = new System.Windows.Forms.Label();
            this.code_textBox = new System.Windows.Forms.TextBox();
            this.name_label = new System.Windows.Forms.Label();
            this.name_textBox = new System.Windows.Forms.TextBox();
            this.telephone_label = new System.Windows.Forms.Label();
            this.telephone_textBox = new System.Windows.Forms.TextBox();
            this.hiringDate_label = new System.Windows.Forms.Label();
            this.hiringDate_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.speciality_label = new System.Windows.Forms.Label();
            this.speciality_comboBox = new System.Windows.Forms.ComboBox();
            this.new_btn = new System.Windows.Forms.Button();
            this.search_btn = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            this.edit_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            this.doc_manag_groupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // doc_manag_groupbox
            // 
            this.doc_manag_groupbox.Controls.Add(this.exit_btn);
            this.doc_manag_groupbox.Controls.Add(this.delete_btn);
            this.doc_manag_groupbox.Controls.Add(this.edit_btn);
            this.doc_manag_groupbox.Controls.Add(this.add_btn);
            this.doc_manag_groupbox.Controls.Add(this.search_btn);
            this.doc_manag_groupbox.Controls.Add(this.new_btn);
            this.doc_manag_groupbox.Controls.Add(this.speciality_comboBox);
            this.doc_manag_groupbox.Controls.Add(this.speciality_label);
            this.doc_manag_groupbox.Controls.Add(this.hiringDate_dateTimePicker);
            this.doc_manag_groupbox.Controls.Add(this.hiringDate_label);
            this.doc_manag_groupbox.Controls.Add(this.telephone_textBox);
            this.doc_manag_groupbox.Controls.Add(this.telephone_label);
            this.doc_manag_groupbox.Controls.Add(this.name_textBox);
            this.doc_manag_groupbox.Controls.Add(this.name_label);
            this.doc_manag_groupbox.Controls.Add(this.code_textBox);
            this.doc_manag_groupbox.Controls.Add(this.code_label);
            this.doc_manag_groupbox.Location = new System.Drawing.Point(28, 26);
            this.doc_manag_groupbox.Name = "doc_manag_groupbox";
            this.doc_manag_groupbox.Size = new System.Drawing.Size(741, 412);
            this.doc_manag_groupbox.TabIndex = 0;
            this.doc_manag_groupbox.TabStop = false;
            this.doc_manag_groupbox.Text = "Doctor Management";
            this.doc_manag_groupbox.Enter += new System.EventHandler(this.doc_manag_groupbox_Enter);
            // 
            // code_label
            // 
            this.code_label.AutoSize = true;
            this.code_label.Location = new System.Drawing.Point(41, 71);
            this.code_label.Name = "code_label";
            this.code_label.Size = new System.Drawing.Size(33, 15);
            this.code_label.TabIndex = 0;
            this.code_label.Text = "code";
            // 
            // code_textBox
            // 
            this.code_textBox.Location = new System.Drawing.Point(114, 68);
            this.code_textBox.Name = "code_textBox";
            this.code_textBox.Size = new System.Drawing.Size(100, 23);
            this.code_textBox.TabIndex = 1;
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Location = new System.Drawing.Point(41, 112);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(39, 15);
            this.name_label.TabIndex = 2;
            this.name_label.Text = "Name";
            this.name_label.Click += new System.EventHandler(this.name_label_Click);
            // 
            // name_textBox
            // 
            this.name_textBox.Location = new System.Drawing.Point(114, 109);
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.Size = new System.Drawing.Size(100, 23);
            this.name_textBox.TabIndex = 3;
            this.name_textBox.TextChanged += new System.EventHandler(this.name_textBox_TextChanged);
            // 
            // telephone_label
            // 
            this.telephone_label.AutoSize = true;
            this.telephone_label.Location = new System.Drawing.Point(41, 150);
            this.telephone_label.Name = "telephone_label";
            this.telephone_label.Size = new System.Drawing.Size(61, 15);
            this.telephone_label.TabIndex = 4;
            this.telephone_label.Text = "Telephone";
            // 
            // telephone_textBox
            // 
            this.telephone_textBox.Location = new System.Drawing.Point(114, 147);
            this.telephone_textBox.Name = "telephone_textBox";
            this.telephone_textBox.Size = new System.Drawing.Size(100, 23);
            this.telephone_textBox.TabIndex = 5;
            // 
            // hiringDate_label
            // 
            this.hiringDate_label.AutoSize = true;
            this.hiringDate_label.Location = new System.Drawing.Point(41, 190);
            this.hiringDate_label.Name = "hiringDate_label";
            this.hiringDate_label.Size = new System.Drawing.Size(67, 15);
            this.hiringDate_label.TabIndex = 6;
            this.hiringDate_label.Text = "Hiring Date";
            this.hiringDate_label.Click += new System.EventHandler(this.hiringDate_label_Click);
            // 
            // hiringDate_dateTimePicker
            // 
            this.hiringDate_dateTimePicker.Location = new System.Drawing.Point(114, 184);
            this.hiringDate_dateTimePicker.Name = "hiringDate_dateTimePicker";
            this.hiringDate_dateTimePicker.Size = new System.Drawing.Size(200, 23);
            this.hiringDate_dateTimePicker.TabIndex = 7;
            this.hiringDate_dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // speciality_label
            // 
            this.speciality_label.AutoSize = true;
            this.speciality_label.Location = new System.Drawing.Point(42, 228);
            this.speciality_label.Name = "speciality_label";
            this.speciality_label.Size = new System.Drawing.Size(57, 15);
            this.speciality_label.TabIndex = 8;
            this.speciality_label.Text = "Speciality";
            this.get_specialities();
            // 
            // speciality_comboBox
            // 
            this.speciality_comboBox.FormattingEnabled = true;
            this.speciality_comboBox.Location = new System.Drawing.Point(114, 225);
            this.speciality_comboBox.Name = "speciality_comboBox";
            this.speciality_comboBox.Size = new System.Drawing.Size(121, 23);
            this.speciality_comboBox.TabIndex = 9;
            this.speciality_comboBox.TabIndex = 9;
            // 
            // new_btn
            // 
            this.new_btn.Location = new System.Drawing.Point(587, 75);
            this.new_btn.Name = "new_btn";
            this.new_btn.Size = new System.Drawing.Size(75, 23);
            this.new_btn.TabIndex = 10;
            this.new_btn.Text = "New";
            this.new_btn.UseVisualStyleBackColor = true;
            this.new_btn.Click += new System.EventHandler(this.new_btn_Click);

            // 
            // search_btn
            // 
            this.search_btn.Location = new System.Drawing.Point(587, 104);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(75, 23);
            this.search_btn.TabIndex = 11;
            this.search_btn.Text = "Search";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);

            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(587, 133);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(75, 23);
            this.add_btn.TabIndex = 12;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = true; 
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // edit_btn
            // 
            this.edit_btn.Location = new System.Drawing.Point(587, 162);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(75, 23);
            this.edit_btn.TabIndex = 13;
            this.edit_btn.Text = "Edit";
            this.edit_btn.UseVisualStyleBackColor = true; 
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.Location = new System.Drawing.Point(587, 191);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(75, 23);
            this.delete_btn.TabIndex = 14;
            this.delete_btn.Text = "Delete";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // exit_btn
            // 
            this.exit_btn.Location = new System.Drawing.Point(587, 220);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(75, 23);
            this.exit_btn.TabIndex = 15;
            this.exit_btn.Text = "Exit";
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // Doc_Manag_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.doc_manag_groupbox);
            this.Name = "Doc_Manag_Form";
            this.Text = "Doctor_Management";
            this.doc_manag_groupbox.ResumeLayout(false);
            this.doc_manag_groupbox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox doc_manag_groupbox;
        private TextBox name_textBox;
        private Label name_label;
        private TextBox code_textBox;
        private Label code_label;
        private TextBox telephone_textBox;
        private Label telephone_label;
        private DateTimePicker hiringDate_dateTimePicker;
        private Label hiringDate_label;
        private Button exit_btn;
        private Button delete_btn;
        private Button edit_btn;
        private Button add_btn;
        private Button search_btn;
        private Button new_btn;
        private ComboBox speciality_comboBox;
        private Label speciality_label;
    }
}