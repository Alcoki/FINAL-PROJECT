using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CSSFD_FinalProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            string studentNumber = txtStudentNumber.Text;
            int studentYear;

            if (string.IsNullOrEmpty(studentNumber) || !int.TryParse(txtYear.Text, out studentYear))
            {
                lblMessage.Text = "Please enter a valid student number and year.";
                return;
            }

            string connString = "Server=127.0.0.1;Database=studentdb;User ID=root;Password=;CharSet=utf8";
            MySqlConnection conn = new MySqlConnection(connString);
            try
            {
                conn.Open();

                string query = "SELECT full_name FROM students WHERE student_number = @studentNumber";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@studentNumber", studentNumber);

                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string fullName = reader.GetString("full_name");
                    lblMessage.Text = $"Student found: {fullName}";

                    Form2 form2 = new Form2(studentNumber, fullName, studentYear);
                    form2.Show();
                    this.Hide();
                }
                else
                {
                    lblMessage.Text = "Student not found!";
                }
            }
            catch (Exception ex)
            {
                lblMessage.Text = "Error connecting to database: " + ex.Message;
            }
            finally
            {
                conn.Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}