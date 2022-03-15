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
    public partial class Doc_Manag_Form : Form
    {
        public Doc_Manag_Form()
        {
            InitializeComponent();
        }

        private void doc_manag_groupbox_Enter(object sender, EventArgs e)
        {

        }

        private void name_label_Click(object sender, EventArgs e)
        {

        }

        private void name_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void hiringDate_label_Click(object sender, EventArgs e)
        {

        }

        private void new_btn_Click(object sender, EventArgs e)
        {
            code_textBox.Text = "";
            name_textBox.Text = "";
            telephone_textBox.Text = "";
            hiringDate_dateTimePicker.Text = "";
            speciality_comboBox.Text = "";
        }
        
        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            if (int.TryParse(this.code_textBox.Text, out int value))    //if value of code typed by user is numeric
            {
                string connection = @"Data Source=LAPTOP-VA9S223G\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True";
                SqlConnection conn = new SqlConnection(connection);

                string request = "SELECT * FROM Doctors WHERE DoctorId = " + this.code_textBox.Text;
                SqlCommand cmd = new SqlCommand(request, conn);
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if(reader.HasRows)  //if a doctor with this ID exists
                {
                    do
                    {
                        while (reader.Read())
                        {
                            this.name_textBox.Text = reader["DoctorName"].ToString();
                            this.telephone_textBox.Text = reader["DoctorTel"].ToString();
                            this.hiringDate_dateTimePicker.Text = reader["HiringDate"].ToString();
                            this.speciality_comboBox.Text = reader["DoctorSpecialism"].ToString();
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


        private void add_btn_Click(object sender, EventArgs e)
        {
            if (int.TryParse(this.code_textBox.Text, out int value) && name_textBox.Text!="" && telephone_textBox.Text!="" && (speciality_comboBox.SelectedIndex != -1 || (speciality_comboBox.SelectedIndex == -1 && speciality_comboBox.Text!="") ) )     //if code value is numeric and all fields have been filled in
            {                                                                                                                  // the doctor can either choose an already existing speciality or type a speciality that is not in the database
                string connection = @"Data Source=LAPTOP-VA9S223G\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True";
                SqlConnection conn = new SqlConnection(connection);

                string request = "SELECT * FROM Doctors WHERE DoctorId = " + this.code_textBox.Text;
                SqlCommand cmd = new SqlCommand(request, conn);
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)  //if a doctor with this ID exists
                {
                    reader.Close();
                    MessageBox.Show("A doctor with this code already exists in the database.");
                }
                else
                {
                    reader.Close();

                    string request2 = "INSERT INTO Doctors(DoctorId, DoctorName, DoctorTel, HiringDate, DoctorSpecialism) VALUES(" + this.code_textBox.Text + ", '" + this.name_textBox.Text + "', '" + this.telephone_textBox.Text + "', '" + this.hiringDate_dateTimePicker.Value + "', '" + this.speciality_comboBox.Text + "');";
                    SqlCommand cmd2 = new SqlCommand(request2, conn);

                    try
                    {
                        int affectedRows = cmd2.ExecuteNonQuery();
                        if(affectedRows <= 0)
                        {
                            MessageBox.Show("An error has been encountered.");
                        } 
                        else
                        {
                            MessageBox.Show("Doctor added successfully.");
                        }
                    } catch(Exception err)
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

        private void edit_btn_Click(object sender, EventArgs e)
        {
            if (int.TryParse(this.code_textBox.Text, out int value) && name_textBox.Text != "" && telephone_textBox.Text != "" && (speciality_comboBox.SelectedIndex != -1 || (speciality_comboBox.SelectedIndex == -1 && speciality_comboBox.Text != "")))     //if code value is numeric and all fields have been filled in
            {                                                                                                                  // the doctor can either choose an already existing speciality or type a speciality that is not in the database
                
                if(MessageBox.Show("Are you sure you want to edit this doctor's information?", "Edit Doctor", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    string connection = @"Data Source=LAPTOP-VA9S223G\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True";
                    SqlConnection conn = new SqlConnection(connection);

                    string request = "SELECT * FROM Doctors WHERE DoctorId = " + this.code_textBox.Text;
                    SqlCommand cmd = new SqlCommand(request, conn);
                    conn.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)  //if a doctor with this ID exists
                    {
                        reader.Close();

                        string request2 = "UPDATE Doctors SET DoctorName = '" + this.name_textBox.Text + "', DoctorTel = '" + this.telephone_textBox.Text + "', HiringDate = '" + this.hiringDate_dateTimePicker.Value + "', DoctorSpecialism = '" + this.speciality_comboBox.Text + "' WHERE DoctorId = " + this.code_textBox.Text + ";";
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
                                MessageBox.Show("Doctor information has been successfully edited.");
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
                        MessageBox.Show("No doctor with this code has been found in the database.");
                    }
                    conn.Close();
                }
                
            }
            else
            {
                MessageBox.Show("Please type a number for the code and fill in all the fields.");
            }

        }


        private void delete_btn_Click(object sender, EventArgs e)
        {
            if (int.TryParse(this.code_textBox.Text, out int value))     //if code value is numeric and all fields have been filled in
            {                                                                                
                if (MessageBox.Show("Are you sure you want to delete this doctor?", "Delete Doctor", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    string connection = @"Data Source=LAPTOP-VA9S223G\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True";
                    SqlConnection conn = new SqlConnection(connection);

                    string request = "SELECT * FROM Doctors WHERE DoctorId = " + this.code_textBox.Text;
                    SqlCommand cmd = new SqlCommand(request, conn);
                    conn.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)  //if a doctor with this ID exists
                    {
                        reader.Close();

                        string request2 = "DELETE FROM Doctors WHERE DoctorId = " + this.code_textBox.Text + ";";
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
                                MessageBox.Show("Doctor has been successfully deleted.");
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
                        MessageBox.Show("No doctor with this code has been found in the database.");
                    }
                    conn.Close();
                }

            }
            else
            {
                MessageBox.Show("Please type a number for the code.");
            }

        }


        private void get_specialities()
        {

            string connection = @"Data Source=LAPTOP-VA9S223G\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connection);

            string request = "SELECT Distinct(DoctorSpecialism) FROM Doctors";
            SqlCommand cmd = new SqlCommand(request, conn);
            conn.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)  //if a doctor with this ID exists
            {
                do
                {
                    while (reader.Read())
                    {
                        speciality_comboBox.Items.Add(reader["DoctorSpecialism"].ToString());
                    }

                } while (reader.NextResult());
            }

            reader.Close();
            conn.Close();

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
