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
    public partial class Appoint_Manag_Form : Form
    {
        public string DbConnection;
        public Appoint_Manag_Form(string dbConnection)
        {
            DbConnection = dbConnection;
            InitializeComponent();
        }

        private void get_patients()
        {

            string connection = "Data Source=" + DbConnection + @"\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connection);

            string request = "SELECT PatientId FROM Patient";
            SqlCommand cmd = new SqlCommand(request, conn);
            conn.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)  //if a patient with this ID exists
            {
                do
                {
                    while (reader.Read())
                    {
                        patientCode_comboBox.Items.Add(reader["PatientId"].ToString());
                    }

                } while (reader.NextResult());
            }

            reader.Close();
            conn.Close();

        }

        private void get_doctors()
        {

            string connection = "Data Source=" + DbConnection + @"\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connection);

            string request = "SELECT DoctorId FROM Doctors";
            SqlCommand cmd = new SqlCommand(request, conn);
            conn.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)  //if a doctor with this ID exists
            {
                do
                {
                    while (reader.Read())
                    {
                        doctorCode_comboBox.Items.Add(reader["DoctorId"].ToString());
                    }

                } while (reader.NextResult());
            }

            reader.Close();
            conn.Close();

        }

        private void patientCode_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (int.TryParse(this.patientCode_comboBox.Text, out int value))    //if value of code typed by user is numeric
            {
                string connection = "Data Source=" + DbConnection + @"\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True";
                SqlConnection conn = new SqlConnection(connection);

                string request = "SELECT * FROM Patient WHERE PatientId = " + this.patientCode_comboBox.Text;
                SqlCommand cmd = new SqlCommand(request, conn);
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)  //if a patient with this ID exists
                {
                    do
                    {
                        while (reader.Read())
                        {
                            this.patientName_textBox.Text = reader["PatientName"].ToString();
                            if (String.Equals(reader["PatientGender"].ToString(), "False"))
                            {
                                this.patientFemale_radioButton.Checked = true;
                            }
                            else
                            {
                                this.patientMale_radioButton.Checked = true;
                            }
                        }
                    } while (reader.NextResult());
                }
                else
                {
                    MessageBox.Show("No patient with this code has been found in the database.");
                }


                reader.Close();
                conn.Close();
            }
            else
            {
                MessageBox.Show("Please type a number for the code.");
            }
        }

        private void doctorCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (int.TryParse(this.doctorCode_comboBox.Text, out int value))    //if value of code typed by user is numeric
            {
                string connection = "Data Source=" + DbConnection + @"\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True";
                SqlConnection conn = new SqlConnection(connection);

                string request = "SELECT * FROM Doctors WHERE DoctorId = " + this.doctorCode_comboBox.Text;
                SqlCommand cmd = new SqlCommand(request, conn);
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)  //if a doctor with this ID exists
                {
                    do
                    {
                        while (reader.Read())
                        {
                            this.doctorName_textBox.Text = reader["DoctorName"].ToString();
                            this.doctorSpeciality_textBox.Text = reader["DoctorSpecialism"].ToString();
                        }
                    } while (reader.NextResult());
                }
                else
                {
                    MessageBox.Show("No doctor with this code has been found in the database.");
                }


                reader.Close();
                conn.Close();
            }
            else
            {
                MessageBox.Show("Please type a number for the code.");
            }
        }

        private void appointAdd_button_Click(object sender, EventArgs e)
        {
            if (int.TryParse(this.patientCode_comboBox.Text, out int value) && int.TryParse(this.doctorCode_comboBox.Text, out int value2))     //if code value is numeric and all fields have been filled in
            {
                string connection = "Data Source=" + DbConnection + @"\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True";
                SqlConnection conn = new SqlConnection(connection);

                string request = "INSERT INTO Appointments(AppointmentDate, AppointmentTime, DoctorId, PatientId) values('" + this.appointDate_dateTimePicker.Value + "', '" + this.appointTime_maskedTextBox.Text + "', " + this.doctorCode_comboBox.Text + ", " + this.patientCode_comboBox.Text + ")";
                SqlCommand cmd = new SqlCommand(request, conn);
                conn.Open();

                    try
                    {
                        int affectedRows = cmd.ExecuteNonQuery();
                        if (affectedRows <= 0)
                        {
                            MessageBox.Show("An error has been encountered.");
                        }
                        else
                        {
                            MessageBox.Show("Appointment added successfully.");
                        }
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message);

                    }

                conn.Close();
            }
            else
            {
                MessageBox.Show("Please type a number for the code and fill in all the fields.");
            }
        }

        private void AppointNew_button_Click(object sender, EventArgs e)
        {
            patientCode_comboBox.Text = "";
            doctorCode_comboBox.Text = "";
            patientName_textBox.Text = "";
            doctorName_textBox.Text = "";
            doctorSpeciality_textBox.Text = "";
            patientFemale_radioButton.Checked = false;
            patientMale_radioButton.Checked = false;

            appointDate_dateTimePicker.Text = "";
            appointTime_maskedTextBox.Text = "";
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to the appointment management system?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
