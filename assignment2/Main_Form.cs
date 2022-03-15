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
            string test = DbConnection;
            doctorManagementToolStripMenuItem.Text = DbConnection;
            Doc_Manag_Form DocManagForm = new Doc_Manag_Form("2"/*this.DbConnection*/);
            DocManagForm.ShowDialog();
        }
    }
}
