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
    public partial class Search_Appoint_Form : Form
    {
        public string DbConnection;
        public Search_Appoint_Form(string dbConnection)
        {
            DbConnection = dbConnection;
            InitializeComponent();
        }

        private void ok_button_Click(object sender, EventArgs e)
        {
            string connection = "Data Source=" + DbConnection + @"\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connection);
            conn.Open();
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Appointments WHERE AppointmentDate = '" + this.dateTimePicker1.Value +"';", conn))
            {
                DataTable table = new DataTable();
                adapter.Fill(table);

                dataGridView1.DataSource = table;

            }

            conn.Close();
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var index = e.RowIndex;

            string connexion = @"Data Source=" + DbConnection + @"\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connexion);

            SqlCommand cmd = new SqlCommand("SELECT * FROM DoctorS WHERE DoctorId = @DoctorId", conn);
            conn.Open();

            cmd.Parameters.AddWithValue("@DoctorId", dataGridView1.Rows[index].Cells[1].Value.ToString());

            SqlDataReader reader = cmd.ExecuteReader();
            do
            {
                while (reader.Read())
                {
                    if (reader != null)
                    {
                        doctorName_textBox.Text = reader["DoctorName"].ToString();
                        textBox2.Text = reader["DoctorSpecialism"].ToString();
                    }
                }
            }
            while (reader.NextResult());
            reader.Close();


            SqlCommand cmd2 = new SqlCommand("SELECT * FROM Patient WHERE PatientId = @PatientId", conn);


            cmd2.Parameters.AddWithValue("@PatientId", dataGridView1.Rows[index].Cells[2].Value.ToString());

            SqlDataReader reader2 = cmd2.ExecuteReader();
            do
            {
                while (reader2.Read())
                {
                    if (reader2 != null)
                    {
                        patientName_textBox.Text = reader2["PatientName"].ToString();
                        dateTimePicker2.Text = reader2["BirthDate"].ToString();
                    }
                }
            }
            while (reader2.NextResult());
            reader2.Close();


            conn.Close();
        }
    }
}
