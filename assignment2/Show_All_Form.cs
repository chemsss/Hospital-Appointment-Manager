using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment2
{
    public partial class Show_All_Form : Form
    {
        public string DbConnection;
        public Show_All_Form(string dbConnection)
        {
            DbConnection = dbConnection;
            InitializeComponent();
            doctors_radioButton.Checked = false;
            patients_radioButton.Checked = false;
            appoint_radioButton.Checked = false;
        }

        private void doctors_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            string connection = "Data Source=" + DbConnection + @"\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connection);
            conn.Open();
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Doctors", conn))
            {
                DataTable table = new DataTable();
                adapter.Fill(table);

                choice_dataGridView.DataSource = table;

            }

            conn.Close();
        }

        private void patients_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            string connection = "Data Source=" + DbConnection + @"\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connection);
            conn.Open();
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Patient", conn))
            {
                DataTable table = new DataTable();
                adapter.Fill(table);
                
                choice_dataGridView.DataSource = table;

            }

            conn.Close();
        }

        private void appoint_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            string connection = "Data Source=" + DbConnection + @"\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connection);
            conn.Open();
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Appointments", conn))
            {
                DataTable table = new DataTable();
                adapter.Fill(table);

                choice_dataGridView.DataSource = table;

            }

            conn.Close();
        }
    }
}
