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
    public partial class Patient_Manag_Form : Form
    {
        public string DbConnection;
        public Patient_Manag_Form(string dbConnection)
        {
            DbConnection = dbConnection;
            InitializeComponent();
        }

        private void Patient_Manag_Form_Load(object sender, EventArgs e)
        {

        }

        private void new_button_Click(object sender, EventArgs e)
        {
            code_textBox.Text = "";
            name_textBox.Text = "";
            birthDate_dateTimePicker.Text = "";
            address_textBox.Text = "";
            female_radioButton.Checked = false;
            male_radioButton.Checked = false;
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            if (int.TryParse(this.code_textBox.Text, out int value))    //if value of code typed by user is numeric
            {
                string connection = "Data Source=" + DbConnection + @"\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True";
                SqlConnection conn = new SqlConnection(connection);

                string request = "SELECT * FROM Patient WHERE PatientId = " + this.code_textBox.Text;
                SqlCommand cmd = new SqlCommand(request, conn);
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)  //if a doctor with this ID exists
                {
                    do
                    {
                        while (reader.Read())
                        {
                            this.name_textBox.Text = reader["PatientName"].ToString();
                            this.address_textBox.Text = reader["PatientAddress"].ToString();
                            this.birthDate_dateTimePicker.Text = reader["BirthDate"].ToString();
                            if ( String.Equals(reader["PatientGender"].ToString(), "False" ) ) {
                                this.female_radioButton.Checked = true;
                            } 
                            else
                            {
                                this.male_radioButton.Checked = true;
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

        private void add_button_Click(object sender, EventArgs e)
        {
            if (int.TryParse(this.code_textBox.Text, out int value) && name_textBox.Text != "" && address_textBox.Text != "" && (male_radioButton.Checked == true || female_radioButton.Checked == true) )     //if code value is numeric and all fields have been filled in
            {                                                                   
                string connection = "Data Source=" + DbConnection + @"\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True";
                SqlConnection conn = new SqlConnection(connection);

                string request = "SELECT * FROM Patient WHERE PatientId = " + this.code_textBox.Text;
                SqlCommand cmd = new SqlCommand(request, conn);
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)  //if a doctor with this ID exists
                {
                    reader.Close();
                    MessageBox.Show("A patient with this code already exists in the database.");
                }
                else
                {
                    reader.Close();
                    string gender;
                    if(female_radioButton.Checked == true)
                    {
                        gender = "0";
                    } else
                    {
                        gender = "1";
                    }
                    string request2 = "INSERT INTO Patient(PatientId, PatientName, PatientAddress, BirthDate, PatientGender) VALUES(" + this.code_textBox.Text + ", '" + this.name_textBox.Text + "', '" + this.address_textBox.Text + "', '" + this.birthDate_dateTimePicker.Value + "', '" +gender + "');";
                    SqlCommand cmd2 = new SqlCommand(request2, conn);

                    try
                    {
                        int affectedRows = cmd2.ExecuteNonQuery();
                        if (affectedRows <= 0)
                        {
                            MessageBox.Show("An error has been encountered.");
                        }
                        else
                        {
                            MessageBox.Show("Patient added successfully.");
                        }
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message);

                    }
                }
                conn.Close();
            }
            else
            {
                MessageBox.Show("Please type a number for the code and fill in all the fields.");
            }
        }

        private void edit_button_Click(object sender, EventArgs e)
        {
            if (int.TryParse(this.code_textBox.Text, out int value) && name_textBox.Text != "" && address_textBox.Text != "" && (male_radioButton.Checked == true || female_radioButton.Checked == true) )     //if code value is numeric and all fields have been filled in
            {                                                                                                                  // the doctor can either choose an already existing speciality or type a speciality that is not in the database

                if (MessageBox.Show("Are you sure you want to edit this patient's information?", "Edit Patient", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    string connection = "Data Source=" + DbConnection + @"\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True";
                    SqlConnection conn = new SqlConnection(connection);

                    string request = "SELECT * FROM Patient WHERE PatientId = " + this.code_textBox.Text;
                    SqlCommand cmd = new SqlCommand(request, conn);
                    conn.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)  //if a doctor with this ID exists
                    {
                        reader.Close();

                        string gender;
                        if (female_radioButton.Checked == true)
                        {
                            gender = "0";
                        }
                        else
                        {
                            gender = "1";
                        }

                        string request2 = "UPDATE Patient SET PatientName = '" + this.name_textBox.Text + "', PatientAddress = '" + this.address_textBox.Text + "', BirthDate = '" + this.birthDate_dateTimePicker.Value + "', PatientGender = " + gender + " WHERE PatientId = " + this.code_textBox.Text + ";";
                        SqlCommand cmd2 = new SqlCommand(request2, conn);

                        try
                        {
                            int affectedRows = cmd2.ExecuteNonQuery();
                            if (affectedRows <= 0)
                            {
                                MessageBox.Show("An error has been encountered.");
                            }
                            else
                            {
                                MessageBox.Show("Patient information has been successfully edited.");
                            }
                        }
                        catch (Exception err)
                        {
                            MessageBox.Show(err.Message);

                        }
                    }
                    else
                    {
                        reader.Close();
                        MessageBox.Show("No patient with this code has been found in the database.");
                    }
                    conn.Close();
                }

            }
            else
            {
                MessageBox.Show("Please type a number for the code and fill in all the fields.");
            }
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            if (int.TryParse(this.code_textBox.Text, out int value))     //if code value is numeric and all fields have been filled in
            {
                if (MessageBox.Show("Are you sure you want to delete this patient?", "Delete Doctor", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    string connection = "Data Source=" + DbConnection + @"\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True";
                    SqlConnection conn = new SqlConnection(connection);

                    string request = "SELECT * FROM Patient WHERE PatientId = " + this.code_textBox.Text;
                    SqlCommand cmd = new SqlCommand(request, conn);
                    conn.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)  //if a doctor with this ID exists
                    {
                        reader.Close();

                        string request2 = "DELETE FROM Patient WHERE PatientId = " + this.code_textBox.Text + ";";
                        SqlCommand cmd2 = new SqlCommand(request2, conn);

                        try
                        {
                            int affectedRows = cmd2.ExecuteNonQuery();
                            if (affectedRows <= 0)
                            {
                                MessageBox.Show("An error has been encountered.");
                            }
                            else
                            {
                                MessageBox.Show("Patient has been successfully deleted.");
                            }
                        }
                        catch (Exception err)
                        {
                            MessageBox.Show(err.Message);

                        }
                    }
                    else
                    {
                        reader.Close();
                        MessageBox.Show("No patient with this code has been found in the database.");
                    }
                    conn.Close();
                }

            }
            else
            {
                MessageBox.Show("Please type a number for the code.");
            }
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to the patient management system?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
