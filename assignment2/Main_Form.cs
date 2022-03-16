using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment2
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();

        }
        

        private void Main_Form_Load(object sender, EventArgs e)
        {

        }

        private void maToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void doctorManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Doc_Manag_Form DocManagForm = new Doc_Manag_Form(this.DbName);
            DocManagForm.ShowDialog();
        }

        private void patientManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Patient_Manag_Form PatientManagForm = new Patient_Manag_Form(this.DbName);
            PatientManagForm.ShowDialog();
        }

        private void appointmentManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Appoint_Manag_Form AppointManagForm = new Appoint_Manag_Form(this.DbName);
            AppointManagForm.ShowDialog();
        }

        private void showAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show_All_Form ShowManagForm = new Show_All_Form(this.DbName);
            ShowManagForm.ShowDialog();
        }

        private void searchAppointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search_Appoint_Form SearchAppointForm = new Search_Appoint_Form(this.DbName);
            SearchAppointForm.ShowDialog();

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to leave the application?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
