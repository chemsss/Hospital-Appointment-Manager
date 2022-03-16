
namespace assignment2
{
    partial class Main_Form
    {

        //Database connection information, change the Data Source with your SQL Server name
        private string DbName = "DESKTOP-1NA41IU";


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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.managementSystemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doctorManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patientManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appointmentManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchAppointmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.managementSystemToolStripMenuItem,
            this.consultationToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(713, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // managementSystemToolStripMenuItem
            // 
            this.managementSystemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doctorManagementToolStripMenuItem,
            this.patientManagementToolStripMenuItem,
            this.appointmentManagementToolStripMenuItem});
            this.managementSystemToolStripMenuItem.Name = "managementSystemToolStripMenuItem";
            this.managementSystemToolStripMenuItem.Size = new System.Drawing.Size(131, 20);
            this.managementSystemToolStripMenuItem.Text = "Management System";
            // 
            // doctorManagementToolStripMenuItem
            // 
            this.doctorManagementToolStripMenuItem.Name = "doctorManagementToolStripMenuItem";
            this.doctorManagementToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.doctorManagementToolStripMenuItem.Text = "Doctor Management";
            this.doctorManagementToolStripMenuItem.Click += new System.EventHandler(this.doctorManagementToolStripMenuItem_Click);
            // 
            // patientManagementToolStripMenuItem
            // 
            this.patientManagementToolStripMenuItem.Name = "patientManagementToolStripMenuItem";
            this.patientManagementToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.patientManagementToolStripMenuItem.Text = "Patient Management";
            this.patientManagementToolStripMenuItem.Click += new System.EventHandler(this.patientManagementToolStripMenuItem_Click);
            // 
            // appointmentManagementToolStripMenuItem
            // 
            this.appointmentManagementToolStripMenuItem.Name = "appointmentManagementToolStripMenuItem";
            this.appointmentManagementToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.appointmentManagementToolStripMenuItem.Text = "Appointment Management";
            this.appointmentManagementToolStripMenuItem.Click += new System.EventHandler(this.appointmentManagementToolStripMenuItem_Click);
            // 
            // consultationToolStripMenuItem
            // 
            this.consultationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showAllToolStripMenuItem,
            this.searchAppointmentToolStripMenuItem});
            this.consultationToolStripMenuItem.Name = "consultationToolStripMenuItem";
            this.consultationToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.consultationToolStripMenuItem.Text = "Consultation";
            // 
            // showAllToolStripMenuItem
            // 
            this.showAllToolStripMenuItem.Name = "showAllToolStripMenuItem";
            this.showAllToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.showAllToolStripMenuItem.Text = "Show All";
            this.showAllToolStripMenuItem.Click += new System.EventHandler(this.showAllToolStripMenuItem_Click);
            // 
            // searchAppointmentToolStripMenuItem
            // 
            this.searchAppointmentToolStripMenuItem.Name = "searchAppointmentToolStripMenuItem";
            this.searchAppointmentToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.searchAppointmentToolStripMenuItem.Text = "Search Appointment";
            this.searchAppointmentToolStripMenuItem.Click += new System.EventHandler(this.searchAppointmentToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Main_Form
            // 
            this.ClientSize = new System.Drawing.Size(713, 347);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main_Form";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }





        #endregion


        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem managementSystemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doctorManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patientManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem appointmentManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchAppointmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}